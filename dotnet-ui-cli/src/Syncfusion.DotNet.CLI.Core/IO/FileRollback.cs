using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace Syncfusion.DotNet.CLI.Core;

/// <summary>
/// Records file changes made during a single operation and rolls them back on
/// failure. Only files changed by the current operation are tracked: created
/// files are deleted, modified files are restored to their original content.
/// Backups are kept in memory only; nothing is written outside the project.
/// </summary>
public sealed class FileRollback : IDisposable
{
    private readonly List<string> _created = [];
    private readonly List<string> _createdDirectories = [];
    private readonly List<string> _createdDirectoryTrees = [];
    private readonly List<(string Path, byte[] OriginalContent)> _modified = [];
    private bool _disposed;

    /// <summary>Records that a file will be created at <paramref name="path"/> (rollback deletes it).</summary>
    public void TrackCreated(string path)
    {
        ThrowIfDisposed();
        if (!string.IsNullOrEmpty(path))
        {
            _created.Add(path);
        }
    }

    /// <summary>
    /// Tracks missing directories below <paramref name="boundaryDirectory"/>
    /// so rollback can remove only empty directories created by the current
    /// operation.
    /// </summary>
    public void TrackCreatedDirectories(string directoryPath, string boundaryDirectory)
    {
        ThrowIfDisposed();
        var directory = Path.GetFullPath(directoryPath);
        var boundary = Path.GetFullPath(boundaryDirectory);
        var relative = Path.GetRelativePath(boundary, directory);
        if (Path.IsPathRooted(relative)
            || relative.Equals("..", StringComparison.Ordinal)
            || relative.StartsWith(".." + Path.DirectorySeparatorChar, StringComparison.Ordinal))
        {
            throw new ArgumentException("Tracked directories must be inside the rollback boundary.", nameof(directoryPath));
        }

        var missingDirectories = new List<string>();
        for (var current = directory; !current.Equals(boundary, StringComparison.Ordinal); current = Path.GetDirectoryName(current)!)
        {
            if (Directory.Exists(current))
            {
                break;
            }

            missingDirectories.Add(current);
            var parent = Path.GetDirectoryName(current);
            if (parent is null)
            {
                break;
            }
        }

        foreach (var missingDirectory in missingDirectories.AsEnumerable().Reverse())
        {
            if (!_createdDirectories.Contains(missingDirectory, StringComparer.Ordinal))
            {
                _createdDirectories.Add(missingDirectory);
            }
        }
    }

    /// <summary>
    /// Tracks a previously absent operation-owned directory tree. Rollback
    /// removes the tree if a command partially creates it before failing.
    /// </summary>
    public void TrackCreatedDirectoryTree(string path)
    {
        ThrowIfDisposed();
        var fullPath = Path.GetFullPath(path);
        if (Path.GetPathRoot(fullPath)?.Equals(fullPath, StringComparison.Ordinal) == true)
        {
            throw new ArgumentException("A filesystem root cannot be tracked as an operation-owned directory.", nameof(path));
        }

        if (Directory.Exists(fullPath) || File.Exists(fullPath))
        {
            throw new ArgumentException($"The tracked directory '{fullPath}' must not already exist.", nameof(path));
        }

        if (!_createdDirectoryTrees.Contains(fullPath, StringComparer.Ordinal))
        {
            _createdDirectoryTrees.Add(fullPath);
        }
    }

    /// <summary>
    /// Records that a file will be modified at <paramref name="path"/>. The
    /// current content is captured for restore; if the file does not exist it
    /// is treated as a created file.
    /// </summary>
    public void TrackModified(string path)
    {
        ThrowIfDisposed();
        if (string.IsNullOrEmpty(path))
        {
            return;
        }

        if (File.Exists(path))
        {
            var original = File.ReadAllBytes(path);
            _modified.Add((path, original));
        }
        else
        {
            _created.Add(path);
        }
    }

    /// <summary>
    /// Rolls back every tracked change in reverse order. Created files are
    /// deleted; modified files are restored to their captured content. Best
    /// effort: I/O errors during rollback are collected and returned but do
    /// not stop the rollback from continuing.
    /// </summary>
    public IReadOnlyList<string> Rollback()
    {
        ThrowIfDisposed();
        var errors = new List<string>();

        for (var i = _modified.Count - 1; i >= 0; i--)
        {
            var (path, original) = _modified[i];
            try
            {
                var dir = Path.GetDirectoryName(path);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                File.WriteAllBytes(path, original);
            }
            catch (Exception ex)
            {
                errors.Add($"Failed to restore '{path}': {ex.Message}");
            }
        }

        for (var i = _created.Count - 1; i >= 0; i--)
        {
            var path = _created[i];
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            catch (Exception ex)
            {
                errors.Add($"Failed to delete '{path}': {ex.Message}");
            }
        }

        for (var i = _createdDirectories.Count - 1; i >= 0; i--)
        {
            var directory = _createdDirectories[i];
            try
            {
                if (Directory.Exists(directory) && !Directory.EnumerateFileSystemEntries(directory).Any())
                {
                    Directory.Delete(directory);
                }
            }
            catch (Exception ex)
            {
                errors.Add($"Failed to remove created directory '{directory}': {ex.Message}");
            }
        }

        for (var i = _createdDirectoryTrees.Count - 1; i >= 0; i--)
        {
            var directory = _createdDirectoryTrees[i];
            try
            {
                if (Directory.Exists(directory))
                {
                    Directory.Delete(directory, recursive: true);
                }
            }
            catch (Exception ex)
            {
                errors.Add($"Failed to remove operation-owned directory '{directory}': {ex.Message}");
            }
        }

        _created.Clear();
        _createdDirectories.Clear();
        _createdDirectoryTrees.Clear();
        _modified.Clear();
        return errors;
    }

    /// <summary>Computes the SHA-256 hash of a file, or null if it does not exist.</summary>
    public static string? ComputeHash(string path)
    {
        if (!File.Exists(path))
        {
            return null;
        }

        using var stream = File.OpenRead(path);
        var hash = SHA256.HashData(stream);
        return Convert.ToHexString(hash).ToLowerInvariant();
    }

    /// <summary>Commits the tracked changes (clears tracking without rollback).</summary>
    public void Commit()
    {
        ThrowIfDisposed();
        _created.Clear();
        _createdDirectories.Clear();
        _createdDirectoryTrees.Clear();
        _modified.Clear();
    }

    public void Dispose()
    {
        _disposed = true;
        _created.Clear();
        _createdDirectories.Clear();
        _createdDirectoryTrees.Clear();
        _modified.Clear();
    }

    private void ThrowIfDisposed()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(nameof(FileRollback));
        }
    }
}

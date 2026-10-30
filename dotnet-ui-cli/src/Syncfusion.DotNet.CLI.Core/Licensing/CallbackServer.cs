using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Web;

namespace Syncfusion.DotNet.Cli.Core.Licensing;

/// <summary>
/// Minimal loopback HTTP listener that receives the OAuth redirect (or the sign-out return). Built on
/// <see cref="TcpListener"/> rather than HttpListener so the request is accepted whatever Host header the
/// browser sends (<c>localhost</c> vs <c>127.0.0.1</c>), and reachable over both IPv4 and IPv6 loopback.
/// </summary>
public sealed class CallbackServer : IDisposable
{
    private readonly List<TcpListener> _listeners = [];
    private readonly string _path;
    private readonly string _title;

    private CallbackServer(int port, string path, string title)
    {
        Port = port;
        _path = path;
        _title = title;
    }

    public int Port { get; }

    /// <summary>Starts on the first free port; returns null when every port is in use.</summary>
    public static CallbackServer? TryStart(IEnumerable<int> ports, string path, string title)
    {
        foreach (var port in ports)
        {
            var server = new CallbackServer(port, path, title);
            try
            {
                // "localhost" may resolve to ::1 or 127.0.0.1 depending on the browser, so listen on both.
                server.Listen(IPAddress.Loopback, port);
                try { server.Listen(IPAddress.IPv6Loopback, port); } catch (SocketException) { /* IPv6 unavailable */ }
                return server;
            }
            catch (SocketException) { server.Dispose(); }
        }

        return null;
    }

    private void Listen(IPAddress address, int port)
    {
        var listener = new TcpListener(address, port);
        listener.Start();
        _listeners.Add(listener);
    }

    /// <summary>Waits for a request to the callback path; returns its query, or null on timeout.</summary>
    public async Task<IReadOnlyDictionary<string, string>?> WaitAsync(TimeSpan timeout, CancellationToken cancellationToken)
    {
        using var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        cts.CancelAfter(timeout);
        var accepts = _listeners.Select(l => AcceptLoopAsync(l, cts.Token)).ToList();
        try
        {
            var done = await Task.WhenAny(accepts).ConfigureAwait(false);
            return await done.ConfigureAwait(false);
        }
        catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
        {
            return null;
        }
        finally
        {
            await cts.CancelAsync().ConfigureAwait(false);
        }
    }

    private async Task<IReadOnlyDictionary<string, string>> AcceptLoopAsync(TcpListener listener, CancellationToken ct)
    {
        while (true)
        {
            using var client = await listener.AcceptTcpClientAsync(ct).ConfigureAwait(false);
            var stream = client.GetStream();
            string? requestLine;
            try
            {
                using var reader = new StreamReader(stream, Encoding.ASCII, false, 4096, leaveOpen: true);
                requestLine = await reader.ReadLineAsync(ct).ConfigureAwait(false);
            }
            catch (IOException) { continue; }

            // "GET /callback?code=...&state=... HTTP/1.1"
            var parts = requestLine?.Split(' ');
            if (parts is not { Length: >= 2 } || parts[0] != "GET") { await RespondAsync(stream, 400, "Bad Request", ct).ConfigureAwait(false); continue; }
            var target = parts[1];
            var q = target.IndexOf('?', StringComparison.Ordinal);
            var path = q < 0 ? target : target[..q];
            if (!string.Equals(path, _path, StringComparison.Ordinal)) { await RespondAsync(stream, 404, "Not Found", ct).ConfigureAwait(false); continue; }

            var query = HttpUtility.ParseQueryString(q < 0 ? "" : target[(q + 1)..]);
            var result = query.AllKeys.Where(k => k is not null).ToDictionary(k => k!, k => query[k] ?? "");
            var failed = result.ContainsKey("error");
            var page = $"<!doctype html><html><head><meta charset=\"utf-8\"><title>Syncfusion CLI</title></head><body style=\"font-family:sans-serif;text-align:center;margin-top:15vh\"><h2>{(failed ? "Sign-in failed" : _title)}</h2><p>You can close this tab and return to the terminal.</p></body></html>";
            await RespondAsync(stream, 200, page, ct).ConfigureAwait(false);
            return result;
        }
    }

    private static async Task RespondAsync(NetworkStream stream, int status, string body, CancellationToken ct)
    {
        var bytes = Encoding.UTF8.GetBytes(body);
        var reason = status switch { 200 => "OK", 400 => "Bad Request", _ => "Not Found" };
        var header = $"HTTP/1.1 {status} {reason}\r\nContent-Type: text/html; charset=utf-8\r\nContent-Length: {bytes.Length}\r\nConnection: close\r\n\r\n";
        await stream.WriteAsync(Encoding.ASCII.GetBytes(header), ct).ConfigureAwait(false);
        await stream.WriteAsync(bytes, ct).ConfigureAwait(false);
        await stream.FlushAsync(ct).ConfigureAwait(false);
    }

    public void Dispose()
    {
        foreach (var l in _listeners) l.Stop();
    }
}

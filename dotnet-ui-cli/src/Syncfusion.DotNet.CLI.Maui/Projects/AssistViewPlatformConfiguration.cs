using System.Xml.Linq;

namespace Syncfusion.DotNet.Cli.Maui;

/// <summary>Platform declarations for attachments in newly generated AssistView samples.</summary>
public static class AssistViewPlatformConfiguration
{
    public static readonly IReadOnlyList<string> Files =
    [
        "Platforms/Android/AndroidManifest.xml",
        "Platforms/iOS/Info.plist",
        "Platforms/MacCatalyst/Info.plist",
        "Platforms/MacCatalyst/Entitlements.plist",
    ];

    public static void Apply(string projectRoot)
    {
        var androidPath = Path.Combine(projectRoot, Files[0]);
        var android = XDocument.Load(androidPath);
        XNamespace ns = "http://schemas.android.com/apk/res/android";
        foreach (var (name, maximum) in new[]
        {
            ("READ_EXTERNAL_STORAGE", "32"),
            ("WRITE_EXTERNAL_STORAGE", "28"),
            ("READ_MEDIA_IMAGES", (string?)null),
        })
        {
            if (android.Root!.Elements("uses-permission").Any(element =>
                (string?)element.Attribute(ns + "name") == "android.permission." + name)) continue;
            var permission = new XElement("uses-permission", new XAttribute(ns + "name", "android.permission." + name));
            if (maximum is not null) permission.Add(new XAttribute(ns + "maxSdkVersion", maximum));
            android.Root.Add(permission);
        }
        android.Save(androidPath);

        const string description = "Select photos to attach to your AssistView message.";
        AddPlistValues(Path.Combine(projectRoot, Files[1]), [("NSPhotoLibraryUsageDescription", new XElement("string", description))]);
        AddPlistValues(Path.Combine(projectRoot, Files[2]), [("NSPhotoLibraryUsageDescription", new XElement("string", description))]);
        AddPlistValues(Path.Combine(projectRoot, Files[3]),
        [
            ("com.apple.security.assets.pictures.read-write", new XElement("true")),
            ("com.apple.security.files.downloads.read-write", new XElement("true")),
            ("com.apple.security.files.user-selected.read-write", new XElement("true")),
            ("com.apple.security.personal-information.photos-library", new XElement("true")),
        ]);
    }

    private static void AddPlistValues(string path, IEnumerable<(string Key, XElement Value)> values)
    {
        var document = XDocument.Load(path);
        var dictionary = document.Root!.Element("dict")!;
        foreach (var (key, value) in values)
        {
            if (dictionary.Elements("key").Any(element => element.Value == key)) continue;
            dictionary.Add(new XElement("key", key), value);
        }
        document.Save(path);
    }
}

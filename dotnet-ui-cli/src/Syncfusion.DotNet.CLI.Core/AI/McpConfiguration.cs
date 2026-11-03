using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Syncfusion.DotNet.Cli.Core.AI;

public sealed record McpConfigurationChange(string Content, bool Changed);

/// <summary>Edits only the selected server value, retaining surrounding JSONC text.</summary>
public static class McpConfiguration
{
    private static readonly JsonDocumentOptions DocumentOptions = new()
    {
        CommentHandling = JsonCommentHandling.Skip, AllowTrailingCommas = true,
    };
    private static readonly JsonReaderOptions ReaderOptions = new()
    {
        CommentHandling = JsonCommentHandling.Skip, AllowTrailingCommas = true,
    };
    private static readonly JsonSerializerOptions OutputOptions = new() { WriteIndented = true };

    public static McpConfigurationChange Merge(string original, AiClient client, string serverName, JsonObject server, bool force)
    {
        using var document = JsonDocument.Parse(original, DocumentOptions);
        ValidateObject(document.RootElement);
        var root = document.RootElement;
        if (root.ValueKind != JsonValueKind.Object)
            throw new InvalidOperationException("The MCP configuration root must be a JSON object.");
        var bytes = Encoding.UTF8.GetBytes(original);
        var (rootStart, _) = RootSpan(bytes);
        if (!root.TryGetProperty(client.ServerProperty, out var group))
        {
            var value = new JsonObject { [serverName] = server.DeepClone() }.ToJsonString(OutputOptions);
            return new(Insert(bytes, rootStart, client.ServerProperty, value, root.EnumerateObject().Any()), true);
        }
        if (group.ValueKind != JsonValueKind.Object)
            throw new InvalidOperationException($"The MCP '{client.ServerProperty}' property must be an object.");
        var (groupStart, groupEnd) = PropertySpan(bytes.AsSpan(rootStart), client.ServerProperty);
        groupStart += rootStart;
        groupEnd += rootStart;
        var replacement = server.ToJsonString(OutputOptions);
        if (group.TryGetProperty(serverName, out var existing))
        {
            if (JsonNode.DeepEquals(JsonNode.Parse(existing.GetRawText(), documentOptions: DocumentOptions), server))
                return new(original, false);
            if (!force)
                throw new InvalidOperationException($"The '{serverName}' MCP entry already differs. Review it and use --force to replace only this entry.");
            var (start, end) = PropertySpan(bytes.AsSpan(groupStart, groupEnd - groupStart), serverName);
            return new(Replace(bytes, groupStart + start, groupStart + end, replacement), true);
        }
        return new(Insert(bytes, groupStart, serverName, replacement, group.EnumerateObject().Any()), true);
    }

    public static JsonObject Server(AiPlatform platform, AiClient client, string keyFile, bool local)
    {
        var result = new JsonObject();
        if (client.ExplicitStdio) result["type"] = "stdio";
        result["command"] = local ? "dotnet" : "dnx";
        result["args"] = local
            ? new JsonArray("tool", "run", platform.ToolCommand)
            : new JsonArray(platform.McpPackage, "--yes");
        result["env"] = new JsonObject { ["Syncfusion_API_Key_Path"] = keyFile };
        return result;
    }

    private static void ValidateObject(JsonElement element)
    {
        if (element.ValueKind == JsonValueKind.Object)
        {
            var names = new HashSet<string>(StringComparer.Ordinal);
            foreach (var property in element.EnumerateObject())
            {
                if (!names.Add(property.Name))
                    throw new InvalidOperationException("The MCP configuration contains duplicate JSON properties; resolve them before setup.");
                ValidateObject(property.Value);
            }
        }
        else if (element.ValueKind == JsonValueKind.Array)
            foreach (var item in element.EnumerateArray()) ValidateObject(item);
    }

    private static (int Start, int End) RootSpan(ReadOnlySpan<byte> bytes)
    {
        var reader = new Utf8JsonReader(bytes, ReaderOptions);
        reader.Read();
        var start = checked((int)reader.TokenStartIndex);
        reader.Skip();
        return (start, checked((int)reader.BytesConsumed));
    }

    private static (int Start, int End) PropertySpan(ReadOnlySpan<byte> bytes, string name)
    {
        var reader = new Utf8JsonReader(bytes, ReaderOptions);
        reader.Read();
        while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
        {
            var match = reader.ValueTextEquals(name);
            reader.Read();
            var start = checked((int)reader.TokenStartIndex);
            reader.Skip();
            if (match) return (start, checked((int)reader.BytesConsumed));
        }
        throw new InvalidOperationException("The MCP configuration changed while planning the update.");
    }

    private static string Insert(byte[] bytes, int objectStart, string name, string value, bool hasProperties)
        => Replace(bytes, objectStart + 1, objectStart + 1,
            "\n  " + JsonSerializer.Serialize(name) + ": " + value + (hasProperties ? "," : "") + "\n");

    private static string Replace(byte[] bytes, int start, int end, string value)
        => Encoding.UTF8.GetString(bytes, 0, start) + value + Encoding.UTF8.GetString(bytes, end, bytes.Length - end);
}

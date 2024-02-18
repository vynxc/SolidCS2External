using System.Text.Json;
using System.Text.Json.Serialization;

namespace SolidCS2External.Game.Offsets;

// Reversed from https://github.com/a2x/cs2-dumper/blob/main/src/builder/json_file_builder.rs

// ReSharper disable once ClassNeverInstantiated.Global
internal class JsonOffsetValue
{
    [JsonPropertyName("value")] public int Value { get; set; }

    [JsonPropertyName("comment")] public string? Comment { get; set; }
}

// ReSharper disable once ClassNeverInstantiated.Global
internal class JsonModule
{
    [JsonPropertyName("data")] public Dictionary<string, JsonOffsetValue> Data { get; set; } = null!;
}

public static class OffsetsReader
{
    private static readonly Dictionary<string, Dictionary<string, JsonModule>> Cache = new();

    private static Dictionary<string, JsonModule>? ReadJsonFile(string filePath)
    {
        var jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<Dictionary<string, JsonModule>>(jsonString);
    }

    public static int ReadOffset(string filePath, string className, string offsetName)
    {
        if (!Cache.TryGetValue(filePath, out var jsonFile))
        {
            jsonFile = ReadJsonFile(filePath);
            Cache[filePath] = jsonFile ?? throw new Exception("Failed to read json file");
        }


        if (jsonFile.TryGetValue(className, out var module) &&
            module.Data.TryGetValue(offsetName, out var value))
            return value.Value;

        throw new Exception($"Failed to find offset {offsetName} in class {className}");
    }
}
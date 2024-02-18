// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace OffsetSourceFileUpdater;

internal static class Program
{
    private static readonly string[] Files = ["client.dll.cs", "offsets.cs"];
    private const string RepoDirUrl = "https://github.com/a2x/cs2-dumper/raw/main/generated/";

    private static void Main()
    {
        using var httpClient = new HttpClient();
        var slnDir = GetSolutionDirPath("SolidCS2External", 6);
        var dstDir = $"{slnDir}/SolidCS2External/Game/Offsets/";
        
        foreach (var f in Files)
        {
            var fullUrl = RepoDirUrl + f;
            
            var contentStream = httpClient.GetStreamAsync(fullUrl).Result;
            using var fs = File.Create(dstDir + f);

            contentStream.CopyTo(fs);
        }
    }

    private static string GetSolutionDirPath(string slnName, int maxUpwardsDepth = 5)
    {
        if (!slnName.EndsWith(".sln"))
            slnName += ".sln";

        var e = new Exception("No sln file found"); // lazy
        var slnDirPath = string.Empty;
        var currentDirPath = AppContext.BaseDirectory.TrimEnd('\\').TrimEnd('/'); // Directory.GetParent doesn't get parent of path with separator
        
        for (var i = 0; i < maxUpwardsDepth; i++)
        {
            if (File.Exists(Path.Combine(currentDirPath, slnName)))
            {
                slnDirPath = currentDirPath;
                break;
            }

            currentDirPath = Directory.GetParent(currentDirPath)?.FullName ?? throw e;
        }

        if (string.IsNullOrWhiteSpace(slnDirPath))
            throw e;

        return slnDirPath;
    }
}
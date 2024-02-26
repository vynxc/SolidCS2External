// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Serilog;

namespace OffsetSourceFileUpdater;

internal static class Program
{
    private static readonly string[] Files = ["client.dll.cs", "offsets.cs"];
    private const string RepoDirUrl = "https://github.com/a2x/cs2-dumper/raw/main/generated/";
    private static readonly ILogger Logger = new LoggerConfiguration()
        .MinimumLevel.Verbose()
        .WriteTo.Console()
        .CreateLogger();

    private static void Main()
    {
        using var httpClient = new HttpClient();
        var slnDir = GetSolutionDirPath("SolidCS2External");
        var dstDir = $"{slnDir}/SolidCS2External/Game/Offsets/";
        Logger.Information("Resolved solution offset directory: {Dir}", dstDir);
        
        
        foreach (var f in Files)
        {
            var fullUrl = RepoDirUrl + f;
            var dstPath = dstDir + f;
            Logger.Information("Downloading {File} to {DstPath} from: {Url}", f, dstPath, fullUrl);
            
            var contentStream = httpClient.GetStreamAsync(fullUrl).Result;
            using var fs = File.Create(dstPath);

            contentStream.CopyTo(fs);
            Logger.Information("Done downloading {File}", f);
        }
    }

    private static string GetSolutionDirPath(string slnName, int maxUpwardsDepth = 6)
    {
        if (!slnName.EndsWith(".sln"))
            slnName += ".sln";

        var e = new Exception("No sln file found"); // lazy
        var slnDirPath = string.Empty;
        var currentDirPath = AppContext.BaseDirectory.TrimEnd('\\').TrimEnd('/'); // Directory.GetParent doesn't get parent of path with separator
        
        for (var i = 0; i < maxUpwardsDepth; i++)
        {
            var pathToCheck = Path.Combine(currentDirPath, slnName);
            Logger.Debug("({Attempt}/{MaxAttempts}) Checking path for {SlnName}: {DirPath}",
                i + 1,
                maxUpwardsDepth,
                slnName,
                pathToCheck);
            
            if (File.Exists(pathToCheck))
            {
                slnDirPath = currentDirPath;
                Logger.Debug("Found sln path: {Path}", slnDirPath);
                break;
            }

            currentDirPath = Directory.GetParent(currentDirPath)?.FullName ?? throw e;
        }

        if (string.IsNullOrWhiteSpace(slnDirPath))
            throw e;

        return slnDirPath;
    }
}
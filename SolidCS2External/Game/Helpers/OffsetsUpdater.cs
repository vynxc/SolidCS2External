using SolidCS2External.Interfaces;
using SolidCS2External.Utils;

namespace SolidCS2External.Game.Offsets;

[Obsolete("Replaced by OffsetSourceFileUpdater")]
public static class OffsetsUpdater
{
    private static readonly string[] Files = { "client.dll.json", "offsets.json" };

    public static async Task UpdateOffsets()
    {
        IFileDownloader fileDownloader = new FileDownloader(new HttpClient());
        foreach (var file in Files)
        {
            var url = $"https://github.com/a2x/cs2-dumper/raw/main/generated/{file}";
            var destinationPath = Path.Combine(Directory.GetCurrentDirectory(), file);
            await fileDownloader.DownloadFileAsync(url, destinationPath);
        }
    }
}
using SolidCS2External.Interfaces;

namespace SolidCS2External.Utils;

public class FileDownloader(HttpClient httpClient) : IFileDownloader
{
    public async Task DownloadFileAsync(string url, string destinationPath)
    {
        var response = await httpClient.GetAsync(url);

        await using var ms = await response.Content.ReadAsStreamAsync();
        await using var fs = File.Create(destinationPath);

        ms.Seek(0, SeekOrigin.Begin);
        await ms.CopyToAsync(fs);
    }
}
namespace SolidCS2External.Interfaces;

public interface IFileDownloader
{
    Task DownloadFileAsync(string url, string destinationPath);
}
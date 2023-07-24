namespace LeaderAnalytics.Vyntix.Domain;

public interface IFredDownloader
{
    IDownloadJobStatistics JobStatistics { get; }
    Task<DownloadResult> Download(FredDownloadJobArgs jobArgs);
    void Cancel();
}
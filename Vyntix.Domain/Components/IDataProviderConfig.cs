namespace LeaderAnalytics.Vyntix.Domain.Components;

public interface IDataProviderConfig
{
    int ID { get; }
    string Name { get; }
    int SystemID { get; }
    string DownloadURI { get; }
    string Login { get; }
    string Password { get; }
    DateTime? LastDownload { get; }
    DownloadResult LastDownloadResult { get; }
    int UserID { get; }
}

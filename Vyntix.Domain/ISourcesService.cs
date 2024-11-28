namespace LeaderAnalytics.Vyntix.Domain;

public interface ISourcesService : IDisposable
{
    Task<Source> GetSourceByNativeID(string nativeID, int dataProviderID);
    Task<Model.RowOpResult> DeleteSource(string nativeID, int dataProviderID);
    Task<Model.RowOpResult> SaveSource(Source source, bool saveChanges = true);
    Task<List<Source>> GetSourcesForDataProviders(int[] dataProviderIDs);
    Task ImportSources(List<Source> sources, IDownloadJobStatistics jobStatistics);
    void deleteSourcesForDataProvider(int dataProviderID);
}

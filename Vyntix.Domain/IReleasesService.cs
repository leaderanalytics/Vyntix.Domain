namespace LeaderAnalytics.Vyntix.Domain;

public interface IReleasesService : IDisposable
{
    Task<Release> GetReleaseByNativeID(string nativeID, int dataProviderID);
    Task<Model.RowOpResult<Release>> SaveRelease(Release release, bool saveChanges = true);
    Task<List<Release>> GetReleasesForDataProviders(int[] dataProviderIDs);
    Task<ValidationResult<Release>> ValidateRelease(Release release);
    Task<Model.RowOpResult> DeleteRelease(string nativeID, int dataProviderID);
    Task ImportReleases(List<Release> releases, IDownloadJobStatistics jobStatistics);
    Task ImportReleaseDates(IGrouping<string, ReleaseDate> releaseDates, DataProvider dataProvider, IDownloadJobStatistics jobStatistics);
    Task<HashSet<string>> GetReleaseSeriesByNativeID(string nativeID, int dataProviderID);
    Task<List<ReleaseDate>> GetReleaseDatesByNativeID(string nativeID, int dataProviderID);
    void deleteReleasesForDataProvider(int dataProviderID);
}

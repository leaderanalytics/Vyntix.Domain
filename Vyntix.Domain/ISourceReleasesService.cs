namespace LeaderAnalytics.Vyntix.Domain;

public interface ISourceReleasesService : IDisposable
{
    Task<AsyncResult<List<SourceRelease>>> GetSourceReleasesForSource(int sourceDataProviderID);
    Task<AsyncResult<List<SourceRelease>>> GetSourceReleasesForRelease(int releaseDataProviderID);
    Task<Model.RowOpResult> SaveSourceRelease(SourceRelease sourceRelease, bool saveChanges=true);
    Task<Model.RowOpResult> SaveSourceReleases(IEnumerable<SourceRelease> sourceReleases);
    Task<Model.RowOpResult> DeleteSourceReleasesForSource(string nativeId, int dataProviderID);
    Task<Model.RowOpResult> DeleteSourceReleasesForRelease(string nativeId, int dataProviderID);
    Task<ValidationResult<SourceRelease>> ValidateSourceRelease(SourceRelease sr);
    void deleteSourceReleasesForDataProvider(int dataProviderID);
}

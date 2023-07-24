namespace LeaderAnalytics.Vyntix.Domain;

public interface ISeriesService : IDisposable
{
    Task<RowOpResult> SaveSeries(Series s, bool saveChanges = true);
    Task<Series> GetSeriesByNativeID(string nativeID, int dataProviderID);
    Task<List<Series>> GetSeriesForCategoryAsync(string categoryNativeID, int dataProviderID);
    Task<List<Series>> GetSeriesForDataProviderAsync(int dataProviderID, DateTime? lastDataUpdate, int skip, int take, bool includeDiscontinued = false);
    Task<int> UpdateHasVintageDatesFlagAsync(IEnumerable<string> symbols, int dataProviderID);
    Task AddOrUpdateSeriesAsync(System.Data.DataTable dt);
    Task<RowOpResult> DeleteSeries(string nativeID, int dataProviderID);
    Task<AsyncResult<Series>> CopySeriesAsync(Series fromSeries);
    Task<AsyncResult<List<Series>>> SearchSeries(int[] dataProviderIDs, string[] names, string[] symbols, string[] notes, bool includeDiscontinued,
        int[] reportingFrequencyIDs, DateTime? lastDataUpdateStart, DateTime? lastDataUpdateEnd,
        int pageIndex, string sortKey, System.ComponentModel.ListSortDirection sortDir, int pageSize);

    Task<User> GetSeriesOwnerAsync(string symbol, int dataProviderID);
    Task DeleteSeriesForDataProviderID(int dataProviderID);
    Task UpdateLastDataRequestTimeStamp(string nativeID, int dataProviderID);
    Task UpdateLastDataRequestTimeStamp(Series series);
    Task<List<string>> GetNativeIDsForDataProvider(int dataProviderID, bool includeDiscontinued, int skip, int take);
    Task<int> GetSeriesCountForDownload(int dataProviderID, bool includeDiscontinued);
    
    Task ImportSeries(List<Series> series, IDownloadJobStatistics jobStatistics);
    

    Task DisableSeriesTableIndexes();
    Task RebuildSeriesTableIndexes();
    Task<bool> SeriesExists(string nativeID, int dataProviderID);
}

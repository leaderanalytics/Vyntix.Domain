using System.ServiceModel;

namespace LeaderAnalytics.Vyntix.Domain;

public interface IWatchListService : IDisposable
{
    [OperationContract]
    Task<List<WatchListItem>> GetWatchListItemsAsync(int userID, int dataProviderID);

    [OperationContract]
    Task<RowOpResult> DeleteWatchListItemAsync(WatchListItem watchListItem);

    [OperationContract]
    Task<RowOpResult<WatchList>> ReplaceWatchList(WatchList watchList);

    [OperationContract]
    Task<int> SaveWatchListItemAsync(WatchListItem item);

    Task<List<WatchList>> GetWatchListGraphsForUser(int userID);
    Task<RowOpResult> DeleteWatchList(WatchList wl);
}

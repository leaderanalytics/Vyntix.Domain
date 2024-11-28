using System.ServiceModel;

namespace LeaderAnalytics.Vyntix.Domain;

public interface IWatchListService : IDisposable
{
    [OperationContract]
    Task<List<WatchListItem>> GetWatchListItemsAsync(int userID, int dataProviderID);

    [OperationContract]
    Task<Model.RowOpResult> DeleteWatchListItemAsync(WatchListItem watchListItem);

    [OperationContract]
    Task<Model.RowOpResult<WatchList>> ReplaceWatchList(WatchList watchList);

    [OperationContract]
    Task<int> SaveWatchListItemAsync(WatchListItem item);

    Task<List<WatchList>> GetWatchListGraphsForUser(int userID);
    Task<Model.RowOpResult> DeleteWatchList(WatchList wl);
}

namespace LeaderAnalytics.Vyntix.Domain;

public interface IDataProviderService : IDisposable
{
    Task<AsyncResult> SaveDataProviderAsync(DataProvider dp);
    Task<AsyncResult> DeleteDataProviderAsync(DataProvider dp, int userID);
    Task<AsyncResult> PurgeDataForDataProvider(DataProvider dp);
    Task<DataProvider> GetFredDataProviderAsync();
    Task<DataProvider> GetQuandlDataProviderAsync();
    Task<IDataProviderConfig> GetFredConfigAsync();
    Task<IDataProviderConfig> GetQuandlConfigAsync();
    Task<List<DataProvider>> GetAuthorizedDataProviders(DataPermission dataPermission);
    Task<List<DataProvider>> GetSessionAuthorizedDataProviders(DataPermission dataPermission);
    Task<IDataProviderConfig> GetDataProviderConfigAsync(DataProviderSystemID systemID);
    IDataProviderConfig GetDataProviderConfig(DataProviderSystemID systemID);  // used by Fred client - cannot inject async
    Task<List<DataProvider>> GetAllDataProviders();
    Task<DataProvider> GetDataProvider(int dataProviderID);
    Task<List<DataProvider>> GetAuthorizedDataProviderGraphs(DataPermission dataPermission);
}

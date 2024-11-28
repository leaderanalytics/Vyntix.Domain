using System.ServiceModel;

namespace LeaderAnalytics.Vyntix.Domain;

public interface IVintagesService : IDisposable
{
    [OperationContract]
    Task<bool> IsDupe(Vintage vd);

    [OperationContract]
    Task<Model.RowOpResult> SaveVintage(Vintage vintage, bool saveChanges = true);

    [OperationContract]
    Task<DateTime?> GetMaxVintageDate(string symbol, int seriesDataProviderID, int dataProviderID);

    [OperationContract]
    Task<List<Vintage>> GetVintagesWithModelRefForSeries(string nativeID, int seriesDataProviderID, int[] dataProviderIDs);

    [OperationContract]
    Task<AsyncResult> DeleteVintage(Vintage vintage);

    [OperationContract]
    Task<Vintage> CopyVintage(long vintageID);

    [OperationContract]
    Task<List<Vintage>> GetVintagesForSeriesAsync(string symbol, int[] dataProviderIDs, DateTime? startObsDate, DateTime? endObsDate);

    Task<List<Vintage>> GetVintagesForSeriesDataProvider(int seriesDataProviderID, int dataProviderID, int skip, int take);
    Task<AsyncResult> ValidateVintage(Vintage vintage);
    Task<bool> IsVintageLatest(Vintage v);
    Task ImportVintagesForUpdate(List<Vintage> vintages, int batchSize);
}

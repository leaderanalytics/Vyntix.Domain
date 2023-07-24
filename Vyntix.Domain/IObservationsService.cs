namespace LeaderAnalytics.Vyntix.Domain;

public interface IObservationsService : IDisposable
{
    Task<RowOpResult<List<Observation>>> CopyObservations(long fromVintageID, long toVintageID);
    Task<bool> ObservationExists(Observation obs);
    Task<DateTime?> GetNextObservationDate(string nativeID, int dataProviderID);
    Task<List<Observation>> GetObservationsForSeries(string nativeID, int dataProviderID, DateTime? startObsDate, DateTime? endObsDate);
    Task<List<ObservationMatrixCell>> GetObservationsForDataSetSeries(DataSetSeries dataSetSeries, DateTime? startObsDate, DateTime? endObsDate, DateTime expiredForecastCutoff);
    Task<List<Series>> GetSeriesForDataSet(DateTime? startDate, DateTime? endDate, List<DataSetSeries> dataSetSeries);
    Task<AsyncResult> SaveObservation(Observation o);
    Task<RowOpResult> DeleteObservation(Observation o);
    Task<List<Observation>> GetObservationsForDataProvider(int dataProviderID, int userID, int skip, int take);
    Task ImportObservations(IGrouping<long, Observation> observations, IDownloadJobStatistics jobStatistics, int batchSize);
    AsyncResult<string[,]> ObservationSheet(List<Vintage> vintages, bool makeDense);
    AsyncResult<string> ObservationsToCSV(List<Vintage> vintages, bool makeDense);

}

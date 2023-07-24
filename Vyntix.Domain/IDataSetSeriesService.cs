namespace LeaderAnalytics.Vyntix.Domain;

public interface IDataSetSeriesService : IDisposable
{
    Task SaveDataSetSeries(int dataSetID, ICollection<DataSetSeries> dataSetSeries);
    Task DeleteDataSetSeries(int dataSetSeriesID);
    Task DeleteDataSetSeries(DataSetSeries dataSetSeries);
    Task DeleteDataSetSeriesForDataSet(int dataSetID);
}

namespace LeaderAnalytics.Vyntix.Domain;

public interface IDataSetService : IDisposable
{
    Task<List<DataSet>> GetPresDataSetsForUserAsync();
    Task<string> SaveDataSetAsync(DataSet dataSet);
    Task<int> DeleteDataSetAsync(DataSet dataSet);
    Task<AsyncResult<DataSet>> LoadDataSetByID(int id);
    Task<DataSet> GetDataSetByIDAsync(int id);
    Task CopyDataSet(int id);
    Task<String> CheckForDupeFileName(int dataSetID, string filePath);
    Task<int> DeleteDataSetAsync(int id);
    ValidationResult<DataSetSeries> ValidateDataSetSeries(DataSetSeries dataSetSeries);
    Task<AsyncResult> ValidatePermissionToModifyDataSet(DataSet ds);
}

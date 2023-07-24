namespace LeaderAnalytics.Vyntix.Domain;

public interface IAlignmentService : IDisposable
{
    Task<FileInfo> GenerateDataFile(DataSet m, CancellationToken cancelToken);
    Task<AsyncResult<ObservationMatrix>> GetMatrix(DataSet m, CancellationToken cancelToken);

}

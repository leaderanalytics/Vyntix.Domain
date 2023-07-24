namespace LeaderAnalytics.Vyntix.Domain;

public interface IReportingFrequenciesService : IDisposable
{
    Task<List<ReportingFrequency>> GetReportingFrequenciesAsync();
    Task<ReportingFrequency> GetReportingFrequencyForNativeFrequency(string nativeFrequency);
    Task<DateTime> GetNextDateForFrequencyAsync(int reportingFrequencyID, DateTime d);
    DateTime GetNextDateForFrequency(ReportingFrequency frequency, DateTime d);
}

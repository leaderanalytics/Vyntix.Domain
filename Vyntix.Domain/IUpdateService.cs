namespace LeaderAnalytics.Vyntix.Domain;

public interface IUpdateService
{
    Task<List<Series>> UpdateVintagesForSeriesAsync(List<Series> series);
}

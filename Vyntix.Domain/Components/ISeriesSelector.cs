namespace LeaderAnalytics.Vyntix.Domain.Components;

public interface ISeriesSelector : IInitialization
{
    IEnumerable<Series> SelectedSeries { get; }
    List<Series> GetSelectedSeries();
    bool? ShowDialog(bool multipleSelectionMode, IEnumerable<Series> selectedSeries, int? requiredDataProviderID = null);
}
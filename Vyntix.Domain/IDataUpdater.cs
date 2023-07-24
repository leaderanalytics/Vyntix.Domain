namespace LeaderAnalytics.Vyntix.Domain;

public interface IDataUpdater
{
    /// <summary>
    /// Updates Observations and Vintages from a DataProvider API
    /// </summary>
    /// <param name="series">Series to update</param>
    /// <returns></returns>
    Task Update(IEnumerable<Series> series);
}

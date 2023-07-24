namespace LeaderAnalytics.Vyntix.Domain.Components;

public interface ICategorySelector : IInitialization
{
    List<Category> GetSelectedCategories();
    bool? ShowDialog();
    bool? ShowDialog(bool allowMultipleSelections, List<Category> initalSelections);
}
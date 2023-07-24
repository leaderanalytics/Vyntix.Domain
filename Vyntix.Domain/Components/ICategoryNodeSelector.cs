namespace LeaderAnalytics.Vyntix.Domain.Components;

public interface ICategoryNodeSelector : IInitialization
{
    List<Node> GetSelectedCategoryNodes();
    bool? ShowDialog();
    bool? ShowDialog(bool allowMultipleSelections, List<Node> initalSelections, bool showFreeCategories = true);
}
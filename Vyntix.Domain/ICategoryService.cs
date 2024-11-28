namespace LeaderAnalytics.Vyntix.Domain;

public interface ICategoryService : IDisposable
{
    Task<AsyncResult> ValidateCategory(Category category);
    Task ImportCategories(IEnumerable<Category> categories, IDownloadJobStatistics jobStatistics);
    Task<Category> GetCategoryByNativeID(string nativeID, int dataProviderID);
    Task<Model.RowOpResult> SaveCategory(Category category, bool saveChanges = true);
    Task DeleteCategoriesForDataProvider(int dataProviderID, bool saveChanges = true);
    Task<List<Category>> GetCategoriesForDataProvider(int dataProviderID);
    Task<List<Category>> SearchCategories(string categoryName, int[] dataProviders);
    Task<Model.RowOpResult> SaveCategoryAndNode(Node node);
    Task<Model.RowOpResult> DeleteCategoryAndNodes(string nativeID, int dataProviderID);
}



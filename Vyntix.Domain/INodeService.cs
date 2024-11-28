namespace LeaderAnalytics.Vyntix.Domain;

public interface INodeService
{
    Task<List<Node>> GetChildNodes(string nativeID, int? dataProviderID, int[] dataProviders);
    Task<List<Node>> GetNodesForEntity(string nativeID, int dataProviderID, NodeEntityType entityType, int[] dataProviders);
    Task<Node> GetNodeByNativeID(string nativeID, int dataProviderID);
    Task<AsyncResult> ValidateNode(Node node);
    Task<Model.RowOpResult> SaveNode(Node node, bool saveChanges = true);
    Task DeleteNodesForDataProvider(int dataProviderID, bool saveChanges = true);
    Task<Model.RowOpResult> ReplaceNodesForParent(string parentNativeID, int parentDataProviderID, int dataProviderID, NodeEntityType entityType, bool isRelatedToParent, List<Node> nodes);
    Task<Model.RowOpResult> ReplaceNodesForEntity(string entityNativeID, int entityDataProviderID, NodeEntityType entityType, bool isRelatedToParent, List<Node> nodes);
    Task ImportNodes(IEnumerable<Node> nodes);
    Task<Model.RowOpResult> DeleteNode(Node node, bool saveChanges = true);
    Task<List<CategoryPath>> GetCategoryPathsForSeries(string nativeId, int dataProviderID);
    Task<List<CategoryPath>> GetCategoryPathsForSeries(List<Node> nodes);
    Task<List<Node>> SearchCategoryNodes(string categoryName, int[] dataProviders, bool showFreeCategories = true);
    Task<List<Node>> PopulateParentNode(IEnumerable<Node> nodes);
    Task<Model.RowOpResult> DeleteNodesForEntity(string entityNativeID, int dataProviderID, NodeEntityType entityType, bool saveChanges = true);
    Task<List<Node>> GetFreeCategories(string categoryName, int[] dataProviders);
}

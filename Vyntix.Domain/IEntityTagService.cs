namespace LeaderAnalytics.Vyntix.Domain;

public interface IEntityTagService
{
    Task<bool> DoesEntityTagExist(EntityTag tag);
    Task<List<EntityTag>> GetEntityTags(string entityNativeID, int entityDataProviderID, TaggableType taggableType, int[] associationDataProviderIDs);
    Task ImportEntityTags(List<EntityTag> tags, IDownloadJobStatistics jobStatistics);
    Task PopulateEntityTagCache(int dataProviderID);
    Task<Model.RowOpResult> SaveEntityTag(EntityTag tag, bool saveChanges = true);
    Task<AsyncResult> ValidateEntityTag(EntityTag tag);
    Task ReplaceEntityTags(string entityNativeID, int entityDataProviderID, TaggableType taggableType, int associationDataProviderID, List<Tag> tags);
    Task<Model.RowOpResult> DeleteEntityTag(EntityTag tag, bool saveChanges = true);
}

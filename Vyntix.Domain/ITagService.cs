namespace LeaderAnalytics.Vyntix.Domain;

public interface ITagService
{
    Task<List<Tag>> GetAllTagsForDataProvider(int dataProviderID);
    Task ImportTags(List<Tag> tags, IDownloadJobStatistics jobStatistics);
    Task<Tag> GetTagByNativeID(string nativeID, int dataProviderID);
    Task<ValidationResult<Tag>> ValidateTag(Tag tag);
    Task<Model.RowOpResult<Tag>> SaveTag(Tag tag, bool saveChanges = true);
    Task<List<Tag>> SearchTags(string searchTerm, string groupNativeID, int groupDataProviderID, int[] dataProviders);
    Task<Model.RowOpResult> DeleteTag(Tag tag, bool saveChanges);
    Task<List<Tag>> GetTagsForTagGroup(TagGroup tagGroup);
}

namespace LeaderAnalytics.Vyntix.Domain;

public interface ITagGroupsService
{
    Task<TagGroup> GetTagGroup(string nativeID, int dataProviderID);
    Task<RowOpResult<TagGroup>> SaveTagGroup(TagGroup tagGroup, bool saveChanges = true);
    Task<ValidationResult<TagGroup>> ValidateTagGroup(TagGroup tagGroup);
    Task<RowOpResult> CreateFREDTagGroups();
    Task<List<TagGroup>> GetTagGroups();
    Task<RowOpResult> DeleteTagGroup(TagGroup tagGroup);
}

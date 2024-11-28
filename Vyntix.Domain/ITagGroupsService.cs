namespace LeaderAnalytics.Vyntix.Domain;

public interface ITagGroupsService
{
    Task<TagGroup> GetTagGroup(string nativeID, int dataProviderID);
    Task<Model.RowOpResult<TagGroup>> SaveTagGroup(TagGroup tagGroup, bool saveChanges = true);
    Task<ValidationResult<TagGroup>> ValidateTagGroup(TagGroup tagGroup);
    Task<Model.RowOpResult> CreateFREDTagGroups();
    Task<List<TagGroup>> GetTagGroups();
    Task<Model.RowOpResult> DeleteTagGroup(TagGroup tagGroup);
}

namespace LeaderAnalytics.Vyntix.Domain;

public interface IUserGroupsService
{
    Task<Dictionary<int, int[]>> GetUserUserGroupsMap();
    Task<List<UserGroup>> GetAllUserGroups();
    Task<Model.RowOpResult<UserGroup>> SaveUserGroup(UserGroup userGroup);
    Task<List<UserGroup>> SearchUserGroups(string name);
    Task<Model.RowOpResult> DeleteUserGroup(UserGroup userGroup);
}

namespace LeaderAnalytics.Vyntix.Domain;

public interface IUserGroupsService
{
    Task<Dictionary<int, int[]>> GetUserUserGroupsMap();
    Task<List<UserGroup>> GetAllUserGroups();
    Task<RowOpResult<UserGroup>> SaveUserGroup(UserGroup userGroup);
    Task<List<UserGroup>> SearchUserGroups(string name);
    Task<RowOpResult> DeleteUserGroup(UserGroup userGroup);
}

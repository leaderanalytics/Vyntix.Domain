namespace LeaderAnalytics.Vyntix.Domain;

public interface IRolesService : IDisposable
{
    Task<List<AppRole>> GetAllAppRoles();
    Task<RowOpResult<AppRole>> SaveAppRole(AppRole appRole);
    Task DeleteAppRole(int appRoleID);
    Task SaveAppRolePermissions(List<AppRolePermission> permissions);

    Task<List<DataRole>> GetAllDataRoles();
    Task<List<DataRole>> GetCurrentDataRoles();
    Task<RowOpResult<DataRole>> SaveDataRole(DataRole appRole);
    Task DeleteDataRole(int dataRoleID);
    Task SaveDataRolePermissions(List<DataRolePermission> permissions);
    Task<List<UserDataRole>> GetAvailableUserDataRoles();
}

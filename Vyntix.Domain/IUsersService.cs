using System.ServiceModel;
namespace LeaderAnalytics.Vyntix.Domain;

public interface IUsersService : IDisposable
{
    [OperationContract]
    Task<User> GetUserByNameAsync(string name, string password);

    [OperationContract]
    Task<User> GetDefaultUserAsync();

    [OperationContract]
    Task<IEnumerable<User>> GetActiveUsersAsync();

    [OperationContract]
    Task<List<User>> GetUsers(int? id, bool activeOnly);

    [OperationContract]
    Task<RowOpResult<User>> SaveUser(IUser user);

    [OperationContract]
    Task<AsyncResult> DeleteUserAsync(int userID);

    [OperationContract]
    Task<List<User>> SearchUsers(string name, bool activeOnly);

    [OperationContract]
    Task<User> GetUserByID(int id);

    [OperationContract]
    Task<User> GetUserGraph(int id);

    [OperationContract]
    Task SaveAndReplaceUserDataRoles(User user,int? dataProviderID, bool saveChanges = false);

    Task<User> GetAdminUser();
    RowOpResult<IUser> LoadUserSettings(IUser user);
    Task<RowOpResult<IUser>> SaveUserSettings(IUser user);
    Task<string> GetDatabaseVersion();

}

namespace LeaderAnalytics.Vyntix.Domain.Components;

public interface IStateManager
{
    event Action<object, AppProcess> ExecuteProcess;
    void OnExecuteProcess(object sender, AppProcess process);
    Task LoadUser(IUser user);
    string AppVersion { get; }
    string DbVersion { get; set; }
    string PrimaryEndPoint { get; set; }
    IUser User { get;  }
    bool HasDataPermission(int dataProviderID, DataPermission dataPermission);
    bool HasAppPermission(int userID, AppPermission appPermission);
    int[] AuthorizedDataProviders(DataPermission dataPermission);
    int[] AuthorizedDataProviders(DataPermission dataPermission, IEnumerable<int> selectedDataProviders);
    int[] SessionAuthorizedDataProviders(DataPermission dataPermission);
    bool AreAllDataProvidersAuthorized(DataPermission dataPermission, IEnumerable<int> selectedDataProviders);
    int[] UnAuthorizedDataProviders(DataPermission dataPermission, IEnumerable<int> selectedDataProviders);
}

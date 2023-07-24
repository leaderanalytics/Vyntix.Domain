namespace LeaderAnalytics.Vyntix.Domain;

public interface IModelRefService : IDisposable
{
    Task<ModelReference> GetModelReferenceByID(int id);
    Task<List<ModelReference>> GetModelReferencesForUser(int userID);
    Task<RowOpResult<ModelReference>> SaveModelReference(ModelReference modelRef);
    Task<RowOpResult> DeleteModelRef(int modelRefID);
    Task<List<ModelReference>> SearchModelReferences(string name);
}

namespace LeaderAnalytics.Vyntix.Domain;

public interface IModelRefService : IDisposable
{
    Task<ModelReference> GetModelReferenceByID(int id);
    Task<List<ModelReference>> GetModelReferencesForUser(int userID);
    Task<Model.RowOpResult<ModelReference>> SaveModelReference(ModelReference modelRef);
    Task<Model.RowOpResult> DeleteModelRef(int modelRefID);
    Task<List<ModelReference>> SearchModelReferences(string name);
}

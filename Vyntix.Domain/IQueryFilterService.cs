namespace LeaderAnalytics.Vyntix.Domain;

public interface IQueryFilterService
{
    Task<AsyncResult<QueryFilter>> GetQueryFilterByID(int id);
    Task<List<QueryFilter>> SearchQueryFilters(string name);
    Task<Model.RowOpResult<QueryFilter>> SaveQueryFilter(QueryFilter filter);
    Task<Model.RowOpResult> DeleteQueryFilter(int id);
    Task<List<EntityQueryFilterProjection>> GetEntityQueryFilterProjections(int queryFilterID);
    Task<Model.RowOpResult> DeleteEntityQueryFilter(EntityQueryFilter queryFilter);
    Task<List<EntityQueryFilter>> GetEntityQueryFiltersForDataSet(int dataSetID);
    Task<Model.RowOpResult> ReplaceEntityQueryFilters(int entityID, QueryFilterEntityType entityType, IEnumerable<EntityQueryFilter> queryFilters);
}

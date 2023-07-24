namespace LeaderAnalytics.Vyntix.Domain;

public interface IQueryFilterService
{
    Task<AsyncResult<QueryFilter>> GetQueryFilterByID(int id);
    Task<List<QueryFilter>> SearchQueryFilters(string name);
    Task<RowOpResult<QueryFilter>> SaveQueryFilter(QueryFilter filter);
    Task<RowOpResult> DeleteQueryFilter(int id);
    Task<List<EntityQueryFilterProjection>> GetEntityQueryFilterProjections(int queryFilterID);
    Task<RowOpResult> DeleteEntityQueryFilter(EntityQueryFilter queryFilter);
    Task<List<EntityQueryFilter>> GetEntityQueryFiltersForDataSet(int dataSetID);
    Task<RowOpResult> ReplaceEntityQueryFilters(int entityID, QueryFilterEntityType entityType, IEnumerable<EntityQueryFilter> queryFilters);
}

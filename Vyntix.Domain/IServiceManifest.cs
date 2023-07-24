namespace LeaderAnalytics.Vyntix.Domain;

public interface IServiceManifest : IDisposable
{
    IAlignmentService AlignmentService { get; }
    ICategoryService CategoryService { get; }
    IDataProviderService DataProviderService { get; }
    IDataSetSeriesService DataSetSeriesService { get; }
    IDataSetService DataSetService { get; }
    IEntityTagService EntityTagService { get; }
    IFredDownloader FredDownloadService { get; }
    IModelRefService ModelRefService { get; }
    INativeFrequencyService NativeFrequencyService { get; }
    IObservationsService ObservationsService { get; }
    INodeService NodeService { get; }
    IQueryFilterService QueryFilterService { get; }
    IReleasesService ReleasesService { get; }
    IReportingFrequenciesService ReportingFrequenciesService { get; }
    IRolesService RolesService { get; }
    ISeriesService SeriesService { get; }
    ISourceReleasesService SourceReleasesService { get; }
    ISourcesService SourcesService { get; }
    IUpdateService UpdateService { get; }
    IUsersService UsersService { get; }
    IUserGroupsService UserGroupsService { get; }
    IVintageComposer VintageComposer { get; }
    IVintagesService VintagesService { get; }
    IWatchListService WatchListService { get; }
    ITagService TagsService { get; }
    ITagGroupsService TagGroupsService { get; }
}
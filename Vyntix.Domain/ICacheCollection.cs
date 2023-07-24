namespace LeaderAnalytics.Vyntix.Domain;

public interface ICacheCollection
{
    bool IsCachingEnabled { get; set; }
    Cache<Category> CategoryCache { get; }
    Cache<byte> CategoryTagCache { get; set; }
    Cache<DataProvider> DataProviderCache { get; }
    Cache<NativeFrequency> NativeFrequenciesCache { get; }
    /// <summary>
    /// key:UserID.  Returns ID's of DataProviders the user can read.
    /// </summary>
    Cache<Release> ReleaseCache { get; }
    Cache<Series> SeriesCache { get; }
    Cache<byte> SeriesTagCache { get; set; }
    Cache<Source> SourceCache { get; }
    Cache<Tag> TagCache { get; }
    Cache<TagGroup> TagGroupCache { get; }

    void PurgeAll();
}

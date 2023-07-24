namespace LeaderAnalytics.Vyntix.Domain;

public interface INativeFrequencyService : IDisposable
{
    Task<List<NativeFrequency>> GetNativeFrequenciesAsync(int[] dataProviderIDs);
    Task<NativeFrequency> GetNativeFrequencyByNativeID(string nativeID, int dataProviderID);
    Task<NativeFrequency> GetOrCreateNativeFrequencyByNameAsync(string frequency, int dataProviderID);
    Task<NativeFrequency> CreateNativeFrequencyAsync(string frequency, int dataProviderID);
    Task<RowOpResult> SaveNativeFrequencyAsync(NativeFrequency frequency);
    Task<AsyncResult> DeleteNativeFrequencyAsync(string nativeID, int dataProviderID);
    void deleteNativeFrequenciesForDataProvider(int dataProviderID);
    void createDefaultNativeFrequenciesForDataProvider(DataProvider dp);
}

using Application.Contracts.Caching;

namespace Infrastructure.Caching
{
    public class CachingService<T> : ICachingService<T> where T : class
    {
        private Dictionary<string, List<T>> CachingData = new();

        public void AddToKey(string cacheKey, T value)
        {
            CachingData.GetValueOrDefault(cacheKey).Add(value);
        }
        public void Set(string cacheKey, T value)
        {
            CachingData.TryAdd(cacheKey, [value]);
        }
        public bool IsCached(string cacheKey)
        {
            return CachingData.ContainsKey(cacheKey);
        }
        public List<T> GetCacheKey(string cacheKey) 
        {
            return CachingData[cacheKey];
        }
        public void Delete(string cacheKey)
        {
            throw new NotImplementedException();
        }

        public void Delete(string cacheKey, T value)
        {
            throw new NotImplementedException();
        }               

        
    }
}
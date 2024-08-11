using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Caching
{
    public interface ICachingService<T> where T : class
    {
        List<T> GetCacheKey(string cacheKey);
        bool IsCached(string cacheKey);
        void Set(string cacheKey, T value);
        void Delete(string cacheKey);
        void Delete(string cacheKey, T value);
        void AddToKey(string cacheKey, T value);
    }
}

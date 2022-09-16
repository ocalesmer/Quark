using AvvaMobile.Core.Caching;

namespace Core.Caching
{
    /// <summary>
    /// Always use "Quark.Core.Caching.AppSettingsKeys" instead of "AvvaMobile.Core.Caching.AppSettingsKeys". Because Quark.Core.Caching.AppSettingsKeys extends AvvaMobile.Core.Caching.AppSettingsKeys class. (Murat Yılmaz)
    /// </summary>
    public class AppSettingsKeys : AvvaMobile.Core.Caching.AppSettingsKeys
    {
        private readonly ICacheManager _cacheManager;

        public AppSettingsKeys(ICacheManager cacheManager) : base(cacheManager)
        {
            _cacheManager = cacheManager;
        }

        //public string Sample_CacheKey { get { return _cacheManager.Get("Sample_CacheKey"); } }
    }
}
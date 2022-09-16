using Core.Caching;
using Core.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Persistence.Contexts;
using System.Security.Claims;

namespace Application.Base
{
    public class BaseHandler
    {
        protected IHttpContextAccessor _httpContext;
        protected BaseDbContext _context;
        protected IStringLocalizer<CommonResource> _localizer;
        protected AppSettingsKeys _appSettingsKeys;
        public BaseHandler(IHttpContextAccessor httpContext, BaseDbContext context, IStringLocalizer<CommonResource> localizer, AppSettingsKeys appSettingsKeys)
        {
            _httpContext = httpContext;
            _context = context;
            _localizer = localizer;
            _appSettingsKeys = appSettingsKeys;
        }

        public int CurrentUserID
        {
            get
            {
                return int.Parse(_httpContext.HttpContext.User.Identities.FirstOrDefault(u => u.IsAuthenticated && u.HasClaim(c => c.Type == ClaimTypes.NameIdentifier))?.FindFirst(ClaimTypes.NameIdentifier).Value);
            }
        }
        public int GetCurrentLanguageID(IStringLocalizer<CommonResource> localizer)
        {
            return int.Parse(localizer["Current_Language_ID"]);
        }
        public string CurrentUserName
        {
            get
            {
                return _httpContext.HttpContext.User.Identities.FirstOrDefault(u => u.IsAuthenticated && u.HasClaim(c => c.Type == ClaimTypes.Name))?.FindFirst(ClaimTypes.Name).Value;
            }
        }
    }
}

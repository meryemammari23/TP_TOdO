using Microsoft.AspNetCore.Http;

namespace TP_TODO.Services
{
    public class CookieManagerService : ICookieManagerService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CookieManagerService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string? Get(string key)
        {
            return _httpContextAccessor.HttpContext?.Request.Cookies[key];
        }

        public void Set(string key, string value)
        {
            _httpContextAccessor.HttpContext?.Response.Cookies.Append(key, value);
        }
    }
}

using Microsoft.AspNetCore.Http;

namespace TP_TODO.Services
{
    public class SessionManagerService : ISessionManagerService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SessionManagerService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string? Get(string key)
        {
            return _httpContextAccessor.HttpContext?.Session.GetString(key);
        }

        public void Set(string key, string value)
        {
            _httpContextAccessor.HttpContext?.Session.SetString(key, value);
        }
    }
}

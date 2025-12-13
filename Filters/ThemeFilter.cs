using Microsoft.AspNetCore.Mvc.Filters;
using TP_TODO_V1.Services;

namespace TP_TODO_V1.Filters
{
    public class ThemeFilter : IActionFilter
    {
        private readonly ICookieManagerService _cookie;

        public ThemeFilter(ICookieManagerService cookie)
        {
            _cookie = cookie;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var theme = _cookie.Get("theme") ?? "light";
            context.HttpContext.Items["theme"] = theme;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TP_TODO_V1.Services;

namespace TP_TODO_V1.Controllers
{
    public class ViewConfigController : Controller
    {
        private readonly ICookieManagerService _cookieService;

        public ViewConfigController(ICookieManagerService cookieService)
        {
            _cookieService = cookieService;
        }

        public IActionResult SetTheme(string theme)
        {
            _cookieService.Set("theme", theme);
            return RedirectToAction("Index", "Todo");
        }
    }
}

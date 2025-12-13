using Microsoft.AspNetCore.Mvc;
using TP_TODO_V1.Services;

namespace TP_TODO_V1.Controllers
{
    public class UsersController : Controller
    {
        private readonly ISessionManagerService _session;

        public UsersController(ISessionManagerService session)
        {
            _session = session;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username)
        {
            _session.Set("user", username);
            return RedirectToAction("Index", "Todo");
        }
    }
}

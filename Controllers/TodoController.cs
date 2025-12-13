using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TP_TODO.Models;
using TP_TODO.Services;

namespace TP_TODO.Controllers
{
    public class TodoController : Controller
    {
        private readonly ISessionManagerService _sessionService;
        private const string SESSION_KEY = "TODOS";

        public TodoController(ISessionManagerService sessionService)
        {
            _sessionService = sessionService;
        }

        public IActionResult Index()
        {
            var json = _sessionService.Get(SESSION_KEY);

            List<Todo> todos = json == null
                ? new List<Todo>()
                : JsonSerializer.Deserialize<List<Todo>>(json)!;

            return View(todos);
        }
    }
}

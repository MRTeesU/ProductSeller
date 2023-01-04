using Microsoft.AspNetCore.Mvc;

namespace DatabaseHandler.Controllers
{
    public class DatabaseHandlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

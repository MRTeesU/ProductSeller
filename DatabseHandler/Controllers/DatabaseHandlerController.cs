using Microsoft.AspNetCore.Mvc;

namespace DatabaseHandler.Controllers
{
    public class DatabaseHandlerController : Controller
    {
        
        public Dbset<Product> ViewDatabase()
        {
            return View();
        }
    }
}

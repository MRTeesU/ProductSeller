using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        public int IncreaseStock()
        {
            return 0;
        }
        public int ReduceStock()
        {
            return 0;
        }

    }
}

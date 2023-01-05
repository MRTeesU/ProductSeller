using Microsoft.AspNetCore.Mvc;

//namespace DatabaseHandler.Models.Product;
namespace DatabaseHandler.Controllers
{
    public class DatabaseHandlerController : Controller
    {
        private HttpClient Client { get; }

        record ProductDto(int ID,string name, string description, int price, bool InStock);

        public DatabaseHandlerController(HttpClient client , IConfiguration configuration)
        {
            var baseUrl = configuration["WebServices:Comments:BaseURL"];
            client.BaseAddress = new System.Uri(baseUrl);
            client.Timeout = TimeSpan.FromSeconds(5);
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            Client = client;
        }

        public void ViewDatabase()
        {
            View();
        }
        public void UpdateDatabase()
        {
            View();
        }
    }
}

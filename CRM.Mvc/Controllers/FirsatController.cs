using Microsoft.AspNetCore.Mvc;
using CRM.Entities;

namespace CRM.Mvc.Controllers
{
    public class FirsatController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FirsatController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");
            var response = await client.GetAsync("api/Firsat");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var firsatlar = System.Text.Json.JsonSerializer.Deserialize<List<Firsat>>(jsonData, new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(firsatlar);
            }

            return View(new List<Firsat>());
        }
    }
}
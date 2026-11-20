using Microsoft.AspNetCore.Mvc;
using CRM.Entities;

namespace CRM.Mvc.Controllers
{
    public class SatisController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SatisController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");
            var response = await client.GetAsync("api/Satis");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var satislar = System.Text.Json.JsonSerializer.Deserialize<List<Satis>>(jsonData, new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(satislar);
            }

            return View(new List<Satis>());
        }
    }
}
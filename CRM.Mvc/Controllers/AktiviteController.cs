using Microsoft.AspNetCore.Mvc;
using CRM.Entities;

namespace CRM.Mvc.Controllers
{
    public class AktiviteController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AktiviteController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");
            var response = await client.GetAsync("api/Aktivite");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var aktiviteler = System.Text.Json.JsonSerializer.Deserialize<List<Aktivite>>(jsonData, new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(aktiviteler);
            }

            return View(new List<Aktivite>());
        }
    }
}
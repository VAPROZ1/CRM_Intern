using Microsoft.AspNetCore.Mvc;
using CRM.Entities;

namespace CRM.Mvc.Controllers
{
    public class DestekTalebiController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DestekTalebiController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");
            var response = await client.GetAsync("api/DestekTalebi");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var destekTalepleri = System.Text.Json.JsonSerializer.Deserialize<List<DestekTalebi>>(jsonData, new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(destekTalepleri);
            }

            return View(new List<DestekTalebi>());
        }
    }
}
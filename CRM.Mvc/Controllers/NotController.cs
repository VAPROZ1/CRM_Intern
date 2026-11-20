using Microsoft.AspNetCore.Mvc;
using CRM.Entities;

namespace CRM.Mvc.Controllers
{
    public class NotController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public NotController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");
            var response = await client.GetAsync("api/Not");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var notlar = System.Text.Json.JsonSerializer.Deserialize<List<Not>>(jsonData, new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(notlar);
            }

            return View(new List<Not>());
        }
    }
}
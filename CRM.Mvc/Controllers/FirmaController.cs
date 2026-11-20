using Microsoft.AspNetCore.Mvc;
using CRM.Entities;

namespace CRM.Mvc.Controllers
{
    public class FirmaController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FirmaController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");
            var response = await client.GetAsync("api/Firma");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var firmalar = System.Text.Json.JsonSerializer.Deserialize<List<Firma>>(jsonData, new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(firmalar);
            }

            return View(new List<Firma>());
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using CRM.Entities;

namespace CRM.Mvc.Controllers
{
    public class KategoriController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public KategoriController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");
            var response = await client.GetAsync("api/Kategori");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var kategoriler = System.Text.Json.JsonSerializer.Deserialize<List<Kategori>>(jsonData, new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(kategoriler);
            }

            return View(new List<Kategori>());
        }
    }
}
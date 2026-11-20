using Microsoft.AspNetCore.Mvc;
using CRM.Entities;
using System.Text.Json;

namespace CRM.Mvc.Controllers
{
    public class KullaniciController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public KullaniciController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");
            var response = await client.GetAsync("api/Kullanici"); // API'deki kullanıcı endpoint'i

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var kullanicilar = JsonSerializer.Deserialize<List<Kullanici>>(jsonData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(kullanicilar);
            }

            return View(new List<Kullanici>());
        }
    }
}
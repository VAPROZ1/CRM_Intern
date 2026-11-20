using Microsoft.AspNetCore.Mvc;
using CRM.Entities;
using System.Text.Json;

namespace CRM.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");

            // Örnek olarak temel istatistikleri API'den çekiyoruz
            int musteriCount = 0;
            int firmaCount = 0;
            int urunCount = 0;
            int firsatCount = 0;

            try
            {
                var resMusteri = await client.GetAsync("api/Musteri");
                if (resMusteri.IsSuccessStatusCode)
                {
                    var data = await resMusteri.Content.ReadAsStringAsync();
                    var list = JsonSerializer.Deserialize<List<Musteri>>(data, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    if (list != null) musteriCount = list.Count;
                }

                var resFirma = await client.GetAsync("api/Firma");
                if (resFirma.IsSuccessStatusCode)
                {
                    var data = await resFirma.Content.ReadAsStringAsync();
                    var list = JsonSerializer.Deserialize<List<Firma>>(data, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    if (list != null) firmaCount = list.Count;
                }

                var resUrun = await client.GetAsync("api/Urun");
                if (resUrun.IsSuccessStatusCode)
                {
                    var data = await resUrun.Content.ReadAsStringAsync();
                    var list = JsonSerializer.Deserialize<List<Urun>>(data, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    if (list != null) urunCount = list.Count;
                }

                var resFirsat = await client.GetAsync("api/Firsat");
                if (resFirsat.IsSuccessStatusCode)
                {
                    var data = await resFirsat.Content.ReadAsStringAsync();
                    var list = JsonSerializer.Deserialize<List<Firsat>>(data, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    if (list != null) firsatCount = list.Count;
                }
            }
            catch (Exception)
            {
                // API kapalıysa veya hata alırssa 0 döner
            }

            ViewBag.MusteriCount = musteriCount;
            ViewBag.FirmaCount = firmaCount;
            ViewBag.UrunCount = urunCount;
            ViewBag.FirsatCount = firsatCount;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
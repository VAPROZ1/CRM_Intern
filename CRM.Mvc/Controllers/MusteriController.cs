using Microsoft.AspNetCore.Mvc;
using CRM.Entities;
using System.Text.Json;
using System.Text;

namespace CRM.Mvc.Controllers
{
    public class MusteriController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MusteriController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");
            var response = await client.GetAsync("api/Musteri"); // Yönergedeki GET endpoint'i

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var musteriler = JsonSerializer.Deserialize<List<Musteri>>(jsonData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(musteriler);
            }

            return View(new List<Musteri>());
        }

        // GET: Musteri/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Musteri/Create
        [HttpPost]
        public async Task<IActionResult> Create(Musteri musteri)
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");
            var content = new StringContent(JsonSerializer.Serialize(musteri), Encoding.UTF8, "application/json");

            var response = await client.PostAsync("api/Musteri", content); // Yönergedeki POST endpoint'i
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View(musteri);
        }
        // GET: Musteri/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");
            var response = await client.GetAsync($"api/Musteri/{id}");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var musteri = JsonSerializer.Deserialize<Musteri>(jsonData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(musteri);
            }

            return RedirectToAction("Index");
        }

        // POST: Musteri/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(Musteri musteri)
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");
            var content = new StringContent(JsonSerializer.Serialize(musteri), Encoding.UTF8, "application/json");

            var response = await client.PutAsync($"api/Musteri/{musteri.MusteriId}", content); // Yönergedeki PUT endpoint standardı
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View(musteri);
        }
        // GET: Musteri/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");
            var response = await client.GetAsync($"api/Musteri/{id}");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var musteri = JsonSerializer.Deserialize<Musteri>(jsonData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(musteri);
            }

            return RedirectToAction("Index");
        }

        // POST: Musteri/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var client = _httpClientFactory.CreateClient("CrmApiClient");
            var response = await client.DeleteAsync($"api/Musteri/{id}"); // Yönergedeki DELETE endpoint standardı

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
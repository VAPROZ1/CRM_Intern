using CRM.Business.Abstract;
using CRM.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusteriController : ControllerBase
    {
        private readonly IMusteriService _musteriService;

        // Dependency Injection: Garson, aşçıyı (servisi) buraya çağırıyor
        public MusteriController(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }

        // GET: api/musteri (Tüm müşterileri listele)
        [HttpGet]
        public IActionResult GetAll()
        {
            var musteriler = _musteriService.GetAll();
            return Ok(musteriler);
        }

        // GET: api/musteri/5 (ID'ye göre tek müşteri getir)
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var musteri = _musteriService.GetById(id);
            if (musteri == null)
            {
                return NotFound("Müşteri bulunamadı!");
            }
            return Ok(musteri);
        }

        // POST: api/musteri (Yeni müşteri ekle)
        [HttpPost]
        public IActionResult Add([FromBody] Musteri musteri)
        {
            _musteriService.Add(musteri);
            return Ok("Müşteri başarıyla eklendi.");
        }

        // PUT: api/musteri (Müşteri güncelle)
        [HttpPut]
        public IActionResult Update([FromBody] Musteri musteri)
        {
            _musteriService.Update(musteri);
            return Ok("Müşteri başarıyla güncellendi.");
        }

        // DELETE: api/musteri/5 (Müşteri sil)
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _musteriService.Delete(id);
            return Ok("Müşteri silindi.");
        }
    }
}
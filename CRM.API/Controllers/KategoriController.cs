using CRM.Business.Abstract;
using CRM.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        private readonly IKategoriService _kategoriService;

        public KategoriController(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var kategoriler = _kategoriService.GetAll();
            return Ok(kategoriler);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var kategori = _kategoriService.GetById(id);
            if (kategori == null)
            {
                return NotFound("Kategori bulunamadı!");
            }
            return Ok(kategori);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Kategori kategori)
        {
            _kategoriService.Add(kategori);
            return Ok("Kategori başarıyla eklendi.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] Kategori kategori)
        {
            _kategoriService.Update(kategori);
            return Ok("Kategori başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _kategoriService.Delete(id);
            return Ok("Kategori silindi.");
        }
    }
}
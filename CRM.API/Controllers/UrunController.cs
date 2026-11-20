using CRM.Business.Abstract;
using CRM.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunController : ControllerBase
    {
        private readonly IUrunService _urunService;

        public UrunController(IUrunService urunService)
        {
            _urunService = urunService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var urunler = _urunService.GetAll();
            return Ok(urunler);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var urun = _urunService.GetById(id);
            if (urun == null)
            {
                return NotFound("Ürün bulunamadı!");
            }
            return Ok(urun);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Urun urun)
        {
            _urunService.Add(urun);
            return Ok("Ürün başarıyla eklendi.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] Urun urun)
        {
            _urunService.Update(urun);
            return Ok("Ürün başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _urunService.Delete(id);
            return Ok("Ürün silindi.");
        }
    }
}
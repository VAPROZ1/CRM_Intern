using CRM.Business.Abstract;
using CRM.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaController : ControllerBase
    {
        private readonly IFirmaService _firmaService;

        public FirmaController(IFirmaService firmaService)
        {
            _firmaService = firmaService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var firmalar = _firmaService.GetAll();
            return Ok(firmalar);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var firma = _firmaService.GetById(id);
            if (firma == null)
            {
                return NotFound("Firma bulunamadı!");
            }
            return Ok(firma);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Firma firma)
        {
            _firmaService.Add(firma);
            return Ok("Firma başarıyla eklendi.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] Firma firma)
        {
            _firmaService.Update(firma);
            return Ok("Firma başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _firmaService.Delete(id);
            return Ok("Firma silindi.");
        }
    }
}
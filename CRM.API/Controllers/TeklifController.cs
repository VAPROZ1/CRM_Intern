using CRM.Business.Abstract;
using CRM.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeklifController : ControllerBase
    {
        private readonly ITeklifService _teklifService;

        public TeklifController(ITeklifService teklifService)
        {
            _teklifService = teklifService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var teklifler = _teklifService.GetAll();
            return Ok(teklifler);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var teklif = _teklifService.GetById(id);
            if (teklif == null)
            {
                return NotFound("Teklif bulunamadı!");
            }
            return Ok(teklif);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Teklif teklif)
        {
            _teklifService.Add(teklif);
            return Ok("Teklif başarıyla eklendi.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] Teklif teklif)
        {
            _teklifService.Update(teklif);
            return Ok("Teklif başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _teklifService.Delete(id);
            return Ok("Teklif silindi.");
        }
    }
}
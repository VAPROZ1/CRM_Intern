using CRM.Business.Abstract;
using CRM.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeklifKalemiController : ControllerBase
    {
        private readonly ITeklifKalemiService _teklifKalemiService;

        public TeklifKalemiController(ITeklifKalemiService teklifKalemiService)
        {
            _teklifKalemiService = teklifKalemiService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var kalemler = _teklifKalemiService.GetAll();
            return Ok(kalemler);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var kalem = _teklifKalemiService.GetById(id);
            if (kalem == null)
            {
                return NotFound("Teklif kalemi bulunamadı!");
            }
            return Ok(kalem);
        }

        [HttpPost]
        public IActionResult Add([FromBody] TeklifKalemi teklifKalemi)
        {
            _teklifKalemiService.Add(teklifKalemi);
            return Ok("Teklif kalemi başarıyla eklendi.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] TeklifKalemi teklifKalemi)
        {
            _teklifKalemiService.Update(teklifKalemi);
            return Ok("Teklif kalemi başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _teklifKalemiService.Delete(id);
            return Ok("Teklif kalemi silindi.");
        }
    }
}
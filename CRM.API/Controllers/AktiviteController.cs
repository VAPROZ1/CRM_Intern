using CRM.Business.Abstract;
using CRM.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AktiviteController : ControllerBase
    {
        private readonly IAktiviteService _aktiviteService;

        public AktiviteController(IAktiviteService aktiviteService)
        {
            _aktiviteService = aktiviteService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var aktiviteler = _aktiviteService.GetAll();
            return Ok(aktiviteler);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aktivite = _aktiviteService.GetById(id);
            if (aktivite == null)
            {
                return NotFound("Aktivite bulunamadı!");
            }
            return Ok(aktivite);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Aktivite aktivite)
        {
            _aktiviteService.Add(aktivite);
            return Ok("Aktivite başarıyla eklendi.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] Aktivite aktivite)
        {
            _aktiviteService.Update(aktivite);
            return Ok("Aktivite başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _aktiviteService.Delete(id);
            return Ok("Aktivite silindi.");
        }
    }
}
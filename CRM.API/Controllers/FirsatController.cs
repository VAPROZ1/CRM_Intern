using CRM.Business.Abstract;
using CRM.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirsatController : ControllerBase
    {
        private readonly IFirsatService _firsatService;

        public FirsatController(IFirsatService firsatService)
        {
            _firsatService = firsatService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var firsatlar = _firsatService.GetAll();
            return Ok(firsatlar); // (Not: C# Türkçe karakter destekler ama değişken adlarına dikkat edelim)
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var firsat = _firsatService.GetById(id);
            if (firsat == null)
            {
                return NotFound("Fırsat bulunamadı!");
            }
            return Ok(firsat);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Firsat firsat)
        {
            _firsatService.Add(firsat);
            return Ok("Fırsat başarıyla eklendi.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] Firsat firsat)
        {
            _firsatService.Update(firsat);
            return Ok("Fırsat başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _firsatService.Delete(id);
            return Ok("Fırsat silindi.");
        }
    }
}
using CRM.Business.Abstract;
using CRM.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestekTalebiController : ControllerBase
    {
        private readonly IDestekTalebiService _destekTalebiService;

        public DestekTalebiController(IDestekTalebiService destekTalebiService)
        {
            _destekTalebiService = destekTalebiService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var talepler = _destekTalebiService.GetAll();
            return Ok(talepler);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var talep = _destekTalebiService.GetById(id);
            if (talep == null)
            {
                return NotFound("Destek talebi bulunamadı!");
            }
            return Ok(talep);
        }

        [HttpPost]
        public IActionResult Add([FromBody] DestekTalebi destekTalebi)
        {
            _destekTalebiService.Add(destekTalebi);
            return Ok("Destek talebi başarıyla eklendi.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] DestekTalebi destekTalebi)
        {
            _destekTalebiService.Update(destekTalebi);
            return Ok("Destek talebi başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _destekTalebiService.Delete(id);
            return Ok("Destek talebi silindi.");
        }
    }
}
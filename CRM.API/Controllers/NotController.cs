using CRM.Business.Abstract;
using CRM.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotController : ControllerBase
    {
        private readonly INotService _notService;

        public NotController(INotService notService)
        {
            _notService = notService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var notlar = _notService.GetAll();
            return Ok(notlar);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var notItem = _notService.GetById(id);
            if (notItem == null)
            {
                return NotFound("Not bulunamadı!");
            }
            return Ok(notItem);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Not not)
        {
            _notService.Add(not);
            return Ok("Not başarıyla eklendi.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] Not not)
        {
            _notService.Update(not);
            return Ok("Not başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _notService.Delete(id);
            return Ok("Not silindi.");
        }
    }
}
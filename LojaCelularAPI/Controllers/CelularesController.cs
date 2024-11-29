using LojaCelularAPI.Models;
using LojaCelularAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LojaCelularAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CelularesController : ControllerBase
    {
        private readonly CelularesService _celularesService;

        public CelularesController(CelularesService celularesService) =>
            _celularesService = celularesService;

        [HttpGet]
        public async Task<List<Celulares>> Get() =>
            await _celularesService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Celulares>> Get(string id)
        {
            var celular = await _celularesService.GetAsync(id);
            if (celular is null)
            {
                return NotFound();
            }
            return celular;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Celulares newCelular)
        {
            await _celularesService.CreateAsync(newCelular);
            return CreatedAtAction(nameof(Get), new { id = newCelular.Id }, newCelular);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Celulares updateCelular)
        {
            var celular = await _celularesService.GetAsync(id);
            if (celular is null)
            {
                return NotFound();
            }
            updateCelular.Id = celular.Id;
            await _celularesService.UpdateAsync(id, updateCelular);
            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var celular = await _celularesService.GetAsync(id);
            if (celular is null)
            {
                return NotFound();
            }
            await _celularesService.RemoveAsync(id);
            return NoContent();
        }
    }
}

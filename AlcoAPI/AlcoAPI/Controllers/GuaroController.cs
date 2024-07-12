using AlcoAPI.Models;
using AlcoAPI.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlcoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuaroController : ControllerBase
    {
        private readonly Context _context;

        public GuaroController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Guaro>>> GetGuaros()
        {
            var guaros = await _context.Guaro.Select(guaros => new Models.Guaro
            {
                GuaroId = guaros.GuaroId,
                Name = guaros.Name,
                Code = guaros.Code,
                Active = guaros.Active,
                Value = guaros.Value,
                Image = guaros.Image,
                CategoryId = guaros.CategoryId,
                TypeId = guaros.TypeId
            }).ToListAsync();

            return Ok(guaros);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Models.Guaro>>> GetGuaroById(int id)
        {
            var guaro = await _context.Guaro
                .Where(x => x.GuaroId == id)
                .Select(guaro => new Models.Guaro
                {
                    GuaroId = guaro.GuaroId,
                    Name = guaro.Name,
                    Code = guaro.Code,
                    Active = guaro.Active,
                    Value = guaro.Value,
                    Image = guaro.Image,
                    CategoryId = guaro.CategoryId,
                    TypeId = guaro.TypeId
                }).ToListAsync();

            return Ok(guaro);
        }

        [HttpPost]
        public async Task<ActionResult<Models.Guaro>> CreateGuaro(Models.Guaro guaro)
        {
            var guaroEntity = new Models.Entities.Guaro
            {
                Name = guaro.Name,
                Code = guaro.Code,
                Active = guaro.Active,
                Value = guaro.Value,
                Image = guaro.Image,
                CategoryId = guaro.CategoryId,
                TypeId = guaro.TypeId
            };

            _context.Guaro.Add(guaroEntity);
            _context.SaveChanges();

            var response = new Models.Guaro
            {
                GuaroId = guaroEntity.GuaroId,
                Name = guaroEntity.Name,
                Code = guaroEntity.Code,
                Active = guaroEntity.Active,
                Value = guaroEntity.Value,
                CategoryId = guaroEntity.CategoryId,
                TypeId = guaroEntity.TypeId
            };

            return CreatedAtAction(nameof(GetGuaroById), new { id = guaroEntity.GuaroId }, response);
        }
    }
}

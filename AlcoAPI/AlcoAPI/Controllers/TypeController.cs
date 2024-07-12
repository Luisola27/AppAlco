using AlcoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlcoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TypeController : ControllerBase
    {
        private readonly Context _context;

        public TypeController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Type>>> GetTypes() 
        {
            var types = await _context.Type
                .Select(type => new Models.Type
                {
                    TypeId = type.TypeId,
                    Name = type.Name
                })
                .ToListAsync();

            return Ok(types);
        }
    }
}

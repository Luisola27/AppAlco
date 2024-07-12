using AlcoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlcoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryTypeController : ControllerBase
    {
        private readonly Context _context;

        public CategoryTypeController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryType>>> GeTypeByCategory(int idCategory) 
        {
            var categoryTypes = await _context.CategoryType
                .Where(category => category.CategoryId == idCategory)
                .Select(categoryType => new
                {
                    categoryType.TypeId
                })
                .ToListAsync();

            var typeIds = categoryTypes.Select(ct => ct.TypeId).ToList();

            var types = await _context.Type
                .Where(t => typeIds.Contains(t.TypeId))
                .Select(t => new
                {
                    typeId = t.TypeId,
                    t.Name
                })
                .ToListAsync();

            return Ok(types);
        }
    }
}

using AlcoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlcoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly Context _context;

        public InvoiceController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Invoice>>> GetInvoices()
        {
            var invoices = await _context.Invoice
                .Select(invoice => new Invoice
                {
                    InvoiceId = invoice.InvoiceId,
                    ClientId = invoice.ClientId,
                    Products = invoice.Products,
                    Total = invoice.Total,
                    DateCreation = invoice.DateCreation,

                }).ToListAsync();

            return Ok(invoices);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Models.Invoice>>> GetInvoiceById(int id)
        {
            var invoice = await _context.Invoice
                .Where(x => x.InvoiceId == id)
                .Select(invoice => new Invoice
                {
                    InvoiceId = invoice.InvoiceId,
                    ClientId = invoice.ClientId,
                    Products = invoice.Products,
                    Total = invoice.Total,
                    DateCreation = invoice.DateCreation
                }).ToListAsync();

            return Ok(invoice);
        }


    }
}

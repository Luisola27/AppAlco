using AlcoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly Context _context;

        public ClientController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            var clients = await _context.Client
                .Select(client => new Client 
                {
                    ClientId = client.ClientId,
                    Name = client.Name
                })
                .ToListAsync();

            return Ok(clients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Client>>> GetClientById(int id)
        {
            var client = await _context.Client.Where(x => x.ClientId == id).Select(client => new Client
            {
                ClientId= client.ClientId,
                Name = client.Name
            })
                .FirstOrDefaultAsync();

            if(client == null)
            {
                return NotFound();
            }
            
            return Ok(client);
        }

        [HttpPost]
        public async Task<ActionResult<Client>> InsertClient(Client client)
        {
            var clientEntity = new AlcoAPI.Models.Entities.Client
            {
                Name = client.Name,
            };

            _context.Client.Add(clientEntity);
            _context.SaveChanges();

            var response = new AlcoAPI.Models.Client
            {
                ClientId = clientEntity.ClientId,
                Name = clientEntity.Name
            };


            return CreatedAtAction(nameof(GetClientById), new {id = clientEntity.ClientId}, response);
        }
    }
}
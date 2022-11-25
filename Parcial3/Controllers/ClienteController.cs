using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Parcial3.Entidades;

namespace Parcial3.Controllers
{
    [ApiController]
    [Route("cliente")]

    public class ClienteController : ControllerBase
    {
        private readonly ApplicationDbContext DbContext;
        private readonly ILogger<ClienteController> logger;
        private readonly IWebHostEnvironment env;

        public ClienteController(ApplicationDbContext dbContext, ILogger<ClienteController> logger, IWebHostEnvironment env)
        {
            this.DbContext = dbContext;
            this.logger = logger;
            this.env = env;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClienteController>>> Get()
        {
            var cliente = await DbContext.Cliente.ToListAsync();
            return Ok(cliente);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Cliente cliente)
        {
            DbContext.Add(cliente);
            await DbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Cliente cliente, int id)
        {
            var exist = await DbContext.Cliente.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound();
            }
          
            DbContext.Update(cliente);
            await DbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await DbContext.Cliente.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound("El Recurso no fue encontrado.");
            }

            DbContext.Remove(new Cliente()
            {
                Id = id
            });
            await DbContext.SaveChangesAsync();
            return Ok();
        }
    }

}

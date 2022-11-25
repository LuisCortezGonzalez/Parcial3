using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Parcial3.Controllers
{
    [ApiController]
    [Route("pedido")]

    public class PedidoController: ControllerBase
    {
        private readonly ApplicationDbContext DbContext;
        private readonly ILogger<ClienteController> logger;
        private readonly IWebHostEnvironment env;

        public PedidoController(ApplicationDbContext dbContext, ILogger<ClienteController> logger, IWebHostEnvironment env)
        {
            this.DbContext = dbContext;
            this.logger = logger;
            this.env = env;
        }

        [HttpGet]
        public async Task<ActionResult<List<PedidoController>>> Get()
        {
            var pedido = await DbContext.Pedido.ToListAsync();
            return Ok(pedido);
        }

        [HttpPost]
    }
}

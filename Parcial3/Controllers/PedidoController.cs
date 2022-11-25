using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial3.Entidades;

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
        [HttpGet("/listadoPedidos")]
        public async Task<ActionResult<List<Pedido>>> GetAll()
        {
            return await DbContext.Pedido.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Pedido pedido)
        {

        }

    }
}

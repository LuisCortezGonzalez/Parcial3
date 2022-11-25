namespace Parcial3.Entidades
{
    public class ClientePedido
    {
        public int ClienteId { get; set; }

        public int PedidoId { get; set; }

        public Cliente Cliente { get; set; }

        public Pedido Pedido { get; set; }
    }
}

namespace State
{
    public class CanceladoState: IState
    {
        private readonly Pedido _pedido;
        public CanceladoState(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void cancelarPedido()
        {
            throw new Exception("Operação não suportada, o pedido se encontra cancelado");
        }

        public void despacharPedido()
        {
            throw new Exception("Operação não suportada, o pedido se encontra cancelado");
        }

        public void sucessoAoPagar()
        {
            throw new Exception("Operação não suportada, o pedido já se encontra cancelado");
        }
    }
}

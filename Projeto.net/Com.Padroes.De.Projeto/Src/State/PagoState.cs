namespace State
{
    public class PagoState : IState
    {
        private Pedido _pedido;

        public PagoState(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void cancelarPedido()
        {
            _pedido.setEstadoAtual(_pedido.getCancelado());
        }

        public void despacharPedido()
        {
            _pedido.setEstadoAtual(_pedido.getEnviado());
        }

        public void sucessoAoPagar()
        {
            throw new Exception("Operação não suportada, o pedido já foi pago");
        }
    }
}

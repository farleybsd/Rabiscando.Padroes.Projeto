namespace State
{
    public class AguardandoPagamentoState : IState
    {
        private readonly Pedido _pedido;
        public AguardandoPagamentoState(Pedido pedido)
        {
            _pedido = pedido;
        }
        public void cancelarPedido()
        {
            _pedido.setEstadoAtual(_pedido.getCancelado());
        }

        public void despacharPedido()
        {
            throw new Exception("Operação não suportada, o pedido ainda não foi pago");
        }

        public void sucessoAoPagar()
        {
            _pedido.setEstadoAtual(_pedido.getPago());
        }
    }
}

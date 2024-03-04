namespace State
{
    public class EnviadoState : IState
    {
        private readonly Pedido _pedido;

        public EnviadoState(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void cancelarPedido()
        {
            throw new Exception("Operação não suportada, o pedido já foi pago e enviado");
        }

        public void despacharPedido()
        {
            throw new Exception("Operação não suportada, o pedido já enviado");
        }

        public void sucessoAoPagar()
        {
            throw new Exception("Operação não suportada, o pedido já enviado");
        }
    }
}

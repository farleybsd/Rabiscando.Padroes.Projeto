namespace State
{
    public class Pedido
    {
        protected internal IState _aguardandoPagamento;
        protected internal IState _pago;
        protected internal IState _cancelado;
        protected internal IState _enviado;
        protected internal IState _estadoAtual;

        public Pedido()
        {
            _aguardandoPagamento = new AguardandoPagamentoState(this);
            _pago = new PagoState(this);
            _cancelado = new CanceladoState(this);
            _enviado = new EnviadoState(this);

            _estadoAtual = _aguardandoPagamento;
        }

        public void realizarPagamento()
        {
            _estadoAtual.sucessoAoPagar();
        }

        public void cancelarPedido()
        {
            _estadoAtual.cancelarPedido();
        }
        public void despacharPedido()
        {
            _estadoAtual.despacharPedido();
        }

        public void setEstadoAtual(IState estado)
        {
            _estadoAtual = estado;
        }
        public IState getAguardandoPagamento()
        {
            return _aguardandoPagamento;
        }
        public IState getPago()
        {
            return _pago;
        }
        public IState getCancelado()
        {
            return _cancelado;
        }

        public IState getEnviado()
        {
            return _enviado;
        }
    }
}

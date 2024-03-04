namespace State
{
    public interface IState
    {
        void sucessoAoPagar();
        void despacharPedido();
        void cancelarPedido();
    }
}

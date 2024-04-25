namespace com.Padroes.De.Projeto.Facade.Vendas
{
    public abstract class Pagamento
    {
        public Pedido Pedido;
        public Pagamento(Pedido pedido)
        {
            Pedido = pedido;
        }
        public abstract bool realizarPagamento();
    }
}

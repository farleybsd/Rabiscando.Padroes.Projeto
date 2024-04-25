namespace com.Padroes.De.Projeto.Facade.Vendas
{
    public class PagamentoBoleto : Pagamento
    {
        public PagamentoBoleto(Pedido pedido) : base(pedido)
        {
        }

        public override bool realizarPagamento()
        {
            if (Pedido.getValor() > 0)
            {
                return true;
            }
            return false;
        }
    }
}

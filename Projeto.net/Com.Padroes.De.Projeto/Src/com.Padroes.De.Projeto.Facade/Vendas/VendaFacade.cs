namespace com.Padroes.De.Projeto.Facade.Vendas
{
    public class VendaFacade
    {
        public Pedido Pedido { get; private set; }
        public Pagamento Pagamento { get; private set; }
        public EmailPedido EmailPedido { get; private set; }

        public VendaFacade(Consumidor consumidor)
        {
            //Cria o pedido.
            Pedido = new Pedido(consumidor);
            //Adiciona o consumidor ao pedido.
            Pedido.setConsumidor(consumidor);
            //Cria o email passando o pedido como referência.
            EmailPedido = new EmailPedido(Pedido);
        }

        //Deixa o método addProduto dísponível para o cliente.
        public void addProduto(Produto produto)
        {
            Pedido.AddProduto(produto);
        }

        //Cria um pedido pago com cartão de crédito.
        public void pedidoCredito()
        {
            Pagamento = new PagamentoCredito(Pedido);
            if (Pagamento.realizarPagamento())
            {
                EmailPedido.enviarEmail("Pagamento realizado com sucesso via crédito");
            }
            else
            {
                EmailPedido.enviarEmail("Falha no pagamento via crédito");
            }
        }

        //Cria um pedido pago com boleto.
        public void pedidoBoleto()
        {
            Pagamento = new PagamentoCredito(Pedido);
            if (Pagamento.realizarPagamento())
            {
                EmailPedido.enviarEmail("Pagamento realizado com sucesso via boleto");
            }
            else
            {
                EmailPedido.enviarEmail("Falha no pagamento via boleto");
            }
        }
    }
}

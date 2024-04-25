namespace com.Padroes.De.Projeto.Facade.Vendas
{
    public class EmailPedido
    {
        private Pedido Pedido;

        public EmailPedido(Pedido pedido)
        {
            Pedido = pedido;
        }
        public void enviarEmail(string mensagem)
        {
            Console.WriteLine($"Email enviado para, {Pedido.getConsumidor().getEmail()}, 'Mensagem: {mensagem}");
        }
    }
}

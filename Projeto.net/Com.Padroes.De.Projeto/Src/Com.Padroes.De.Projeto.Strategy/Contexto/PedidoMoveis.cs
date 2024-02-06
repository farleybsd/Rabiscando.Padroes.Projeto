namespace Com.Padroes.De.Projeto.Strategy.Contexto
{
    public class PedidoMoveis : Pedido
    {
        protected string NomeSetor { get; set; }

        public PedidoMoveis()
        {
            NomeSetor = "Móveis";
        }

        public string getNomeSetor()
        {
            return NomeSetor;
        }

        public void setNomeSetor(string nomeSetor)
        {
            NomeSetor = nomeSetor;
        }
    }
}
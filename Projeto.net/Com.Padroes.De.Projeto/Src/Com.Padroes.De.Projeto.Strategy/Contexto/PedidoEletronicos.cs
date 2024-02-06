namespace Com.Padroes.De.Projeto.Strategy.Contexto
{
    public class PedidoEletronicos : Pedido
    {
        protected internal string NomeSetor { get; set; }

        public PedidoEletronicos()
        {
            NomeSetor = "Eletrônicos";
        }

        public string getNomeSetor()
        {
            return NomeSetor;
        }

        public void SetNomeSetor(string nomeSetor)
        {
            NomeSetor = nomeSetor;
        }
    }
}
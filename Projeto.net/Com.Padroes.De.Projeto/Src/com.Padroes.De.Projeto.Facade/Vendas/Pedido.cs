namespace com.Padroes.De.Projeto.Facade.Vendas
{
    public class Pedido
    {
        private Consumidor Consumidor;
        private List<Produto> Produtos;
        private float Valor = 0;

        public Pedido(Consumidor consumidor)
        {
            Consumidor = consumidor;
            Produtos = new List<Produto>();
        }
        public void setConsumidor(Consumidor consumidor)
        {
            Consumidor = consumidor;
        }

        public void AddProduto(Produto produto)
        {
            Produtos.Add(produto);
            Valor = produto.getValor();
        }

        public Consumidor getConsumidor()
        {
            return Consumidor;
        }

        public List<Produto> GetProdutos()
        {
            return Produtos;
        }

        public float getValor()
        {
            return Valor;
        }
    }
}

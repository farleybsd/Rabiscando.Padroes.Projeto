namespace com.Padroes.De.Projeto.Facade
{
    public class Produto
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public float Valor { get; private set; }

        public Produto(string nome, string descricao, float valor)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }

        public string getNome()
        {
            return Nome;
        }
        public string getDescricao()
        {
            return Descricao;
        }
        public float getValor()
        {
            return Valor;
        }
    }
}

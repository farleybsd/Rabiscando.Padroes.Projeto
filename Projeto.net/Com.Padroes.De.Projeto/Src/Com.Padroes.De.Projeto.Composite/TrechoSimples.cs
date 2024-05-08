namespace Com.Padroes.De.Projeto.Composite
{
    //Abstracao de um trecho Aereo Simples 
    public class TrechoSimples : ITrechoAereo
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public double Preco { get; set; }
        public TrechoSimples(string origem, string destino, double preco)
        {
            Origem = origem;
            Destino = destino;
            Preco = preco;
        }
        public string getDestino()
        {
            return Destino;
        }

        public string getOrigem()
        {
           return Origem;
        }

        public double getPreco()
        {
            return Preco;
        }
    }
}

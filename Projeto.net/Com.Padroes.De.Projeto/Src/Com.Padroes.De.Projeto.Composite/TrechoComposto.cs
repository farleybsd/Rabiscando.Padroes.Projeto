namespace Com.Padroes.De.Projeto.Composite
{
    //Padrão Composite, você trata objetos individuais e composições de objetos da mesma maneira, simplificando a interação entre eles
    public class TrechoComposto : ITrechoAereo
    {
        public ITrechoAereo Primeiro { get; private set; }
        public ITrechoAereo Segundo { get; private set; }
        public double TaxaConexao { get; private set; }

        public TrechoComposto(ITrechoAereo primeiro, ITrechoAereo segundo, double taxaconexao)
        {
            Primeiro = primeiro;
            Segundo = segundo;
            TaxaConexao = taxaconexao;
        }

        public string getDestino()
        {
            return Segundo.getDestino();
        }

        public string getOrigem()
        {
            return Primeiro.getOrigem();
        }

        public double getPreco()
        {
            Console.WriteLine($"TrechoComposto - Da Origem :{Primeiro.getOrigem()} para o destino {Segundo.getDestino()} ira custar R$:{Primeiro.getPreco() + Segundo.getPreco() + TaxaConexao},00");
            return Primeiro.getPreco() + Segundo.getPreco() + TaxaConexao;
        }
    }
}

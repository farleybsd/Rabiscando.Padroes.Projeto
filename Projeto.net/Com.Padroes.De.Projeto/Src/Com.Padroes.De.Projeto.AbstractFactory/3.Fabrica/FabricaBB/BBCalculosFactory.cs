using Com.Padroes.De.Projeto.AbstractFactory.Familia.BB;
using Com.Padroes.De.Projeto.AbstractFactory.Supertipos;

namespace Com.Padroes.De.Projeto.AbstractFactory._3.Fabrica.FabricaBB
{
    public class BBCalculosFactory : ICalculosFactory
    {
        public IDesconto criarDesconto()
        {
            return new BBDesconto(); //Retorna um objeto do tipo Desconto.
        }

        public IJuros criarJuros()
        {
            return new BBJuros(); //Retorna um objeto do tipo Juros.
        }

        public IMulta criarMulta()
        {
            return new BBMulta(); //Retorna um objeto do tipo Multa.
        }
    }
}

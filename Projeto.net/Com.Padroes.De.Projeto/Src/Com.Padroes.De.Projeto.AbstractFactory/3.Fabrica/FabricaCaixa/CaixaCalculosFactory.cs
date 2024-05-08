using Com.Padroes.De.Projeto.AbstractFactory.Familia.Caixa;
using Com.Padroes.De.Projeto.AbstractFactory.Supertipos;

namespace Com.Padroes.De.Projeto.AbstractFactory._3.Fabrica.FabricaCaixa
{
    public class CaixaCalculosFactory : ICalculosFactory
    {
        public IDesconto criarDesconto()
        {
            return new CaixaDesconto(); //Retorna um objeto do tipo Desconto.

        }

        public IJuros criarJuros()
        {
            return new CaixaJuros(); //Retorna um objeto do tipo Juros.
        }

        public IMulta criarMulta()
        {
            return new CaixaMulta(); //Retorna um objeto do tipo Multa.
        }
    }
}

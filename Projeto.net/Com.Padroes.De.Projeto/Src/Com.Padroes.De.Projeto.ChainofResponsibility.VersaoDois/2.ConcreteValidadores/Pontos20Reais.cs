using Com.Padroes.De.Projeto.ChainofResponsibility.VersaoDois._1.Solicitacao;
using Com.Padroes.De.Projeto.ChainofResponsibility.VersaoDois.Entidade;

namespace Com.Padroes.De.Projeto.ChainofResponsibility.VersaoDois._2.ConcreteValidadores
{
    public class NenhumPonto : ICalculadorDePontos
    {
        private ICalculadorDePontos ProximoCalculadorDePontos;


        public int calcularPontos(Pedido pedido)
        {
            //Se nenhuma das classes anteriores retornou os pontos então o cliente não pontua.
            return 0;
        }

        /*Guarda a referência do objeto da cadeia.
        Caso o método calcularPontos() da classe Pontos70Reais não consiga fazer o cálculo.
        o método calcularPontos() de $this->proximaCalculadoraDePontos será chamado.
        */

        public void setProximo(ICalculadorDePontos proximo)
        {
            //Fim da cadei
        }
    }
}

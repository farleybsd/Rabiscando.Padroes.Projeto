using Com.Padroes.De.Projeto.ChainofResponsibility.VersaoDois._1.Solicitacao;
using Com.Padroes.De.Projeto.ChainofResponsibility.VersaoDois.Entidade;

namespace Com.Padroes.De.Projeto.ChainofResponsibility.VersaoDois._2.ConcreteValidadores
{
    public class Pontos70Reais : ICalculadorDePontos
    {
        private ICalculadorDePontos ProximoCalculadorDePontos;


        public int calcularPontos(Pedido pedido)
        {
            if (pedido.getValor() >= 70) //Se o valor do pedido for maior ou igual a 70 reais.
            {
                //Retorne o resultado inteiro do valor do pedido dividido por 5.
                return (int)(pedido.getValor() / 5);
            }

            //Senão chame o método calcularPontos() do próximo calculador de pontos.
            return ProximoCalculadorDePontos.calcularPontos(pedido);
        }

        /*Guarda a referência do objeto da cadeia.
        Caso o método calcularPontos() da classe Pontos70Reais não consiga fazer o cálculo.
        o método calcularPontos() de $this->proximaCalculadoraDePontos será chamado.
        */

        public void setProximo(ICalculadorDePontos proximo)
        {
            ProximoCalculadorDePontos = proximo;
        }
    }
}

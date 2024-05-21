using Com.Padroes.De.Projeto.ChainofResponsibility.VersaoDois.Entidade;

namespace Com.Padroes.De.Projeto.ChainofResponsibility.VersaoDois._1.Solicitacao
{
    public interface ICalculadorDePontos
    {
        //Calcula os pontos gerados pelo pedido.
        int calcularPontos(Pedido pedido);
        //Define o próximo objeto calculador de pontos da cadeia.
        void setProximo(ICalculadorDePontos proximo);
    }
}

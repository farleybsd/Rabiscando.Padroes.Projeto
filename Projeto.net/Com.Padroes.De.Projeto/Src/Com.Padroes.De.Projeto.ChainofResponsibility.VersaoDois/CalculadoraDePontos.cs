using Com.Padroes.De.Projeto.ChainofResponsibility.VersaoDois._2.ConcreteValidadores;

namespace Com.Padroes.De.Projeto.ChainofResponsibility.VersaoDois.Entidade
{

    public class CalculadoraDePontos
    {
        public int CalcularPontosDoPedido(Pedido pedido, int dia)
        {
            //Os objetos calculadores de pontos são criados.
            var pontos70 = new Pontos70Reais();
            var pontos40 = new Pontos40Reais();
            var pontos20 = new Pontos20Reais();
            var nenhumPonto = new NenhumPonto();

            //Agora a ordem da cadeia de cálculo de pontos é definida.
            //Se Pontos70Reais não calcular ela passará o cálculo para Pontos40Reais.
            pontos70.setProximo(pontos40);
            //Se Pontos40Reais não calcular ela passará o cálculo para Pontos20Reais.
            pontos40.setProximo(pontos20);
            //Se Pontos40Reais não calcular ela passará o cálculo para NenhumPonto.
            //NenhumPonto irá retornar 0 e a cadeia chegará ao fim.
            pontos20.setProximo(nenhumPonto);
            //Se dia for maior ou igual a 16 e menor ou igual a 31 (Dia da segunda quinzena)
            if (dia >= 16 && dia <= 31)
            {
                //Retorna o cálculo de pontos multiplicado por 2 (dobrado).
                //Repare que o calculo é iniciado em Pontos70Reais que é o início da cadeia.
                return pontos70.calcularPontos(pedido) * 2;
            }
            //Senão, apenas retorna o cálculo de pontos.
            return pontos70.calcularPontos(pedido);
        }
    }
}

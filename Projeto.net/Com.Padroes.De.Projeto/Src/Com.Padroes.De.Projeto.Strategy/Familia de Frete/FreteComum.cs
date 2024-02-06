using Com.Padroes.De.Projeto.Strategy.Estrategia;

namespace Com.Padroes.De.Projeto.Strategy.Familia_de_Frete
{
    public class FreteComum : Frete
    {
        public float Calcula(float ValorPedido)
        {
            return ValorPedido * (float)0.05; //O frete comum custa 5% o valor do pedido.
        }
    }
}
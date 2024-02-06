using Com.Padroes.De.Projeto.Strategy.Estrategia;

namespace Com.Padroes.De.Projeto.Strategy.Familia_de_Frete
{
    public class FreteExpresso : Frete
    {
        public float Calcula(float ValorPedido)
        {
            return ValorPedido * (float)0.1; //O frete expresso custa 10% o valor do pedido
        }
    }
}
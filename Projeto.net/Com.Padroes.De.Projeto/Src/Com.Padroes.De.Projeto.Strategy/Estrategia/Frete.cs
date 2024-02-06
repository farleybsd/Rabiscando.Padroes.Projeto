namespace Com.Padroes.De.Projeto.Strategy.Estrategia
{
    public interface Frete
    {
        //Recebe o valor do pedido que é utilizado no calculo do frete.
        public float Calcula(float ValorPedido);
    }
}
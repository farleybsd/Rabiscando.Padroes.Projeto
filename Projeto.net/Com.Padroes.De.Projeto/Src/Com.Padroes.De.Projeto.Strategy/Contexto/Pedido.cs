using Com.Padroes.De.Projeto.Strategy.Estrategia;

namespace Com.Padroes.De.Projeto.Strategy.Contexto
{
    public abstract class Pedido
    {
        protected internal float Valor { get; set; }
        protected internal Frete TipoFrete { get; set; } //Referência para o tipo de frete.

        public float getValor()
        {
            return Valor;
        }

        public void setValor(float valor)
        {
            this.Valor = valor;
        }

        //Define o tipo de frete
        public void setTipoFrete(Frete frete)
        {
            TipoFrete = frete;
        }

        //Calcula o frete de acordo com a classe Frete recebida.
        public float CalculaFrete()
        {
            return TipoFrete.Calcula(Valor);
        }
    }
}
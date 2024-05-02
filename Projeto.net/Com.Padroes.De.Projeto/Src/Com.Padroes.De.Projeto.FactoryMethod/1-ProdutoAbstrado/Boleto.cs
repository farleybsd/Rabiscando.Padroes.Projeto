namespace Com.Padroes.De.Projeto.FactoryMethod.ProdutoAbstrado
{
    public class Boleto
    {
        protected float Valor;
        protected float Juros;
        protected float Desconto;
        protected float Multa;

        public Boleto(float valor)
        {
            Valor = valor;
        }

        //Calcula valor do Juros do boleto
        public float calcularJuros()
        {
            return Valor * Juros;
        }

        //Calcula valor do Desconto do boleto
        public float calcularDesconto()
        {
            return Valor * Desconto;
        }

        //Calcula valor da Multa do boleto
        public float calcularMulta()
        {
            return Valor * Multa;   
        }
    }
}

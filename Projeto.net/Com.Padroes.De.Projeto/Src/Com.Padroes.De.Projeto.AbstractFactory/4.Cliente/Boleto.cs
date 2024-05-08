using Com.Padroes.De.Projeto.AbstractFactory._3.Fabrica;
using Com.Padroes.De.Projeto.AbstractFactory.Supertipos;

namespace Com.Padroes.De.Projeto.AbstractFactory._4.Cliente
{
    public class Boleto
    {
        public float Valor { get; private set; }
        public IJuros Juros { get; private set; } //Guarda referência a um objeto do tipo Juros.
        public IDesconto Desconto { get; private set; } //Guarda referência a um objeto do tipo Desconto.
        public IMulta Multa { get; private set; } //Guarda referência a um objeto do tipo Multa.

        //O boleto recebe em seu construtor o seu valor e a fábrica que deve utilizar
        //para criar os cálculos.
        public Boleto(float valor, ICalculosFactory calculosFactory)
        {
            Valor = valor;
            Juros = calculosFactory.criarJuros();
            Desconto = calculosFactory.criarDesconto();
            Multa = calculosFactory.criarMulta();
        }


        public float calcularJuros()
        {
            //Retorna o valor do juros em reais, usa o método getJuros() do objeto do tipo Juros
            //criado pela fábrica.
            return Valor * Juros.getJuros();
        }
        public float calcularDesconto()
        {
            //Retorna o valor do Desconto em reais, usa o método getDesconto() do objeto
            //do tipo Desconto criado pela fábrica.
            return Valor * Desconto.getDesconto();
        }

        public float calcularMulta()
        {
            //Retorna o valor da Multa em reais, usa o método getMulta() do objeto do tipo Multa
            //criado pela fábrica.
            return Valor * Multa.getMulta();

        }
    }
}

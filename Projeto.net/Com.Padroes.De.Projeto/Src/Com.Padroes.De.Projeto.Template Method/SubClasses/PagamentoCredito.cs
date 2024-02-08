using Com.Padroes.De.Projeto.Template_Method.SuperClasse;

namespace Com.Padroes.De.Projeto.Template_Method.SubClasses
{
    public class PagamentoCredito : Pagamento
    {
        public PagamentoCredito(float valor, Gateway gateway) : base(valor, gateway)
        {
        }

        //Calcula o desconto.
        public override float CalcularDesconto()
        {
            //Se o valor pago for maior que 300 reais.
            if (this._Valor > 300)
            {
                //Retorna um desconto de 2% sob o valor do pagamento.
                return this._Valor * (float)0.02;
            }
            // Pagamentos de valores menores que 300 reais não possuem desconto
            return 0;
        }

        //Calcula a taxa do Gateway.
        public override float calcularTaxa()
        {
            return this._Valor * (float)0.05;
        }
    }
}
using Com.Padroes.De.Projeto.Template_Method.SuperClasse;

namespace Com.Padroes.De.Projeto.Template_Method.SubClasses
{
    public class PagamentoDebito : Pagamento
    {
        public PagamentoDebito(float valor, Gateway gateway) : base(valor, gateway)
        {
        }

        //Calcula o desconto.
        public override float CalcularDesconto()
        {
            //Retorna o valor do pagamento com desconto de 5%.
            return _Valor * (float)0.05;
        }

        public override float calcularTaxa()
        {
            return 4;
        }
    }
}
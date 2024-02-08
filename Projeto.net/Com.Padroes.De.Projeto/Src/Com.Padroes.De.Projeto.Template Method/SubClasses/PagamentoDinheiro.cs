using Com.Padroes.De.Projeto.Template_Method.SuperClasse;

namespace Com.Padroes.De.Projeto.Template_Method.SubClasses
{
    public class PagamentoDinheiro : Pagamento
    {
        public PagamentoDinheiro(float valor, Gateway gateway) : base(valor, gateway)
        {
        }

        //Calcula o desconto.
        public override float CalcularDesconto()
        {
            //Retorna o valor do pagamento com desconto de 10%.
            return _Valor * (float)0.1;
        }

        public override float calcularTaxa()
        {
            return 0;
        }
    }
}
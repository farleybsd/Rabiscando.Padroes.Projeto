namespace Com.Padroes.De.Projeto.Template_Method.SuperClasse
{
    public abstract class Pagamento
    {
        protected float _Valor { get; set; }
        protected Gateway _gateway { get; set; }

        public Pagamento(float valor, Gateway gateway)
        {
            _Valor = valor;
            _gateway = gateway;
        }

        //Será implementado pelas subclasses.
        public abstract float CalcularDesconto();

        public abstract float calcularTaxa();

        public bool realizaCobranca()
        {
            var valorFinal = this._Valor + this.calcularTaxa() - this.CalcularDesconto();

            //-- Início da impressão dos valores separados (Apenas para visualização)
            Console.WriteLine($"{_Valor} + {calcularTaxa()} - {CalcularDesconto()} = ");
            //-- Fim da impressão dos valores separados

            return _gateway.Cobrar(valorFinal);
        }
    }
}
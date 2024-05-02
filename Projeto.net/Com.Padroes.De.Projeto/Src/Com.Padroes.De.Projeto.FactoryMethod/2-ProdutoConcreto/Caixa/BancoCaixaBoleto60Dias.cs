using Com.Padroes.De.Projeto.FactoryMethod.ProdutoAbstrado;

namespace Com.Padroes.De.Projeto.FactoryMethod._2_ProdutoConcreto.Caixa
{
    public class BancoCaixaBoleto60Dias : Boleto
    {
        public BancoCaixaBoleto60Dias(float valor) : base(valor)
        {
            Juros = 0.10f;
            Desconto = 0;
            Multa = 0.2f;
        }

    }
}

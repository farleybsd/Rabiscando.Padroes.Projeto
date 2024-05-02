using Com.Padroes.De.Projeto.FactoryMethod.ProdutoAbstrado;

namespace Com.Padroes.De.Projeto.FactoryMethod._2_ProdutoConcreto.Caixa
{
    public class BancoCaixaBoleto10Dias : Boleto
    {
        public BancoCaixaBoleto10Dias(float valor) : base(valor)
        {
            Juros = 0.02f;
            Desconto = 0.01f;
            Multa = 0.05f;
        }

    }
}

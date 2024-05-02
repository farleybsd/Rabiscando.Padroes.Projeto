using Com.Padroes.De.Projeto.FactoryMethod.ProdutoAbstrado;

namespace Com.Padroes.De.Projeto.FactoryMethod._2_ProdutoConcreto.Caixa
{
    public class BancoCaixaBoleto30Dias : Boleto
    {
        public BancoCaixaBoleto30Dias(float valor) : base(valor)
        {
            Juros = 0.05f;
            Desconto = 0.05f;
            Multa = 0.01f;
        }

    }
}

using Com.Padroes.De.Projeto.FactoryMethod.ProdutoAbstrado;

namespace Com.Padroes.De.Projeto.FactoryMethod._2_ProdutoConcreto.BancoDoBrasil
{
    public class BancoDoBrasilBoleto10Dias : Boleto
    {
        public BancoDoBrasilBoleto10Dias(float valor) : base(valor)
        {
            Juros = 0.03f;
            Desconto = 0.05f;
            Multa = 0.02f;
        }
    }
}

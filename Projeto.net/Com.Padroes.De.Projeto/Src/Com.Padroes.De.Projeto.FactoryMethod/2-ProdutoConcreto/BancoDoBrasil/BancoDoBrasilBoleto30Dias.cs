using Com.Padroes.De.Projeto.FactoryMethod.ProdutoAbstrado;

namespace Com.Padroes.De.Projeto.FactoryMethod._2_ProdutoConcreto.BancoDoBrasil
{
    public class BancoDoBrasilBoleto30Dias : Boleto
    {
        public BancoDoBrasilBoleto30Dias(float valor) : base(valor)
        {
            Juros = 0.05f;
            Desconto = 0.02f;
            Multa = 0.5f;
        }
    }
}

using Com.Padroes.De.Projeto.FactoryMethod.ProdutoAbstrado;

namespace Com.Padroes.De.Projeto.FactoryMethod._2_ProdutoConcreto.BancoDoBrasil
{
    public class BancoDoBrasilBoleto60Dias : Boleto
    {
        public BancoDoBrasilBoleto60Dias(float valor) : base(valor)
        {
            Juros = 0.1f;
            Desconto = 0;
            Multa = 0.15f;
        }
    }
}

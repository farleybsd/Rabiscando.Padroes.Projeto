using Com.Padroes.De.Projeto.FactoryMethod._2_ProdutoConcreto.BancoDoBrasil;
using Com.Padroes.De.Projeto.FactoryMethod._2_ProdutoConcreto.Caixa;
using Com.Padroes.De.Projeto.FactoryMethod._3_FabricaAbstrada;
using Com.Padroes.De.Projeto.FactoryMethod.ProdutoAbstrado;

namespace Com.Padroes.De.Projeto.FactoryMethod._4__FabricaConcreta
{
    public class BancoDoBrasil : Banco
    {
        protected override Boleto criarBoleto(int vencimentoBoleto, float valor)
        {
            switch (vencimentoBoleto)
            {
                case 10:
                    return new BancoDoBrasilBoleto10Dias(valor);
                case 30:
                    return new BancoDoBrasilBoleto30Dias(valor);
                case 60:
                    return new BancoDoBrasilBoleto60Dias(valor);
                default:
                    throw new Exception("Vencimento Indisponível");
            }
        }
    }
}

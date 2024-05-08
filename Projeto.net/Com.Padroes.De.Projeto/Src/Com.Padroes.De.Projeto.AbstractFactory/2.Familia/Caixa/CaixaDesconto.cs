using Com.Padroes.De.Projeto.AbstractFactory.Supertipos;

namespace Com.Padroes.De.Projeto.AbstractFactory.Familia.Caixa
{
    public class CaixaDesconto : IDesconto
    {
        public float getDesconto()
        {
            return 0.1f; //Retorna 10%
        }
    }
}

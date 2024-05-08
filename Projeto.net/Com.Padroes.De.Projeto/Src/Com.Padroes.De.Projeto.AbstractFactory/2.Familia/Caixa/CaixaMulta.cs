using Com.Padroes.De.Projeto.AbstractFactory.Supertipos;

namespace Com.Padroes.De.Projeto.AbstractFactory.Familia.Caixa
{
    public class CaixaMulta : IMulta
    {
        public float getMulta()
        {
            return 0.05f; //Retorna 5%.
        }
    }
}

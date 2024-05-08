using Com.Padroes.De.Projeto.AbstractFactory.Supertipos;

namespace Com.Padroes.De.Projeto.AbstractFactory.Familia.Caixa
{
    public class CaixaJuros : IJuros
    {
        public float getJuros()
        {
            return 0.02f; //Retorna 2%.
        }
    }
}

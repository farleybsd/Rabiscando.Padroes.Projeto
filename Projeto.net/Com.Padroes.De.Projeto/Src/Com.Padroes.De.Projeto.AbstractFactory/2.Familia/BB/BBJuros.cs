using Com.Padroes.De.Projeto.AbstractFactory.Supertipos;

namespace Com.Padroes.De.Projeto.AbstractFactory.Familia.BB
{
    public class BBJuros : IJuros
    {
        public float getJuros()
        {
            return 0.03f; //Retorna 3%.
        }
    }
}

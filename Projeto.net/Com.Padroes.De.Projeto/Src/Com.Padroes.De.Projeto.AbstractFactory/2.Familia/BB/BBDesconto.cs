using Com.Padroes.De.Projeto.AbstractFactory.Supertipos;

namespace Com.Padroes.De.Projeto.AbstractFactory.Familia.BB
{
    public class BBDesconto : IDesconto
    {
        public float getDesconto()
        {
            return 0.05f; //Retorna 5%.
        }
    }
}

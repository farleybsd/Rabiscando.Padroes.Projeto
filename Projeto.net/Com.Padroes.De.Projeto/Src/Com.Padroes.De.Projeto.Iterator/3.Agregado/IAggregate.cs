using Com.Padroes.De.Projeto.Iterator._2.Iterator;

namespace Com.Padroes.De.Projeto.Iterator._3.Agregado
{
    // Interface da coleção
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}

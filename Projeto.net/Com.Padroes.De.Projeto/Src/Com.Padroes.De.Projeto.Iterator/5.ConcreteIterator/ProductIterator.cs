using Com.Padroes.De.Projeto.Iterator._2.Iterator;
using Com.Padroes.De.Projeto.Iterator._4.ConcreteAgregado;

namespace Com.Padroes.De.Projeto.Iterator._5.ConcreteIterator
{
    // Implementação concreta do Iterator
    public class ProductIterator : IIterator
    {
        private readonly ProductCollection _collection;
        private int _currentIndex;
        public ProductIterator(ProductCollection collection)
        {
            _collection = collection;
            _currentIndex = 0;
        }

        public bool HasNext()
        {
            return _currentIndex < _collection.Count;
        }

        public object Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException("No more products.");
            }
            return _collection[_currentIndex++];
        }
    }
}

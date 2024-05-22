using Com.Padroes.De.Projeto.Iterator._2.Iterator;
using Com.Padroes.De.Projeto.Iterator._3.Agregado;
using Com.Padroes.De.Projeto.Iterator._5.ConcreteIterator;
using Com.Padroes.De.Projeto.Iterator.Entidade;

namespace Com.Padroes.De.Projeto.Iterator._4.ConcreteAgregado
{
    // Implementação concreta da coleção de produtos
    public class ProductCollection : IAggregate
    {

        private List<Product> Products = new List<Product>();

        public int Count => Products.Count;
        public Product this[int index] => Products[index];

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public IIterator CreateIterator()
        {
            return new ProductIterator(this);
        }
    }
}

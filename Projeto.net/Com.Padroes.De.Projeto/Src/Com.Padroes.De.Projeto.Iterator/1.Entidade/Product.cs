namespace Com.Padroes.De.Projeto.Iterator.Entidade
{
    public class Product
    {
        // Produto da classe representando um produto no supermercado
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Produto: {Name}, Preço: {Price:C}";
        }
    }
}


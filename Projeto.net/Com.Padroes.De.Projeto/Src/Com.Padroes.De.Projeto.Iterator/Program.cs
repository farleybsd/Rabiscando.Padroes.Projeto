/*
 * O design pattern Iterator é utilizado para acessar os elementos
 * de uma coleção de forma sequencial, sem expor sua implementação interna.
 * Ele define uma interface para percorrer os elementos e facilita a iteração
 * sobre diferentes estruturas de dados, como listas, pilhas e filas, de maneira
 * uniforme.
 */

// Criando coleção de produtos
using Com.Padroes.De.Projeto.Iterator._2.Iterator;
using Com.Padroes.De.Projeto.Iterator._4.ConcreteAgregado;
using Com.Padroes.De.Projeto.Iterator.Entidade;

ProductCollection products = new ProductCollection();
products.AddProduct(new Product("Maçã", 3.50));
products.AddProduct(new Product("Banana", 2.00));
products.AddProduct(new Product("Laranja", 4.00));
products.AddProduct(new Product("Melancia", 10.00));

// Criando iterator para a coleção de produtos
IIterator iterator = products.CreateIterator();

Console.WriteLine("Aplicando desconto de promoção:");

// Iterando sobre a coleção de produtos e aplicando desconto
while (iterator.HasNext())
{
    Product product = (Product)iterator.Next();
    ApplyDiscount(product, 0.10); // Aplicando 10% de desconto
    Console.WriteLine(product);
}

// Função para aplicar desconto no preço do produto
void ApplyDiscount(Product product, double discountPercentage)
{
    product.Price -= product.Price * discountPercentage;
}

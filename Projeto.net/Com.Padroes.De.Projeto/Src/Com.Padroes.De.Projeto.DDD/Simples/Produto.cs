// 1. Definindo como Entidades e o Agregado
// Entidade raiz : Pedido
// Entidades compostas : ItemPedido
// Objetos de valor : Produto(representa um produto com nome e preço)
namespace Com.Padroes.De.Projeto.DDD.Simples;

using System;
using System.Collections.Generic;

public class Produto
{
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }

    public Produto(string nome, decimal preco)
    {
        if (string.IsNullOrEmpty(nome))
            throw new ArgumentException("Nome do produto não pode ser vazio");
        
        if (preco <= 0)
            throw new ArgumentException("Preço deve ser maior que zero");

        Nome = nome;
        Preco = preco;
    }
}

public class ItemPedido
{
    public Produto Produto { get; private set; }
    public int Quantidade { get; private set; }
    public decimal Total => Produto.Preco * Quantidade;

    public ItemPedido(Produto produto, int quantidade)
    {
        if (quantidade <= 0)
            throw new ArgumentException("Quantidade deve ser maior que zero");

        Produto = produto;
        Quantidade = quantidade;
    }
}

public class Pedido
{
    public int Id { get; private set; }
    public DateTime DataPedido { get; private set; }
    private List<ItemPedido> _itensPedido;
    public IReadOnlyList<ItemPedido> ItensPedido => _itensPedido.AsReadOnly();

    public Pedido(int id)
    {
        Id = id;
        DataPedido = DateTime.Now;
        _itensPedido = new List<ItemPedido>();
    }

    // Método para adicionar item ao pedido
    public void AdicionarItem(Produto produto, int quantidade)
    {
        var item = new ItemPedido(produto, quantidade);
        _itensPedido.Add(item);
    }

    // Método para calcular o valor total do pedido
    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var item in _itensPedido)
        {
            total += item.Total;
        }
        return total;
    }
}
/*
Explicação:
Produto : Esta classe representa um objeto de valor, com as propriedades Nomee Preco. A validação é feita no construtor para garantir que os dados sejam consistentes.

    ItemPedido : Representa um item de um pedido, incluindo o produto e a quantidade. Ele também calcula o total desse item com base no preço do produto e na quantidade.

    Pedido : É o agregado, sendo a entidade raiz . Ele contém uma lista de ItemPedidoe é responsável por garantir a consistência. O pedido tem um método AdicionarItemque adiciona um item à lista e o método CalcularTotal, que calcula o total do pedido somando os totais de cada item.

    Comportamento de Agregado:
Raiz de Consistência : O Pedidoé a raiz do agregado, e é através dele que todas as interações com o agregado ocorrem.
    Encapsulamento : O agregado garante que todos os itens do pedido sejam consistentes e que o total seja calculado corretamente. Os itens não são manipulados diretamente de fora do agregado.
    Regras de Negócio : As regras como a quantidade de itens e os valores dos produtos são validados diretamente dentro do agregado e das entidades compostas.
    Este exemplo mostra como podemos modelar um agregado com regras de consistência e encapsulamento, mantendo a integridade do domínio dentro do contexto de DDD.
*/
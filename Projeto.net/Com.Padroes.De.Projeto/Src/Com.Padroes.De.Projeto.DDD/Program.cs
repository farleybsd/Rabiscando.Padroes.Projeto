//Vou criar um exemplo simples de agregado usando C# com base no conceito do DDD. Neste exemplo, vamos simular um agregado 
//chamado Pedido, que é um agregado que contém um conjunto de ItemPedido. Ele Pedidoserá uma entidade raiz do agregado e será 
//responsável por garantir a consistência dos dados.


// Criando alguns produtos

using Com.Padroes.De.Projeto.DDD.Patrico;
using Com.Padroes.De.Projeto.DDD.Simples;
using ItemPedido = Com.Padroes.De.Projeto.DDD.Simples.ItemPedido;
using Pedido = Com.Padroes.De.Projeto.DDD.Simples.Pedido;

var produto1 = new Produto("Produto A", 10.00m);
var produto2 = new Produto("Produto B", 20.00m);

// Criando um pedido
var pedido = new Pedido(1);

// Adicionando itens ao pedido
pedido.AdicionarItem(produto1, 2); // 2 unidades do Produto A
pedido.AdicionarItem(produto2, 1); // 1 unidade do Produto B

// Exibindo o total do pedido
Console.WriteLine("Total do Pedido: " + pedido.CalcularTotal());

/*
Vou mostrar um exemplo prático de um agregado em C# no contexto de DDD. Vamos construir um domínio simples para exemplificar:
 um Pedido com itens. O pedido será nosso agregado, e ele terá uma entidade raiz ( Pedido) que gerencia uma coleção de itens 
 ( ItemPedido).
1. Estrutura do Agregado
    O agregado Pedidopossui uma única entidade raiz, Pedido, e uma coleção de ItemPedido. Todos os comportamentos e mudanças não Pedidodevem passar pela entidade raiz para garantir consistência.
    Como Usar ou Agregado
Aqui está um exemplo de como instanciar e manipular o agregado Pedido:
*/

var pedido1 = new Pedido1();

var item1 = new ItemPedido1("Produto A", 2, new Dinheiro(100, "BRL"));
var item2 = new ItemPedido1("Produto B", 1, new Dinheiro(200, "BRL"));

// Adicionar itens ao pedido
pedido1.AdicionarItem(item1);
pedido1.AdicionarItem(item2);

// Calcular o total do pedido
Dinheiro totalPedido = pedido1.CalcularTotalPedido();
Console.WriteLine($"Total do Pedido: {totalPedido.Valor} {totalPedido.Moeda}");

// Remover um item
pedido1.RemoverItem(item1.Id);

// Recalcular o total após remoção
totalPedido = pedido1.CalcularTotalPedido();
Console.WriteLine($"Total do Pedido após remoção: {totalPedido.Valor} {totalPedido.Moeda}");
/*
 * Explicação do Uso
Primeiro, criamos um Pedido.
Depois, adicionamos dois ItemPedidoao pedido usando o método AdicionarItem.
Calculamos o total usando CalcularTotalPedido.
Removemos um item e recalculamos o total para garantir que a consistência do agregado seja mantida.
Conclusão
Este exemplo mostra um agregado com uma entidade raiz ( Pedido) que controla uma coleção de ItemPedido. Todas as operações sobre o agregado (como adicionar ou remover itens) passam pela entidade raiz, garantindo consistência e encapsulando regras de negócio no agregado.


 */

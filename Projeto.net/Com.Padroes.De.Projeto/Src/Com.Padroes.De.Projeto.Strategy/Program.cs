/*
 Tome como exemplo o cálculo do valor de diferentes tipos de frete
 para um pedido realizado em um e-commerce. Os fretes disponíveis são Frete
 Comum e Frete Expresso. Todos os pedidos devem saber calcular seu frete.
*/

using Com.Padroes.De.Projeto.Strategy.Contexto;
using Com.Padroes.De.Projeto.Strategy.Familia_de_Frete;

//Criação do tipos de frete.
var freteComun = new FreteComum();
var freteExpresso = new FreteExpresso();

//Criação de um pedido do setor de eletrônicos.
var pedidoEletronico = new PedidoEletronicos();

//Atribuição do valor
pedidoEletronico.setValor(100);

//Definição do frete comum com sendo o frete escolhido.
pedidoEletronico.setTipoFrete(freteComun);

//Cálculo do frete comum.
Console.WriteLine($"Eletrônicos Frete Comum: R$'{pedidoEletronico.CalculaFrete()},00");

//No mesmo medido podemos trocar o tipo de frete
pedidoEletronico.setTipoFrete(freteExpresso);

//Agora o cálculo do frete expresso.

Console.WriteLine($"Eletrônicos Frete Expresso: R$'{pedidoEletronico.CalculaFrete()},00");

//Criação de um pedido do setor de eletrônicos.
Console.WriteLine("Criação de um pedido do setor de eletrônicos.");

var pedidoMoveis = new PedidoMoveis();

//Atribuição do valor.
pedidoMoveis.setValor(100);

//Definição do frete comum com sendo o frete escolhido. Expresso não está disponível.
pedidoMoveis.setTipoFrete(freteComun);

//Cálculo do frete comum.
Console.WriteLine($"Móveis Frete Comum: R$: R$'{pedidoMoveis.CalculaFrete()},00");
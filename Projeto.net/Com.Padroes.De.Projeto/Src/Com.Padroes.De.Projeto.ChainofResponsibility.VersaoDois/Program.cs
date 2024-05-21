// Criação de um pedido
using Com.Padroes.De.Projeto.ChainofResponsibility.VersaoDois.Entidade;

var pedido = new Pedido();

// Criação da calculadora de pontos
var calculadoraDePontos = new CalculadoraDePontos();

// Definição do valor do pedido igual a 21 reais
pedido.setValor(21);

// Cálculo de pontos na primeira quinzena (dia 15)
Console.WriteLine("Dia 15: " + calculadoraDePontos.CalcularPontosDoPedido(pedido, 15) + " Pontos");

// Cálculo de pontos na segunda quinzena (dia 16)
Console.WriteLine("Dia 16: " + calculadoraDePontos.CalcularPontosDoPedido(pedido, 16) + " Pontos");

// Apenas para separar os resultados
Console.WriteLine("---------------------------");

// Mudança do valor do pedido para 100 reais
pedido.setValor(100);

// Cálculo de pontos na primeira quinzena (dia 15)
Console.WriteLine("Dia 15: " + calculadoraDePontos.CalcularPontosDoPedido(pedido, 15) + " Pontos");

// Cálculo de pontos na segunda quinzena (dia 16)
Console.WriteLine("Dia 16: " + calculadoraDePontos.CalcularPontosDoPedido(pedido, 16) + " Pontos");
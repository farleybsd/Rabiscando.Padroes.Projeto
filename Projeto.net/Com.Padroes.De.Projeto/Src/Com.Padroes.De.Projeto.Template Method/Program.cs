/*
 * O template method serve para  quando voce tem um metodo centralizado e possui depedencia de demais metodos que sao variantes para esse metodo central ser execultado.
 * Com Templete Metodo esse metodos acabam ficando nas subclasses aonde  fica as variacoes (os metodos que variam)
 * E methodo central  fica na Super Classe
 *  Super Classe (Pagamento) - Temple metodo (realizaCobranca)
 *   SubClasse(PagamentoCredito/PagamentoDebito) - metodo de variacao(calcularTaxa/calcularDesconto)
 */

using Com.Padroes.De.Projeto.Template_Method;
using Com.Padroes.De.Projeto.Template_Method.SubClasses;

var valor = 1000; //Definição do valor do pagamento.
var gateway = new Gateway(); //Criação de uma instância de Gateway.
//Pagamento Crédito.
Console.WriteLine("Crédito:");
var pagamentoCredito = new PagamentoCredito(valor, gateway);
pagamentoCredito.realizaCobranca();
//Pagamento Débito.
Console.WriteLine("Débito");
var pagamentoDebito = new PagamentoDebito(valor, gateway);
pagamentoDebito.realizaCobranca();
//Pagamento Dinheiro.
Console.WriteLine("Dinheiro");
var pagamentoDinheiro = new PagamentoDinheiro(valor, gateway);
pagamentoDinheiro.realizaCobranca();
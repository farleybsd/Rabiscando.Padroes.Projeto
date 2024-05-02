/*
  o Factory Method permite que você defina uma interface para criar objetos, mas delega a decisão sobre qual classe concreta instanciar para subclasses. Assim, você pode ter diferentes tipos de objetos sem alterar o código cliente principal.
 */


using Com.Padroes.De.Projeto.FactoryMethod._3_FabricaAbstrada;
using Com.Padroes.De.Projeto.FactoryMethod._4__FabricaConcreta;

Console.WriteLine("######### Caixa #########<"); //Apenas imprime um separador no navegador.

//Criação de uma instância de BancoCaixa. Boletos gerados serão da Caixa.
var bancoCaixa = new BancoCaixa();
//Gera um BancoCaixaBoleto10Dias.
bancoCaixa.gerarBoleto(10, 100);
//Gera um BancoCaixaBoleto30Dias.
bancoCaixa.gerarBoleto(30, 100);
//Gera um BancoCaixaBoleto60Dias.
bancoCaixa.gerarBoleto(60, 100);

Console.WriteLine("######### Banco do Brasil #########"); //Apenas imprime um separador no navegador.

//Criação de uma instância de BancoDoBrasil. Boletos gerados serão do Banco do Brasil.
var bancoDoBrasil = new BancoDoBrasil();
//Gera um BancoDoBrasilBoleto10Dias.
bancoDoBrasil.gerarBoleto(10, 100);
//Gera um BancoDoBrasilBoleto30Dias.
bancoDoBrasil.gerarBoleto(30, 100);
//Gera um BancoDoBrasilBoleto60Dias.
bancoDoBrasil.gerarBoleto(60, 100);
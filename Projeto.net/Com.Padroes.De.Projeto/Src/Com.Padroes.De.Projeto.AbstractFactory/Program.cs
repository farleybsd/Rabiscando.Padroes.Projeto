using Com.Padroes.De.Projeto.AbstractFactory._4.Cliente;

//Criação de um objeto Banco.
var banco = new Banco();
//Criação de um boleto da Caixa.
Console.WriteLine( "### Boleto da Caixa ###<br>");
banco.gerarBoletoCaixa(100);
//Criação de um boleto do Banco do Brasil.
Console.WriteLine("### Boleto do Banco do Brasil ###<br>");
banco.gerarBoletoBB(100);
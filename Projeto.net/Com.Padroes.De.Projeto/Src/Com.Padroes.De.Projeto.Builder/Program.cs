using Com.Padroes.De.Projeto.Builder._02.Builders;
using Com.Padroes.De.Projeto.Builder._04.Orquestrador;

Console.WriteLine("## Criação do objeto A4 ##"); ;
var builderA4 = new BuilderA4();
var director = new GeradorPDFDirector(builderA4);
director.criarGeradorPDFNoHeaderNoFooter();
var pdf = builderA4.getGeradorPDF();

//Impressão do Objeto A4
Console.WriteLine(pdf.__toString());


Console.WriteLine("## Criação do objeto A3 ##");
var builderA3 = new BuilderA3();
director.setBuilderGeradorPDF(builderA3);
director.criarGeradorPDFNoHeaderNoFooter();
pdf = builderA3.getGeradorPDF();

//Impressão do Objeto A3
Console.WriteLine(pdf.__toString());

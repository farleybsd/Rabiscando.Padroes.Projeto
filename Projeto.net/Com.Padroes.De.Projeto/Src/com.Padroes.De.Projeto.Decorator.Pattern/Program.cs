/*
 *  Decorator - Padrões Estruturais
 *  O Padrão Decorator anexa responsabilidades adicionais a um objeto
 *  dinamicamente. Os Decorators fornecem uma alternativa flexível ao uso de
 *  subclasses para extensão de funcionalidades
 */

/*
 * Motivação - (Por que utilizar?)
 * Às vezes, queremos adicionar responsabilidades a objetos individuais,
 *  não a uma classe inteira. Uma maneira de adicionar responsabilidades é com
 *  herança. Herdar uma característica de outra classe faz com que a subclasse
 *  também a tenha. Isso é inflexível, pois, a definição de tal característica
 *  é feita estaticamente, de modo que Cliente não pode controlar como e
 *  quando decorar o objeto com ela.
 */


/*
 *  Para ilustrar tal situação, tomemos como exemplo o sistema de uma
 *   Pizzaria, onde o cliente pode acrescentar características adicionais a sua
 *   pizza. É importante dizer que os donos da pizzaria em breve criarão novos
 *   sabores de pizza e novos acréscimos.
 */

/*
 **** A pizzaria possui 3 sabores de pizza em seu cardápio: ***
        ● Pizza de Frango - R$19,00;
        ● Pizza de Calabresa - R$25,00;
        ● Pizza de Queijo - R$22,00;
 **** Os acréscimos são: ****
        ● Borda recheada com requeijão - R$8,50;
        ● Massa Integral - R$5,00;

 * Cada pizza tem um preço, ao adicionar um acréscimo seu valor deve ser
 * somado ao valor da pizza. Por exemplo, uma pizza de frango com borda
 *  recheada de requeijão custaria R$27,50.
 */

//==== Criação de uma Pizza ====
using com.Padroes.De.Projeto.Decorator.Pattern._02.SubClasses;
using com.Padroes.De.Projeto.Decorator.Pattern._03.Decorados;

var pizzaQueijo = new PizzaQueijo();
//Impressão de sua descrição
Console.WriteLine($"Descrição {pizzaQueijo.getDescricao()}");
//Impressão de seu preço
Console.WriteLine($"Preço: R$ {pizzaQueijo.getPreco()}");
//==== Adição borda de requeijão a pizza ====
Console.WriteLine("Adição de borda de requeijão");
//Um decorator é criado e passa a englobar a pizza
var pizzaQueijoBorda = new BordaRequeijao(pizzaQueijo);
//Impressão da descrição do decorator + pizza
Console.WriteLine($"Descrição {pizzaQueijoBorda.getDescricao()}");
//Impressão do preço do decorator + pizza
Console.WriteLine($"Preço: R$ {pizzaQueijoBorda.getPreco()}");
//==== Adição massa integral a pizza ====
Console.WriteLine(" Adição de massa integral");
//Mais um decorator é criado e passa a englobar o primeiro decorator e a pizza
var pizzaQueijoBordaMassaIntegral = new MassaIntegral(pizzaQueijoBorda);
//Impressão da descrição do primeiro decorator + segundo decorator + pizza
Console.WriteLine($"Descrição {pizzaQueijoBordaMassaIntegral.getDescricao()}");
//Impressão do preço do primeiro decorator + segundo decorator + pizza
Console.WriteLine($"Preço: R$ {pizzaQueijoBordaMassaIntegral.getPreco()}");

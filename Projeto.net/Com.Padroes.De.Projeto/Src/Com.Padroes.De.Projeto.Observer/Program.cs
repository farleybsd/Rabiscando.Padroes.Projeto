using Com.Padroes.De.Projeto.Observer.Assinantes;
using Com.Padroes.De.Projeto.Observer.Assunto;

//Criação da Newsletter (Subject);
var newsletter = new Newsletter();

//Criação de funcionários
var funcionario1 = new Funcionario("Funcionario 1", "funcionario1@email.com", newsletter);
var funcionario2 = new Funcionario("Funcionario 2", "funcionario2@email.com", newsletter);

//Criação de clientes
var cliente = new Cliente("Cliente 1", "cliente1@email.com", newsletter);
//Criação de parceiros
var parceiro = new Parceiro("Parceiro 1", "parceiro1@email.com", newsletter);
//Criação de fornecedor
var fornecedor = new Fornecedor("Fornecedor 1", "fornecedor1@email.com", newsletter);

// Criacao de Assunto
var list = new List<string>() { "Primeira Mensagem", "Segunda Mensagem", "Terceia Mensagem" };

foreach (var item in list)
{
    newsletter.addMensagem(item);
}

newsletter.registerObserver(funcionario1);
newsletter.registerObserver(funcionario2);
newsletter.registerObserver(cliente);
newsletter.registerObserver(parceiro);
newsletter.registerObserver(fornecedor);

newsletter.notifyObservers();
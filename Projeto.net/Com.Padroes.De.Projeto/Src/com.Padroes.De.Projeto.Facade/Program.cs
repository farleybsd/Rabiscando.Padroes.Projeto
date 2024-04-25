// Ultizado quando o metodo tem mt  referencia de interface ou objetos 
// Usando o Facede para Encapsular isso nesse caso o nosso facede e  VendaFacade

//Criação do consumidor.
using com.Padroes.De.Projeto.Facade;
using com.Padroes.De.Projeto.Facade.Vendas;

var consumidor = new Consumidor("Luiz da Silva", "12345678910", "luiz@email.com");
//Criação de produtos.
var produto1 = new Produto("Blusa Rosa", "Blusa feminina rosa", (float)80.99);
var produto2 = new Produto("Camiseta Preta", "Camiseta masculina preta", (float)49.90);
var produto3 = new Produto("Calça Jeans", "Calça Jeans Masculina", (float)119.90);
// ==== Até aqui apenas criamos os objetos básicos que uma venda precisa. ====
// ==== Agora vamos ao processo de venda propriamente dito. ====
//Criação do Pedido.
var pedido = new Pedido(consumidor);
//Adição dos produtos ao pedido.
pedido.AddProduto(produto1);
pedido.AddProduto(produto2);
pedido.AddProduto(produto3);
//Pagamento com boleto.
var pagamento = new PagamentoBoleto(pedido);
var email = new EmailPedido(pedido);
if (pagamento.realizarPagamento())
{
    email.enviarEmail("Pagamento realizado com sucesso via boleto");
}
else
{
    email.enviarEmail("Falha no pagamento do boleto");
}
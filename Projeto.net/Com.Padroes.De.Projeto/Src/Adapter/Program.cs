/*
 * Adapter
 * 
 * O padrão Adapter converte a interface de uma classe para outra
 * interface que o cliente espera encontrar. O Adaptador permite que classes
 * com interfaces incompatíveis trabalhem juntas.
 */

/*
Para tornar essa explicação mais ilustrativa, suponha que trabalhamos
na empresa FreteExpress, ela possui um serviço de agendamento de fretes
por um aplicativo, e faz a cobrança de seus clientes antecipadamente por
um gateway de pagamentos.
*/

/*
Os serviços da PagFácil têm sido utilizados desde a fundação da
FreteExpress, porém surgiu um novo fornecedor no mercado, a TopPagamentos.
Ele cobra uma taxa fixa maior que a PagFácil por cada pagamento, porém
cobra juros menores por parcelamentos no cartão de crédito.
*/

//==== Classes dos fornecedores ====
//E uma instância da classe de TopPagamentos.
using Adapter;
using Adapter.Adaptadores;
using Adapter.Terceiros;

var topPagamentos = new TopPagamentos();
var pagFacil = new PagFacil();
//==== Adapters ====
//Criação do adaptador de PagFacil.
var pagFacilAdapter = new PagFacilAdapter(pagFacil);
//Criação do adaptador de TopPagamentos.
var topPagamentosAdapter = new TopPagamentosAdapter(topPagamentos);
//==== Cobranca ====
Console.WriteLine("Cobrança utilizando PagFacil como Gateway");
//Criação de uma Cobrança utilidando a classe PagFacil.
//Repare que o adaptador de $pagFacil é passado para o construtor.
var cobranca = new Cobranca(pagFacilAdapter);
cobranca.setValor(100);
cobranca.setParcelas(3);
cobranca.setNumeroDoCartao("1234123412341234");
cobranca.setCVV("123");
if (cobranca.realizarPagamento()) {
    Console.WriteLine("Pagamento Realizado com sucesso");
} else
{
    Console.WriteLine("O pagamento falhou");
}
// Cobrança utilidando a classe PagFacil.
Console.WriteLine("Cobrança utilizando TopPagamentos como Gateway <br>");
//Troca do Gateway de Cobrança para TopPagamentos
cobranca.setGateway(topPagamentosAdapter);
cobranca.setValor(100);
cobranca.setParcelas(3);
cobranca.setNumeroDoCartao("1234123412341234");
cobranca.setCVV("123");
if (cobranca.realizarPagamento()) {
    Console.WriteLine("Pagamento Realizado com sucesso");
} else
{
    Console.WriteLine("O pagamento falhou");
}
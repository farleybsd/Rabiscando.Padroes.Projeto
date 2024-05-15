
/*
 * O padrão Chain of Responsibility permite que múltiplos
 * objetos possam lidar com uma solicitação de forma encadeada.
 * Cada objeto na cadeia decide se processa a solicitação
 * ou a passa para o próximo na cadeia. Isso promove o desacoplamento
 * entre remetente e receptor, facilitando a adição ou remoção dinâmica
 * de responsabilidades.
 */
//Neste exemplo, temos três validadores que representam diferentes etapas de validação de uma compra em um mercado:
//AgeValidator, InventoryValidator, e PaymentValidator. Cada validador verifica uma condição específica do pedido e decide
//se o pedido passa ou é rejeitado. O método Main configura a cadeia de validadores e envia um pedido para ser validado.
//Se todas as condições forem atendidas, o pedido é aprovado e a compra é processada.
using Com.Padroes.De.Projeto.ChainofResponsibility._3.ConcreteValidadores;
using Com.Padroes.De.Projeto.ChainofResponsibility.Entidade;
using Com.Padroes.De.Projeto.ChainofResponsibility.Enums;

// Configurando a cadeia de validadores
var ageValidator = new AgeValidator();
var inventoryValidator = new InventoryValidator();
var paymentValidator = new PaymentValidator();

ageValidator.SetNextValidator(inventoryValidator);
inventoryValidator.SetNextValidator(paymentValidator);

// Criando um pedido
var order = new Order
{
    ProductName = "Maçãs",
    ProductStock = 100,
    Quantity = 10,
    CustomerAge = 25,
    PaymentMethod = PaymentMethod.DebitCard
};

// Validando o pedido
bool isValid = ageValidator.Validate(order);

if (isValid)
{
    Console.WriteLine("Pedido aprovado! Processando compra...");
    // Lógica para processar a compra
}
else
{
    Console.WriteLine("Pedido não aprovado. Não é possível processar a compra.");
}

Console.ReadKey();
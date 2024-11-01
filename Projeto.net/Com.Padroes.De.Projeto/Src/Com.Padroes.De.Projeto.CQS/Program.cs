/*
O CQS (Command Query Separation) é um princípio que separa comandos e consultas para que cada método execute apenas uma dessas responsabilidades. Os comandos modificam o estado da aplicação, enquanto as consultas apenas retornam informações, sem alterar o estado. Vou mostrar um exemplo simples de aplicação do padrão CQS em C#.

Estrutura do Projeto
    Para aplicar CQS, criaremos duas camadas principais:

Comandos (Commands) : Responsáveis por executar operações que alteram o estado do sistema, como adicionar, atualizar ou excluir dados.
    Consultas (Queries) : Responsáveis por buscar informações do sistema sem alterar seu estado.
    Exemplo de código
    Imagine que estamos trabalhando com uma entidade Clientee queremos implementar o CQS para operações básicas.

*/

using Com.Padroes.De.Projeto.CQS.Application.Commands.CreateCliente;
using Com.Padroes.De.Projeto.CQS.Application.Common;
using Com.Padroes.De.Projeto.CQS.Application.Queries;
using Com.Padroes.De.Projeto.CQS.Application.Queries.Handler;
using Com.Padroes.De.Projeto.CQS.Domain.Repositories;
using Com.Padroes.De.Projeto.CQS.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

// Configuração de injeção de dependência
var services = new ServiceCollection();

ConfigureServices(services);

var provider = services.BuildServiceProvider();

// Obter instâncias e executar comandos e consultas
var createCommand = new CreateClienteCommand { Nome = "João Silva", Email = "joao@example.com" };
var createHandler = provider.GetRequiredService<ICreateClienteCommandHandler>();
var createResult = createHandler.Handle(createCommand);

Console.WriteLine(createResult.Message);

var getQuery = new GetClienteByIdQuery(1);
var getHandler = provider.GetRequiredService<IGetClienteByIdQueryHandler>();
var cliente = getHandler.Handle(getQuery);

if (cliente != null)
{
    Console.WriteLine($"Cliente encontrado: {cliente.Nome} - {cliente.Email}");
}


void ConfigureServices(ServiceCollection services)
{
    // Registro de dependências
    services.AddSingleton<IClienteRepository, ClienteRepository>();
    services.AddTransient<ICreateClienteCommandHandler, CreateClienteCommandHandler>();
    services.AddTransient<IGetClienteByIdQueryHandler, GetClienteByIdQueryHandler>();
    services.AddTransient<IValidator, Validator>(); 

}
using Com.Padroes.De.Projeto.CQS.Application.Common;
using Com.Padroes.De.Projeto.CQS.Domain.Entities;
using Com.Padroes.De.Projeto.CQS.Domain.Repositories;

namespace Com.Padroes.De.Projeto.CQS.Application.Commands.CreateCliente;

public class CreateClienteCommandHandler : ICreateClienteCommandHandler
{
    private readonly IClienteRepository _clienteRepository;
    private readonly IValidator  _validator;

    public CreateClienteCommandHandler(IClienteRepository clienteRepository,IValidator validator)
    {
        _clienteRepository = clienteRepository;
        _validator = validator;
    }
    
    public CommandResult Handle(CreateClienteCommand command)
    {
        if (!_validator.Validate(command)) 
            return new CommandResult(false, "Dados inválidos");

        var cliente = new Cliente
        {
            Nome = command.Nome,
            Email = command.Email
        };

        _clienteRepository.Add(cliente);

        return new CommandResult(true, "Cliente criado com sucesso");
    }
}
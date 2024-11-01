namespace Com.Padroes.De.Projeto.CQS.Application.Commands.CreateCliente;

public interface ICreateClienteCommandHandler
{
    CommandResult Handle(CreateClienteCommand command);
}
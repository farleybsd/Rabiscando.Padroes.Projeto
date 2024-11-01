using Com.Padroes.De.Projeto.CQS.Application.Commands.CreateCliente;

namespace Com.Padroes.De.Projeto.CQS.Application.Common;

public class Validator : IValidator
{
    public bool Validate(CreateClienteCommand command)
    {
        return !string.IsNullOrEmpty(command.Nome) && !string.IsNullOrEmpty(command.Email);
    }
}
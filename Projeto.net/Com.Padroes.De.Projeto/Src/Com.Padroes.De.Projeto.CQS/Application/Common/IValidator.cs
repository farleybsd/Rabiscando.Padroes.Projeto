using Com.Padroes.De.Projeto.CQS.Application.Commands.CreateCliente;

namespace Com.Padroes.De.Projeto.CQS.Application.Common;

public interface IValidator
{
    bool Validate(CreateClienteCommand command);
}
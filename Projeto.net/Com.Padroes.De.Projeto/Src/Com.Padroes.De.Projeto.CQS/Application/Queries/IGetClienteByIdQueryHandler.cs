using Com.Padroes.De.Projeto.CQS.Domain.Entities;

namespace Com.Padroes.De.Projeto.CQS.Application.Queries;

public interface IGetClienteByIdQueryHandler
{
    Cliente Handle(GetClienteByIdQuery query);
}
using Com.Padroes.De.Projeto.CQS.Domain.Entities;
using Com.Padroes.De.Projeto.CQS.Domain.Repositories;

namespace Com.Padroes.De.Projeto.CQS.Application.Queries.Handler;

public class GetClienteByIdQueryHandler : IGetClienteByIdQueryHandler
{
    private readonly IClienteRepository _clienteRepository;

    public GetClienteByIdQueryHandler(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository; 
    }
    
    public Cliente Handle(GetClienteByIdQuery query)
    {
        return _clienteRepository.GetById(query.Id);
    }
}
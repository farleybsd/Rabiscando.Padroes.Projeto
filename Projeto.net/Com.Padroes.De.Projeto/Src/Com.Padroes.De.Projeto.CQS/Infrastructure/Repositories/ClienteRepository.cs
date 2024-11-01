using Com.Padroes.De.Projeto.CQS.Domain.Entities;
using Com.Padroes.De.Projeto.CQS.Domain.Repositories;

namespace Com.Padroes.De.Projeto.CQS.Infrastructure.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly List<Cliente> _clientes = new();
    
    public void Add(Cliente cliente)
    {
        cliente.Id = _clientes.Count + 1;
        _clientes.Add(cliente);
    }

    public Cliente GetById(int id)
    {
       return _clientes.First(c => c.Id == id); 
    }
}
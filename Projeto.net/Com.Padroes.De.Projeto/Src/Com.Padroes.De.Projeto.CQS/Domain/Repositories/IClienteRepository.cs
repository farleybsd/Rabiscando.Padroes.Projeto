using Com.Padroes.De.Projeto.CQS.Domain.Entities;

namespace Com.Padroes.De.Projeto.CQS.Domain.Repositories;

public interface IClienteRepository
{
    void Add(Cliente cliente);
    Cliente GetById(int id);
}
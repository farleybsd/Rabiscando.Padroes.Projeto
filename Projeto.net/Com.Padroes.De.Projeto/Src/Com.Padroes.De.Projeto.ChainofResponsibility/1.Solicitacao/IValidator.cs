using Com.Padroes.De.Projeto.ChainofResponsibility.Entidade;

namespace Com.Padroes.De.Projeto.ChainofResponsibility.Solicitacao
{
    // Interface para definir o comportamento de manipulação de solicitações
    public interface IValidator
    {
        void SetNextValidator(IValidator validator);
        bool Validate(Order order);
    }
}

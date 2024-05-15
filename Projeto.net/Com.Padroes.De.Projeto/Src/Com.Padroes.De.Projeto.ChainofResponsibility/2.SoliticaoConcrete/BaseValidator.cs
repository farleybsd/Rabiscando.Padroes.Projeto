using Com.Padroes.De.Projeto.ChainofResponsibility.Entidade;
using Com.Padroes.De.Projeto.ChainofResponsibility.Solicitacao;

namespace Com.Padroes.De.Projeto.ChainofResponsibility._2.SoliticaoConcrete
{
    // Implementação base do validador
    public abstract class BaseValidator : IValidator
    {
        private  IValidator _nextValidator;
        public void SetNextValidator(IValidator validator)
        {
            _nextValidator = validator;
        }

        //Este é o método Validate que é chamado em cada validador.
        //Ele recebe um objeto Order como parâmetro, que representa
        //o pedido a ser validado. O modificador virtual indica que
        //este método pode ser substituído em classes derivadas.
        public virtual bool Validate(Order order)
        {
            //Aqui, estamos verificando se existe um próximo validador na cadeia.
            //Se _nextValidator não for null, significa que há um próximo validador
            //na cadeia e devemos passar o pedido para ele.
            if (_nextValidator != null)
            {
                //Se houver um próximo validador, o método Validate desse validador
                //é chamado recursivamente, passando o mesmo objeto Order.
                //Essa recursão continua até que não haja mais validadores na cadeia para processar o pedido.
                return _nextValidator.Validate(order);
            }
            else
            {
                //Se não houver um próximo validador na cadeia, significa que este é o último validador e não há mais etapas de validação a serem realizadas.
                Console.WriteLine("Nenhum validador disponível para processar o pedido.");
                //Como este é o último validador na cadeia e não há mais etapas de validação,
                //ele retorna true, indicando que o pedido passou por todas as etapas de validação com sucesso.
                return true;
            }
        }
    }
}

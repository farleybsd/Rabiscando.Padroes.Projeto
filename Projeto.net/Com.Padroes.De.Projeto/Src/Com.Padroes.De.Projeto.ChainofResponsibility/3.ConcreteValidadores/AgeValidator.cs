using Com.Padroes.De.Projeto.ChainofResponsibility._2.SoliticaoConcrete;
using Com.Padroes.De.Projeto.ChainofResponsibility.Entidade;

namespace Com.Padroes.De.Projeto.ChainofResponsibility._3.ConcreteValidadores
{
    // Implementações específicas de validadores
    public class AgeValidator : BaseValidator
    {
        public override bool Validate(Order order)
        {
            if (order.CustomerAge >= 18)
            {
                Console.WriteLine("Validação de idade aprovada.");
                return base.Validate(order);
            }
            else
            {
                Console.WriteLine("Você deve ser maior de idade para fazer compras.");
                return false;
            }
        }
    }
}

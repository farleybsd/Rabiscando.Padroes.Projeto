using Com.Padroes.De.Projeto.ChainofResponsibility._2.SoliticaoConcrete;
using Com.Padroes.De.Projeto.ChainofResponsibility.Entidade;
using Com.Padroes.De.Projeto.ChainofResponsibility.Enums;

namespace Com.Padroes.De.Projeto.ChainofResponsibility._3.ConcreteValidadores
{
    public class PaymentValidator : BaseValidator
    {
        public override bool Validate(Order order)
        {
            if (order.PaymentMethod == PaymentMethod.CreditCard || order.PaymentMethod == PaymentMethod.DebitCard)
            {
                Console.WriteLine("Validação de método de pagamento aprovada.");
                return base.Validate(order);
            }
            else
            {
                Console.WriteLine("Método de pagamento não suportado.");
                return false;
            }
        }
    }
}

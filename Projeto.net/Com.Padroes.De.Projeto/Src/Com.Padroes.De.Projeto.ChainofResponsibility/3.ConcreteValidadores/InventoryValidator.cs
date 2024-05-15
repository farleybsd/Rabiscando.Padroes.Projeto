using Com.Padroes.De.Projeto.ChainofResponsibility._2.SoliticaoConcrete;
using Com.Padroes.De.Projeto.ChainofResponsibility.Entidade;

namespace Com.Padroes.De.Projeto.ChainofResponsibility._3.ConcreteValidadores
{
    public class InventoryValidator : BaseValidator //Validador de Inventário
    {
        public override bool Validate(Order order)
        {
            if (order.ProductStock >= order.Quantity)
            {
                Console.WriteLine("Validação de estoque aprovada.");
                return base.Validate(order);
            }
            else
            {
                Console.WriteLine("Quantidade solicitada não disponível no estoque.");
                return false;
            }
        }
    }
}

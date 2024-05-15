using Com.Padroes.De.Projeto.ChainofResponsibility.Enums;

namespace Com.Padroes.De.Projeto.ChainofResponsibility.Entidade
{
    public class Order
    {
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public int Quantity { get; set; }
        public int CustomerAge { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}

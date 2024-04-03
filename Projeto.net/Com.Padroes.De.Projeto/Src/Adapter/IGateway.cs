/*
 *  Vamos criar uma interface para intermediar a relação entre a classe
 *  cobrança e as classes dos gateways de pagamentos
 */
namespace Adapter
{
    public interface IGateway
    {
        public void setValor(float valor);
        public void setParcelas(int parcelas);
        public void setNumeroCartao(string numeroCartao);
        public void setCVV(string cvV);
        public bool ValidarCartao();
        public bool realizarPagamento();
    }
}

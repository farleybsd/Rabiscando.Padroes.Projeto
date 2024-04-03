/*
  Uma vez que a interface for criada, precisamos agora adaptar a classe
  Cobranca. Agora ela deve receber em seu construtor um objeto do tipo Gateway
  ao invés de um do tipo PagFacil. Todo o processamento de pagamentos é
  delegado a esse objeto recebido
*/

using System.Reflection.Metadata.Ecma335;

namespace Adapter
{
    public class Cobranca
    {
        //Recebe e mantém referência a um objeto do tipo Gateway.
        private  IGateway _gateway;

        public Cobranca(IGateway Gateway)
        {
            _gateway = Gateway;
        }

        //Recebe e mantém referência a um objeto do tipo Gateway.

        //Recebe e mantém referência a um objeto do tipo Gateway.
        public void setGateway(IGateway gateway)
        {
            _gateway = gateway;
        }

        public void setValor(float valor)
        {
            _gateway.setValor(valor);
        }

        public void setParcelas(int parcelas)
        {
            _gateway.setParcelas(parcelas);
        }

        public void setNumeroDoCartao(string numeroDoCartao)
        {
            _gateway.setNumeroCartao(numeroDoCartao);
        }

        public void setCVV(string cvv)
        {
            _gateway.setCVV(cvv);
        }

        public bool realizarPagamento()
        {
            //Verifica se cartão é válido
            if (_gateway.ValidarCartao())
            {
                //Verifica se cartão é válido
                return _gateway.realizarPagamento();
            }
            return false;
        }
    }
}

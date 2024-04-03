using Adapter.Terceiros;

namespace Adapter.Adaptadores
{
    public class TopPagamentosAdapter : IGateway
    {
        private TopPagamentos _topPagamentos;

        public TopPagamentosAdapter(TopPagamentos topPagamentos)
        {
            _topPagamentos = topPagamentos;
        }
        public bool realizarPagamento()
        {
            return _topPagamentos.realizarPagamento();
        }

        public void setCVV(string cvV)
        {
            _topPagamentos.setCVV(cvV);
        }

        public void setNumeroCartao(string numeroCartao)
        {
            _topPagamentos.setNumeroDeCartao(numeroCartao);
        }

        public void setParcelas(int parcelas)
        {
            _topPagamentos.setParcelas(parcelas);
        }

        public void setValor(float valor)
        {
            _topPagamentos.setValor(valor);
        }

        public bool ValidarCartao()
        {
            return true;
        }
    }
}

using Adapter.Terceiros;

namespace Adapter.Adaptadores
{
    public class PagFacilAdapter : IGateway
    {
        private PagFacil _pagFacil;

        public PagFacilAdapter(PagFacil pagFacil)
        {
            _pagFacil = pagFacil;
        }
        public PagFacilAdapter()
        {
            
        }

        public bool realizarPagamento()
        {
           return _pagFacil.realizarPagamento();
        }

        public void setCVV(string cvV)
        {
            _pagFacil.setCVV(cvV);
        }

        public void setNumeroCartao(string numeroCartao)
        {
           _pagFacil.setNumeroDeCartao(numeroCartao);  
        }

        public void setParcelas(int parcelas)
        {
            _pagFacil.setParcelas(parcelas);
        }

        public void setValor(float valor)
        {
            _pagFacil.setValor(valor);
        }

        public bool ValidarCartao()
        {
            return true;
        }
    }
}

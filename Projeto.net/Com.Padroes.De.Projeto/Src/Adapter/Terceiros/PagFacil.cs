namespace Adapter.Terceiros
{
    public class PagFacil
    {
        private float _valor;
        private int _parcelas;
        private string _numeroCartao;
        private string _cvv;

        public void setValor(float valor)
        {
            _valor = valor;
        }

        public void setParcelas(int parcelas)
        {
            _parcelas = parcelas;
        }

        public void setNumeroDeCartao(string numeroCartao)
        {
            _numeroCartao = numeroCartao;   
        }

        public void setCVV(string cvv)
        {
            _cvv = cvv;
        }

        public bool ValidarCartao()
        {
            if(_numeroCartao != "" && _cvv !="" && _cvv.Length == 3) 
            {
                return true;
            }
            return false;
        }

        public bool realizarPagamento()
        {
            Console.WriteLine($"Pagamento realizado via PagFacil");
            return true;
        }
    }
}

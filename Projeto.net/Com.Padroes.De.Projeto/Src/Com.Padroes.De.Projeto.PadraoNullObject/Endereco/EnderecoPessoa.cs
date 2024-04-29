namespace Com.Padroes.De.Projeto.PadraoNullObject.Endereco
{
    public class EnderecoPessoa : IEndereco
    {
        private string _rua;
        private string _cep;

        public EnderecoPessoa(string rua, string cep)
        {
            _rua = rua;
            _cep = cep;
        }

        public string GetRua()
        {
            return _rua;
        }

        public string GetCep()
        {
            return _cep;
        }
    }
}

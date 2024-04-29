namespace Com.Padroes.De.Projeto.PadraoNullObject.Endereco
{
    public class EnderecoNull :  IEndereco
    {
        public string GetRua()
        {
            return "Endereço não especificado";
        }

        public string GetCep()
        {
            return "CEP não especificado";
        }
    }
}

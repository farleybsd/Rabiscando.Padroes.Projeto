using Com.Padroes.De.Projeto.PadraoNullObject.Endereco;

namespace Com.Padroes.De.Projeto.PadraoNullObject.pessoa
{
    public class PessoaFactory
    {
        public static Pessoa criarPessoa(string nome, IEndereco endereco)
        {

            if (endereco == null)
            {
                var endereconaoinformado = new EnderecoNull();
                var pessoasemindereco = new Pessoa(nome, endereconaoinformado);
                return pessoasemindereco;
            }
            else
            {
                var pessoacomEndereco = new Pessoa(nome, endereco);
                return pessoacomEndereco;
            }

        }
    }
}

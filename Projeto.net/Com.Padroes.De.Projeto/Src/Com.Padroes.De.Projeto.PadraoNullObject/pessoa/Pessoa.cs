using Com.Padroes.De.Projeto.PadraoNullObject.Endereco;

namespace Com.Padroes.De.Projeto.PadraoNullObject.pessoa
{
    public class Pessoa
    {
        private string _nome;
        private IEndereco _endereco;

        public Pessoa(string nome, IEndereco endereco)
        {
            _nome = nome;
            _endereco = endereco;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Nome: {_nome}");
            Console.WriteLine($"Rua: {_endereco.GetRua()}");
            Console.WriteLine($"CEP: {_endereco.GetCep()}");
        }
    }
}

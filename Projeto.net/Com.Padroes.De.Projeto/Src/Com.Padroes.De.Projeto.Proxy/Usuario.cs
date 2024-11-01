namespace Com.Padroes.De.Projeto.Proxy
{
    public class Usuario
    {
        private string nome;
        private string cpf;
        private int idade;
        private PessoaFisicaReceitaFederal pessoaFisica;

        public Usuario(string nome, string cpf, int idade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            // Aqui é inicializada uma instância da classe PessoaFisicaReceitaFederal.
            this.pessoaFisica = new PessoaFisicaReceitaFederal(cpf);
        }

        // Compara o nome informado pelo usuário e o nome na receita federal (RF).
        public bool ValidarNome()
        {
            return this.nome == this.pessoaFisica.GetNome();
        }

        // Verifica se o CPF se encontra ativo na RF.
        public bool VerificaCPFAtivo()
        {
            return this.pessoaFisica.CPFAtivo();
        }

        // Verifica se a idade é maior ou igual a 18 anos e a compara com a idade na RF.
        public bool VerificarMaioridade()
        {
            return this.idade >= 18 && this.idade == this.pessoaFisica.GetIdade();
        }

        // Retorna o nome do usuário.
        public string GetNome()
        {
            return this.nome;
        }

        // Retorna o CPF do usuário.
        public string GetCpf()
        {
            return this.cpf;
        }

        // Retorna a idade do usuário.
        public int GetIdade()
        {
            return this.idade;
        }
    }

}

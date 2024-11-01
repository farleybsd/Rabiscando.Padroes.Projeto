namespace Com.Padroes.De.Projeto.Proxy
{
    public class PessoaFisicaReceitaFederal
    {
        private string nome;
        private string cpf;
        private int idade;
        private bool cpfAtivo;

        public PessoaFisicaReceitaFederal(string cpf)
        {
            this.cpf = cpf;
            this.nome = "João da Silva"; // Simulação de dado encontrado com base no CPF
            this.idade = 25; // Simulação de dado encontrado com base no CPF
            this.cpfAtivo = true; // Simulação de dado encontrado com base no CPF
            Thread.Sleep(5000); // Simulação do tempo de resposta da requisição à API
            Console.WriteLine("PessoaFisicaReceitaFederal criada com sucesso");
        }

        public string GetNome()
        {
            Thread.Sleep(2000); // Simulação do tempo de resposta da requisição à API
            return nome;
        }

        public int GetIdade()
        {
            Thread.Sleep(2000); // Simulação do tempo de resposta da requisição à API
            return idade;
        }

        public bool CPFAtivo()
        {
            Thread.Sleep(3000); // Simulação do tempo de resposta da requisição à API
            return cpfAtivo;
        }

    }
}

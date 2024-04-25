namespace com.Padroes.De.Projeto.Facade
{
    public class Consumidor
    {
        public Consumidor(string nome, string cpf, string email)
        {
            _Nome = nome;
            _Cpf = cpf;
            _Email = email;
        }

        public string _Nome { get; private set; }
        public string _Cpf { get; private set; }
        public string _Email { get; private set; }

        public string getNome()
        {
            return _Nome;
        }
        public string getCpf()
        {
            return _Cpf;
        }

        public string getEmail()
        {
            return _Email;
        }
    }
}

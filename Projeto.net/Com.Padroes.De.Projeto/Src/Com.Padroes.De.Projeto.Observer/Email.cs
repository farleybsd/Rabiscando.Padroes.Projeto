using Com.Padroes.De.Projeto.Observer.Observador;

namespace Com.Padroes.De.Projeto.Observer
{
    public  class EmailService
    {
        public static void EnviarEmail(IObserver observer, string mensagem)
        {
            Console.WriteLine($"---------------------------------------------{Environment.NewLine}");
            Console.WriteLine($"Email enviado para {observer.getNome()} - {observer.getEmail()} {Environment.NewLine} ");
            Console.WriteLine($"Mensagem {mensagem}");
        }
    }
}

namespace Com.Padroes.De.Projeto.Bridge.Canais_de_envio
{
    public class Email : CanalDeEnvioInterface
    {
        //Apenas simula o envio de uma mensagem por email.
        public void enviarMensagem(string assunto, string mesagem)
        {
            Console.WriteLine("=== Mensagem Enviada por E-MAIL ===");
            Console.WriteLine($"Assunto {assunto}");
            Console.WriteLine($"Mensagem {mesagem}");
        }
    }
}

namespace Com.Padroes.De.Projeto.Bridge.Dominio
{
    public class MensagemUsuario : Mensagem
    {
        public MensagemUsuario(CanalDeEnvioInterface canal) : base(canal)
        {
        }

        //Simula o envio de uma mensagem feita por um Administrador
        public override void Enviar()
        {
            Console.WriteLine("'Mensagem enviada pelo USUÁRIO");
            _CANAL.enviarMensagem(Asssunto, Mesagem);
        }
    }
}

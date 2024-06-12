
namespace Com.Padroes.De.Projeto.Bridge.Dominio
{
    public class MensagemAdmin : Mensagem
    {
        public MensagemAdmin(CanalDeEnvioInterface canal) : base(canal)
        {
        }

        //Simula o envio de uma mensagem feita por um Administrador
        public override void Enviar()
        {
            Console.WriteLine("'Mensagem enviada pelo ADMINISTRADOR");
            _CANAL.enviarMensagem(Asssunto, Mesagem);
        }
    }
}

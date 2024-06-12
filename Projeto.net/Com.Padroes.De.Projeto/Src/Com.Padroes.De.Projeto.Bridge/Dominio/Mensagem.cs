namespace Com.Padroes.De.Projeto.Bridge.Dominio
{
    public abstract class Mensagem
    {
        protected CanalDeEnvioInterface _CANAL;
        protected string Asssunto;
        protected string Mesagem;

        //Recebe um CanalDeEnvioInterface em seu construtor e mantêm referência el
        protected Mensagem(CanalDeEnvioInterface canal)
        {
            _CANAL = canal;
        }

        //Define o assunto
        public void setAssunto(string assunto) { 
            Asssunto = assunto;
        }

        //Define a mensagem
        public void setMensagem(string mensagem)
        {
            Mesagem = mensagem;
        }

        //Método abstrato que será implementado pelas subclasses de mensagem.

        public abstract void Enviar();
    }
}

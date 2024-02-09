using Com.Padroes.De.Projeto.Observer.Notificador;
using Com.Padroes.De.Projeto.Observer.Observador;
using System.IO;
using System;

namespace Com.Padroes.De.Projeto.Observer.Assunto
{
    public class Newsletter : ISubject
    {

        public List<IObserver> ListObserver { get; private set; } = new List<IObserver>();
        public List<string> Mensagens { get; private set; } = new List<string>();

        //Notifica todos os observer sobre a nova mensagem da newsletter.
        public void notifyObservers()
        {
            foreach (var item in ListObserver)
            {
                var ultimaMensagem = Mensagens.LastOrDefault();
                item.Update(ultimaMensagem);
            }
        }

        /*Adiciona um objeto a lista de observers a serem notificados
        quando uma nova mensagem for inserida na newsletter. */
        public void registerObserver(IObserver observer)
        {
            ListObserver.Add(observer);
        }
        /*Remove um objeto a lista de observers a serem notificados
          quando uma nova mensagem for inserida na newsletter. */
        public void removeObserver(IObserver observer)
        {
            foreach (var Key in ListObserver)
            {
                if (Key == observer)
                {
                    ListObserver.Remove(Key);
                }
            }
        }

        /*Adiciona uma nova mensagem a newsletter e solicita que todos
          os observers sejam notificados */
        public void addMensagem(string mensag)
        {
            Mensagens.Add(mensag);
            notifyObservers();
        }
    }
}

using Com.Padroes.De.Projeto.Observer.Observador;
using System;

namespace Com.Padroes.De.Projeto.Observer.Notificador
{
    public interface ISubject
    {
        void registerObserver(IObserver observer);
        void removeObserver(IObserver observer);
        void notifyObservers();

    }
}

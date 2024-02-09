﻿using Com.Padroes.De.Projeto.Observer.Notificador;
using Com.Padroes.De.Projeto.Observer.Observador;

namespace Com.Padroes.De.Projeto.Observer.Assinantes
{
    public class Cliente : IObserver
    {
        //O subject é recebido por parâmetro para que o cliente tenha acesso a ele.
        public Cliente(string nome, string email, ISubject subject)
        {
            Nome = nome;
            Email = email;
            this.subject = subject;
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public ISubject subject { get; private set; }

        public string getEmail()
        {
            return Email;
        }

        public string getNome()
        {
            return Nome;
        }

        public void Update(string mensagem) //Faz o envio da mensagem para o email.
        {
            EmailService.EnviarEmail(this, mensagem);
        }
    }
}

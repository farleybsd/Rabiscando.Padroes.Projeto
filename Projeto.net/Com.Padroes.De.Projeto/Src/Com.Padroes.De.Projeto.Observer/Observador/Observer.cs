/*
 * Na interface acima apenas o método update() é parte do padrão
 * observer, os métodos getNome() e getEmail() fazem parte do contexto do
 *  problema
 */

namespace Com.Padroes.De.Projeto.Observer.Observador
{
    public interface IObserver
    {
        void Update(string mensagem);
        string getNome();
        string getEmail();
    }
}

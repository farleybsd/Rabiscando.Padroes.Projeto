using Com.Padroes.De.Projeto.AbstractFactory.Supertipos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Com.Padroes.De.Projeto.AbstractFactory._3.Fabrica
{
    public interface ICalculosFactory
    {
        //Uma classe fábrica deve ter um método para criar um objeto correto de cada tipo.
        IJuros criarJuros();  //Cria um objeto do tipo Juros.
        IDesconto criarDesconto();  //Cria um objeto do tipo Desconto.
        IMulta criarMulta(); //Cria um objeto do tipo Multa.
    }
}

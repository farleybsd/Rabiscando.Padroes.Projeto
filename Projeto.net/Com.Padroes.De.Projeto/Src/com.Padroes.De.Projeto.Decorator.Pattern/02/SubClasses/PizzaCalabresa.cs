using com.Padroes.De.Projeto.Decorator.Pattern._01;

namespace com.Padroes.De.Projeto.Decorator.Pattern._02.SubClasses
{
    /*
     * Agora que já temos a classe pizza podemos criar as subclasses
         => PizzaFrango, 
         => PizzaCalabresa 
         =>  PizzaQueijo.
     */
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa()
        {
            //Adicionamos uma descrição para Pizza de Calabresa;
            descricao = "Deliciosa Pizza De Calabresa";
        }

        //Implementação de getDescricao feita por PizzaCalabresa.
        public override string getDescricao()
        {
            return descricao;
        }

        //Implementação de getPreco feita por PizzaCalabresa
        public override float getPreco()
        {
            return 25;
        }
    }
}

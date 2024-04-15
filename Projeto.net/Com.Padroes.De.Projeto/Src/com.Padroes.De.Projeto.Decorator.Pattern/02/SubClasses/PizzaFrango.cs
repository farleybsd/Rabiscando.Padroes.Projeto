using com.Padroes.De.Projeto.Decorator.Pattern._01;

namespace com.Padroes.De.Projeto.Decorator.Pattern._02.SubClasses
{
    /*
     * Agora que já temos a classe pizza podemos criar as subclasses
         => PizzaFrango, 
         => PizzaCalabresa 
         =>  PizzaQueijo.
     */
    public class PizzaFrango : Pizza
    {
        public PizzaFrango()
        {
            //Adicionamos uma descrição para pizza de frango;
            descricao = "Deliciosa pizza de frango";
        }

        //Implementação de getDescricao feita por PizzaFrango.
        public override string getDescricao()
        {
            return descricao;
        }

        //Implementação de getPreco feita por PizzaFrango
        public override float getPreco()
        {
            return 19;
        }
    }
}

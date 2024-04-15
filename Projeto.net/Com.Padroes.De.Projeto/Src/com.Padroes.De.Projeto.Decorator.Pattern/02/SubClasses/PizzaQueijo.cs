using com.Padroes.De.Projeto.Decorator.Pattern._01;

namespace com.Padroes.De.Projeto.Decorator.Pattern._02.SubClasses
{
    /*
     * Agora que já temos a classe pizza podemos criar as subclasses
         => PizzaFrango, 
         => PizzaCalabresa 
         =>  PizzaQueijo.
     */
    public class PizzaQueijo : Pizza
    {
        public PizzaQueijo()
        {
            //Adicionamos uma descrição para Pizza de Queijo;
            descricao = "Deliciosa Pizza De Queijo";
        }

        //Implementação de getDescricao feita por PizzaQueijo.
        public override string getDescricao()
        {
            return descricao;
        }

        //Implementação de getPreco feita por PizzaQueijo
        public override float getPreco()
        {
            return 22;
        }
    }
}

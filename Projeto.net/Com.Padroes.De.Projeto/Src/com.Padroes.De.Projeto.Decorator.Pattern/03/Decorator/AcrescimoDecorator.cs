using com.Padroes.De.Projeto.Decorator.Pattern._01;

namespace com.Padroes.De.Projeto.Decorator.Pattern._03.Decorator
{
    /*
     * Sabendo que podem existir vários tipos de decorators vamos criar uma
     *  classe abstrata para eles também. Devemos lembrar que os decorators e
     *  objetos decorados por eles devem ter o mesmo supertipo então a classe
     *  abstrata AcrescimoDecorator também deve ser do tipo Pizza.
     * 
     */
    public abstract class AcrescimoDecorator : Pizza
    {
        protected Pizza _pizza;

        //O decorator precisa manter uma referência ao objeto decorado.
        public AcrescimoDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

    }
}

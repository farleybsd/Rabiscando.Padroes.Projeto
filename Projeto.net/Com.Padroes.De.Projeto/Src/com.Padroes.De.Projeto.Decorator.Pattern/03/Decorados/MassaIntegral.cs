using com.Padroes.De.Projeto.Decorator.Pattern._01;
using com.Padroes.De.Projeto.Decorator.Pattern._03.Decorator;

namespace com.Padroes.De.Projeto.Decorator.Pattern._03.Decorados
{
    public class MassaIntegral : AcrescimoDecorator
    {
        protected Pizza _pizza;
        public MassaIntegral(Pizza pizza) : base(pizza)
        {
            _pizza = pizza;
        }
        //Retorna a descrição de Pizza concatenada a descrição de MassaIntegral.
        public override string getDescricao()
        {
            return $"{_pizza.getDescricao()} + MassaIntegral ";
        }

        //Retorna o preço de Pizza somado ao preço de MassaIntegral.

        public override float getPreco()
        {
            return (float)(_pizza.getPreco() + 5);
        }
    }
}

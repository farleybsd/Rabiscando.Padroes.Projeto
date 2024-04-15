using com.Padroes.De.Projeto.Decorator.Pattern._01;
using com.Padroes.De.Projeto.Decorator.Pattern._03.Decorator;

namespace com.Padroes.De.Projeto.Decorator.Pattern._03.Decorados
{
    public class BordaRequeijao : AcrescimoDecorator
    {
        protected Pizza _pizza;
        public BordaRequeijao(Pizza pizza) : base(pizza)
        {
            _pizza = pizza; 
        }
        //Retorna a descrição de Pizza concatenada a descrição de BordaRequeijao.
        public override string getDescricao()
        {
            return $"{_pizza.getDescricao()} + Borda de Requeijao ";
        }

        //Retorna o preço de Pizza somado ao preço de BordaRequeijao.

        public override float getPreco()
        {
            return (float)(_pizza.getPreco() + 8.50);
        }
    }
}

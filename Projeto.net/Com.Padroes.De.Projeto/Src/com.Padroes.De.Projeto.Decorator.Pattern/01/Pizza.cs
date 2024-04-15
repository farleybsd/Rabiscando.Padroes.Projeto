namespace com.Padroes.De.Projeto.Decorator.Pattern._01
{
    /*
     * Para que a afirmação acima seja possível precisamos criar um
     *  supertipo, então, vamos começar pela classe abstrata Pizza.
     */
    public abstract class Pizza
    {
        protected string descricao = "Descrição não definida";

        protected float preco;

        //Todas as classes que herdam de pizza precisam implementar este método.
        abstract public string getDescricao();

        //Todas as classes que herdam de pizza precisam implementar este método.
        abstract public float getPreco();

    }
}

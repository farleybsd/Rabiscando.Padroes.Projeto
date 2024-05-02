using Com.Padroes.De.Projeto.FactoryMethod.ProdutoAbstrado;

namespace Com.Padroes.De.Projeto.FactoryMethod._3_FabricaAbstrada
{
    abstract public class Banco
    {
        public Boleto gerarBoleto(int vencimentoBoleto,float valor)
        {
            //Chama o método criarBoleto() que é abstrato, portanto será implementado apenas
            //Pelas subclasses de Banco.
            var boleto = criarBoleto(vencimentoBoleto,valor);
            Console.WriteLine($"Boleto gerado com sucesso no valor de R$ {valor}");
            Console.WriteLine($"Valor Juros: R${boleto.calcularJuros()}"); 
            Console.WriteLine($"Valor Desconto: R${boleto.calcularDesconto()}");            Console.WriteLine($"Valor Multa: R${boleto.calcularMulta()}");
            Console.WriteLine($"---------------"); 

            return boleto;
        }

        //Cada subclasse implementa o método criarBoleto criando seus respectivos objetos.
        protected abstract Boleto criarBoleto(int vencimentoBoleto, float valor);
    }
}

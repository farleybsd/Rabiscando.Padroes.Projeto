using Com.Padroes.De.Projeto.AbstractFactory._3.Fabrica.FabricaBB;
using Com.Padroes.De.Projeto.AbstractFactory._3.Fabrica.FabricaCaixa;

namespace Com.Padroes.De.Projeto.AbstractFactory._4.Cliente
{
    public class Banco
    {
        //O Banco recebe no método gerarBoleto() o valor do boleto a ser criado
        //e a fábrica que deve utilizar para criar os cálculos.

        public Boleto gerarBoletoBB(float valor)
        {
            var factory = new BBCalculosFactory();
            var boleto = new Boleto(valor, factory);
            Console.WriteLine($"Boleto gerado com sucesso no valor de R$ {valor}");
            Console.WriteLine($"Valor Juros: R${boleto.calcularJuros()}");
            Console.WriteLine($"Valor Desconto: R${boleto.calcularDesconto()}"); Console.WriteLine($"Valor Multa: R${boleto.calcularMulta()}");
            Console.WriteLine($"---------------");

            return boleto;
        }

        public Boleto gerarBoletoCaixa(float valor)
        {
            var factory = new CaixaCalculosFactory();
            var boleto = new Boleto(valor, factory);
            Console.WriteLine($"Boleto gerado com sucesso no valor de R$ {valor}");
            Console.WriteLine($"Valor Juros: R${boleto.calcularJuros()}");
            Console.WriteLine($"Valor Desconto: R${boleto.calcularDesconto()}"); Console.WriteLine($"Valor Multa: R${boleto.calcularMulta()}");
            Console.WriteLine($"---------------");

            return boleto;
        }
    }
}

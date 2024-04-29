/*
O padrão Null Object é um padrão de design de software que permite substituir objetos nulos por objetos que não fazem nada, evitando verificações de nulidade. Ele melhora a legibilidade e a manutenção do código ao reduzir o número de verificações de nulidade. Isso é alcançado por meio da criação de uma classe que implementa uma interface com métodos vazios ou valores padrão. O uso desse padrão pode simplificar o código, tornando-o mais robusto e menos propenso a erros. Ele é comumente aplicado em situações em que é necessário lidar com casos de nulidade de forma elegante e eficiente.
*/

using Com.Padroes.De.Projeto.PadraoNullObject.Endereco;
using Com.Padroes.De.Projeto.PadraoNullObject.pessoa;

Pessoa pessoa1 = PessoaFactory.criarPessoa(
           "Jurandir",
             new EnderecoPessoa("Rua 1", "1234-789"));

pessoa1.MostrarDetalhes();

Console.WriteLine("-------------------------------------");
Pessoa pessoa2 = PessoaFactory.criarPessoa(
    "Joaquim",
      null);

pessoa2.MostrarDetalhes();
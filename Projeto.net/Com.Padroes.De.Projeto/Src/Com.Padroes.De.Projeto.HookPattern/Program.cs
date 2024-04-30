using Com.Padroes.De.Projeto.HookPattern.Hook;
using Com.Padroes.De.Projeto.HookPattern;


// Exemplo de pedido de produto físico
Console.WriteLine("Processamento de pedido de produto físico:");
PedidoProcessor pedidoProdutoFisico = new PedidoProdutoFisico();
pedidoProdutoFisico.ProcessarPedido();

Console.WriteLine();

// Exemplo de pedido de assinatura
Console.WriteLine("Processamento de pedido de assinatura:");
PedidoProcessor pedidoAssinatura = new PedidoAssinatura();
pedidoAssinatura.ProcessarPedido();

/*
   O Hook Method é como um convite aberto para personalizar partes específicas de um processo ou algoritmo. Ele oferece a flexibilidade de estender um comportamento padrão, permitindo que diferentes partes do código sejam adaptadas de acordo com necessidades específicas, sem alterar a estrutura principal. É como ter um jantar onde você pode adicionar seus próprios temperos para torná-lo mais saboroso, sem mudar a receita principal.
 */

/*
 *  Muitas pessoas podem achar que o template method e o hook method sao a mesma coisa. A grande diferenca
 *  e que os hook method sao uma tecnica para permitir a extensao de comportamento, e o template method como
 *  padrao de um problema mais especifico.
 * 
 */
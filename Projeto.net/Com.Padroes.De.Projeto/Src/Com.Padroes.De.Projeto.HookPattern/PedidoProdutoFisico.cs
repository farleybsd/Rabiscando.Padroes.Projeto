using Com.Padroes.De.Projeto.HookPattern.Hook;

namespace Com.Padroes.De.Projeto.HookPattern
{
    // Classe para processamento de pedidos de produtos físicos
    public class PedidoProdutoFisico : PedidoProcessor
    {
        // Implementação do método hook para enviar uma nota fiscal
        protected override void AfterProcessingHook()
        {
            Console.WriteLine("Nota fiscal enviada para o cliente.");
        }
    }
}

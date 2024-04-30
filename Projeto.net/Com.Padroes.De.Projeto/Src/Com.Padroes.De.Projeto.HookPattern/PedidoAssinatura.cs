using Com.Padroes.De.Projeto.HookPattern.Hook;

namespace Com.Padroes.De.Projeto.HookPattern
{
    // Classe para processamento de pedidos de assinaturas
    public class PedidoAssinatura : PedidoProcessor
    {
        // Implementação do método hook para ativar a assinatura

        protected override void AfterProcessingHook()
        {
            Console.WriteLine("Assinatura ativada para o cliente.");
        }
    }
}

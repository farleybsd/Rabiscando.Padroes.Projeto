namespace Com.Padroes.De.Projeto.HookPattern.Hook
{
    // Classe base para processamento de pedidos
    public class PedidoProcessor
    {
        // Método "hook" para comportamento personalizado após o processamento padrão
        protected virtual void AfterProcessingHook()
        {
            // Nenhum comportamento padrão para que as subclasses implemente o comportamento
            // Conforme a sua necessidade
        }

        // Método de processamento padrão

        public void ProcessarPedido()
        {
            Console.WriteLine("Pedido processado com sucesso.");
            // Chamada ao método hook para comportamento personalizado
            AfterProcessingHook();
        }
    }
}

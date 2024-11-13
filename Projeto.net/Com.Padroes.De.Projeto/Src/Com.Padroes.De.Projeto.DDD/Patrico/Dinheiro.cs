namespace Com.Padroes.De.Projeto.DDD.Patrico;

// Objeto de Valor - Dinheiro
public class Dinheiro
{
    public decimal Valor { get; }
    public string Moeda { get; }

    public Dinheiro(decimal valor, string moeda)
    {
        if (valor < 0) throw new ArgumentException("O valor não pode ser negativo.");
        Valor = valor;
        Moeda = moeda;
    }
}

// Entidade ItemPedido
public class ItemPedido1
{
    public Guid Id { get; private set; }
    public string Descricao { get; private set; }
    public int Quantidade { get; private set; }
    public Dinheiro PrecoUnitario { get; private set; }

    public ItemPedido1(string descricao, int quantidade, Dinheiro precoUnitario)
    {
        Id = Guid.NewGuid();
        Descricao = descricao;
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
    }

    public Dinheiro CalcularTotal()
    {
        return new Dinheiro(PrecoUnitario.Valor * Quantidade, PrecoUnitario.Moeda);
    }
}

// Entidade Raiz do Agregado - Pedido
public class Pedido1
{
    public Guid Id { get; private set; }
    public DateTime Data { get; private set; }
    private List<ItemPedido1> _itens; // Coleção privada de itens
    public IReadOnlyCollection<ItemPedido1> Itens => _itens.AsReadOnly(); // Exposição somente leitura

    public Pedido1()
    {
        Id = Guid.NewGuid();
        Data = DateTime.Now;
        _itens = new List<ItemPedido1>();
    }

    // Método para adicionar um item ao pedido (só permitido via entidade raiz)
    public void AdicionarItem(ItemPedido1 item)
    {
        if (item == null) throw new ArgumentNullException(nameof(item));
        _itens.Add(item);
    }

    // Método para calcular o total do pedido
    public Dinheiro CalcularTotalPedido()
    {
        decimal total = _itens.Sum(item => item.CalcularTotal().Valor);
        return new Dinheiro(total, "BRL");
    }

    // Método para remover um item do pedido (manutenção da consistência)
    public void RemoverItem(Guid itemId)
    {
        var item = _itens.SingleOrDefault(i => i.Id == itemId);
        if (item != null)
        {
            _itens.Remove(item);
        }
    }
}
/*
Objeto de ValorDinheiro :

Dinheiroé um objeto de valor que encapsula um valor monetário e uma moeda, com validação para não permitir valores negativos.
    EntidadeItemPedido :

Cada item possui uma Descrição, uma Quantidade, e um PreçoUnitariodo tipo Dinheiro.
    Ele tem um método CalcularTotalque calcula o valor total com base na quantidade e no preço unitário.
    Entidade RaizPedido :

Pedidoé a entidade raiz do agregado e contém a lógica para adicionar, remover e calcular o total dos itens.
    Somente você Pedidopode adicionar ou remover itens, garantindo a consistência do agregado.
    O método CalcularTotalPedidousa o método CalcularTotalde cada ItemPedidopara calcular o valor total do pedido.
*/
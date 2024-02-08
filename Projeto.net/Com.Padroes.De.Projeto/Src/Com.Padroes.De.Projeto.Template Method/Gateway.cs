namespace Com.Padroes.De.Projeto.Template_Method
{
    public class Gateway
    {
        //Simulação de uma cobrança - retorna 'true' ou 'false' de forma randômica.
        public Boolean Cobrar(float valor)
        {
            Console.WriteLine($"R$ {valor}");  //Apenas para visualizar o valor final.
            var random = new Random();
            return random.Next(2) == 1;
        }
    }
}
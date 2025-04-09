namespace DiamanteX.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirCabecalho();
           
        }

        static void ExibirCabecalho()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Faça seu diamante!");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Digite um número inteiro para montar seu diamante: ");
            Console.ReadLine();
        }
       
    }
}

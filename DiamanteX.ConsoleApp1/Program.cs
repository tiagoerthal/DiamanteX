﻿namespace DiamanteX.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                ExibirCabecalho();

                int numeroDoUsuario = Convert.ToInt32(Console.ReadLine());


                if (numeroDoUsuario < 3 || numeroDoUsuario % 2 == 0)
                {
                    Console.WriteLine("Digite outro número, ímpar maior que 1");
                   
                }

                Console.ReadLine();
            }

           
        }

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Faça seu diamante!");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Digite um número inteiro para montar seu diamante: ");       
        }
       
    }
}

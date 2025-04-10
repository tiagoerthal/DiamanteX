using System.Reflection.Metadata.Ecma335;

namespace DiamanteX.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ExibirCabecalho();

                int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

                ExibirMensagemDeErro(tamanhoDiamante);

                Console.WriteLine("Digite ENTER para continuar....");

                int quantidadeLinhas = (tamanhoDiamante - 1) / 2;
                int quantidadeEspaco = quantidadeLinhas;
                int quantidadeX = 1;

                //aqui
                ExibirMetodo(quantidadeLinhas, quantidadeEspaco, quantidadeX, tamanhoDiamante);

                Console.ReadLine();


                string opcaoContinuar = ExibirMenuContinuar();
                if (opcaoContinuar != "S")
                    break;

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

        static void ExibirMensagemDeErro(int tamanhoDiamante)
        {

            if (tamanhoDiamante < 3 || tamanhoDiamante % 2 == 0)
            {
                Console.WriteLine("Digite outro número, ímpar maior que 1");

            }
        }

        static void ExibirMetodo(int quantidadeLinhas, int quantidadeEspaco, int quantidadeX, int tamanhoDiamante)
        {
            // parte de cima
            for (int i = 0; i < quantidadeLinhas; i++)
            {
                for (int espaco = 0; espaco < quantidadeEspaco; espaco++)
                    Console.Write(" ");

                for (int x = 0; x < quantidadeX; x++)
                    Console.Write("X");

                quantidadeX += 2;
                quantidadeEspaco--;

                Console.WriteLine();
            }

            #region parte do meio
            for (int i = 0; i < tamanhoDiamante; i++)
                Console.Write("X");

            Console.WriteLine();
            #endregion


            #region parte de baixo
            for (int i = 0; i < quantidadeLinhas; i++)
            {
                quantidadeX -= 2;
                quantidadeEspaco++;

                for (int espacos = 0; espacos < quantidadeEspaco; espacos++)
                    Console.Write(" ");

                for (int x = 0; x < quantidadeX; x++)
                    Console.Write("X");

                Console.WriteLine();
            }
        }
        #endregion
        static string ExibirMenuContinuar()
        {
            Console.WriteLine("----------------------------------------");
            Console.Write("Deseja continuar? (S/N): ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            return opcaoContinuar;
        }
    }
    
}

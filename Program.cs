using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o total de nomes que você queira: ");
            int tamanho = int.Parse(Console.ReadLine());

            string[] nomes = new string[tamanho];

            // Console.WriteLine(nomes.Length);

            for( int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Nome do aluno:");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("");

            for( int i = 0; i < nomes.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" - ");
                Console.Write(nomes[i]);
                Console.Write(" - ");
            }

        }
    }
}

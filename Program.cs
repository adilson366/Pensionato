using System;

namespace Pencionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] vect = new Quarto[10];

            Console.WriteLine("Digite o numero de estudantes para entrada: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do estudante: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o email do estudante: ");
                string email = Console.ReadLine();
                Console.Write("Digite o numero do quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Quarto(nome, email, quarto);
            }

            foreach (Quarto item in vect)
            {
                Console.WriteLine(item);
            }

        }
    }
}

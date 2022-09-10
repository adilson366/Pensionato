using System;

namespace Pencionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] vect = new Quarto[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Quarto(nome, email, quarto);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            foreach (Quarto item in vect)
            {

                if (item != null)
                {
                    Console.WriteLine(item);
                }

            }

        }
    }
}

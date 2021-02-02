using System;

namespace Aluguel_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Quarto[] listaQuartos = new Quarto[10];
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine();

                listaQuartos[numero] = new Quarto(nome, email, numero);
            }

            foreach(Quarto elementos in listaQuartos)
            {
                if(elementos != null)
                Console.WriteLine(elementos);
            }


        }
    }
}

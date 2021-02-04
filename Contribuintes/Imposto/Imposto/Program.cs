using System;
using Imposto.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuintes> lista = new List<Contribuintes>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i}:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIcome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new PessoaFisica(name, anualIcome, health));
                }
                else if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new PessoaJuridica(name, anualIcome, numberEmployees));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Contribuintes con in lista)
            {
                Console.WriteLine($"{con.Nome}: $ {con.Imposto().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine();

            double total = 0;

            foreach (Contribuintes con in lista)
            {
                total += con.Imposto();
            }

            Console.WriteLine($"TOTAL TAXES: $ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

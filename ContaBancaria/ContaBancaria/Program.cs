using System;
using System.Globalization;

namespace ContaBancaria_exercicio_de_fixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria c1;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?: ");
            char resposta = char.Parse(Console.ReadLine());
            double valor = 0;
            Console.WriteLine();

            if (resposta.ToString().ToUpper() == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new ContaBancaria(numero, nome, valor);
                Console.WriteLine();
            }
            else
            {
                c1 = new ContaBancaria(numero, nome);
                Console.WriteLine();
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c1);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(valor);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(c1);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c1);






        }
    }
}
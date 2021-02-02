using System;
using System.Collections.Generic;
using System.Globalization;

namespace Funcionario_Aumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos empregados serão resgistrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Empregado #{i + 1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                listaFuncionarios.Add(new Funcionario(id, nome, salario));
            }

            Console.WriteLine("Entre com o Id do funcionário que terá o salário aumentado: ");
            int idPesquisa = int.Parse(Console.ReadLine());
            Console.WriteLine();
            double porcentagem = 0;

            Funcionario fun = listaFuncionarios.Find(e => e.Id == idPesquisa);

            if ( fun == null)
            {
                Console.WriteLine($"O funcionário com Id:  {idPesquisa} não foi encontrado!");
                Console.WriteLine();
            }   
            else
            {
                Console.Write("Entre com a porcentagem: ");
                porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fun.AumentarSalario(porcentagem);
               
            }

            foreach (Funcionario elementos in listaFuncionarios)
            {
                Console.WriteLine(elementos);
            }
            
            
            
        }
    }
}

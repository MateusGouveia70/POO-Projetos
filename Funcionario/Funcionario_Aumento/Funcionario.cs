using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionario_Aumento
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100; 
        }

        public override string ToString()
        {
            return $"Lista atualizada de funcionários:\n " +
                $"{Id}, {Nome}, {Salario}";
        }

    }
}

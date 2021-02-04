using System;
using System.Collections.Generic;
using System.Text;

namespace Imposto.Entities
{
    abstract class Contribuintes
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Contribuintes(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();
    }
}

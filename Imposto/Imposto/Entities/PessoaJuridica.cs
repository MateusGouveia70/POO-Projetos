using System;
using System.Collections.Generic;
using System.Text;

namespace Imposto.Entities
{
    class PessoaJuridica : Contribuintes
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Imposto()
        {
            double imposto = 0;

            if (NumeroFuncionarios <= 10)
            {
                imposto = RendaAnual * 0.16;
            }
            else if (NumeroFuncionarios > 10)
            {
                imposto = RendaAnual * 0.14;
            }

            return imposto;
        }
    }
}

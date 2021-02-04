using System;
using System.Collections.Generic;
using System.Text;
using Imposto.Entities;

namespace Imposto.Entities
{
    class PessoaFisica : Contribuintes 
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double Imposto()
        {
            double imposto = 0;

            if(RendaAnual < 20000)
            {
                imposto = RendaAnual * 0.15;
            }
            else if(RendaAnual >= 20000)
            {
                imposto = RendaAnual * 0.25;
            }

            if(GastoSaude > 0)
            {
                imposto -= GastoSaude * 0.50 ; 
            }

            return imposto;
        }


    }
}

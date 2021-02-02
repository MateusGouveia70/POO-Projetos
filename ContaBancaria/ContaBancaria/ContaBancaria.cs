using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria_exercicio_de_fixacao
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public ContaBancaria(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Saldo += depositoInicial;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }


        public override string ToString()
        {
            return $"Conta: {Numero}, Titular: {Nome},  Saldo $ {Saldo}";
        }


    }
}
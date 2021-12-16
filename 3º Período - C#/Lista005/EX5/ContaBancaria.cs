using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5
{
    class ContaBancaria
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public void Depositar (double quantia)
        {
            Saldo += quantia;
        }
        public void Sacar(double quantia)
        {
            Saldo -= quantia + 5;
        }
        public void ImprimirDados()
        {
            Console.Write("Numero da conta: "+ Numero + ", "+"Titular da conta: "+ Titular+", "+"Saldo: "+ Saldo);
        }
    }
}

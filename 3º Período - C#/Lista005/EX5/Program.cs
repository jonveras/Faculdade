using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre com o número da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular:");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n):");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'S' || resp == 's')
            {
                Console.Write("Entre com o valor do deposito: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, nome, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, nome);
            }
            Console.WriteLine();
            conta.ImprimirDados();

            Console.Write("\nEntre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Depositar(quantia);
            Console.WriteLine("\nDados da Conta:");
            conta.ImprimirDados();

            Console.Write("\nEntre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Sacar(quantia);
            Console.WriteLine("\nDados da Conta:");
            conta.ImprimirDados();

            Console.ReadKey();
        }
    }
}

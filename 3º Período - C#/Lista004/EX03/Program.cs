using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a marca do carro:");
            string marca = Console.ReadLine();
            Console.Write("Digite a modelo do carro:");
            string modelo = Console.ReadLine();
            Console.Write("Digite a cor do carro:");
            string cor = Console.ReadLine();
            Console.Write("Digite o preço do carro:");
            double preco = double.Parse(Console.ReadLine()); // Casting, converti de string para double
            Carro carro1 = new Carro(marca,modelo,cor,preco); // instanciando a classe

            Console.WriteLine("Imprimindo obj carro1:");
            Console.WriteLine(carro1.GetModelo());
            Console.WriteLine(carro1.GetCor());
            Console.WriteLine(carro1.GetPreco());

            Console.WriteLine("Mudando os atributos:");

            carro1.SetModelo("Fiat");
            carro1.SetCor("Vermelho");
            carro1.SetPreco(1000);

            Console.WriteLine(carro1.GetModelo());
            Console.WriteLine(carro1.GetCor());
            Console.WriteLine(carro1.GetPreco());     

            Console.ReadKey();

        }
    }
}

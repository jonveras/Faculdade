using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            Console.Write("Entre com o raio: ");
            r = double.Parse(Console.ReadLine());

            double area = Calculadora.AreaCircunferencia(r);
            double volume = Calculadora.VolumeCircunferencia(r);

            Console.Write("Area: " + area);
            Console.Write("Volume: " + volume);
            Console.ReadKey();
        }
    }
}

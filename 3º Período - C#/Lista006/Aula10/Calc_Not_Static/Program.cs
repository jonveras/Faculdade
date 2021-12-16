using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Not_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            Console.Write("Entre com o raio: ");
            r = double.Parse(Console.ReadLine());

            Calculadora calc = new Calculadora();
            double area = calc.AreaCircunferencia(r);
            double volume = calc.VolumeCircunferencia(r);

            Console.Write("Area: " + area);
            Console.Write("Volume: " + volume);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c;
            Console.WriteLine("Entre com as medidas do triângulo X:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            Triangulo x = new Triangulo(a, b, c);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            Triangulo y = new Triangulo(a, b, c);
            //Calculando para o triângulo X
            double areaX = x.Area();
            //Calculando para o triângulo Y            
            double areaY = y.Area();
            
            Console.WriteLine($"Area de X = {areaX:N2}");
            Console.WriteLine($"Area de Y = {areaY:N2}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Área: X");
            }
            else
            {
                Console.WriteLine("Maior Área: Y");
            }
            Console.ReadKey();
        }
    }
}

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
            double xA, xB, xC, yA, yB, yC; 
            Console.WriteLine("Entre com as medidas do triângulo X:"); 
            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());
            //Calculando para o trinângulo X
            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
            //Calculando para o trinângulo Y
            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
            Console.WriteLine($"Area de X = {areaX:N2}");
            Console.WriteLine($"Area de Y = {areaY:N2}");
            if (areaX > areaY)
            { 
                Console.WriteLine("Maior Área: X"); 
            } 
            else 
            { 
                Console.WriteLine("Maior Área: Y"); }
            Console.ReadKey();
        }
    }
}

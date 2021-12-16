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
            Console.Write("Digite a ordem da matriz: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Digite um número: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            int numneg = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(mat[i, j] < 0)
                    {
                        numneg +=1;
                    }
                }
            }
            Console.Write("Diagonal Principal: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   if(i == j)
                    {
                        Console.Write(mat[i, j] + ",");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade de Números Negativos: " + numneg);
            Console.ReadKey();
        }
    }
}

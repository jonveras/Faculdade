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
            Console.Write("Digite um número de linhas na matriz: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Digite um número de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());            
            int[,] mat = new int[m, n];
            Console.WriteLine("PREENCHENDO A MATRIZ:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Digite um número["+i+","+j+"]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Exibindo a matriz
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();

            Console.Write("Digite um número para pesquisar na matriz: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x == mat[i, j])
                    {
                        Console.WriteLine("Posição: " + i + "," + j);                                              
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        if (j < m)
                        {
                            Console.WriteLine("Direita: " + mat[i, j+1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }
                        if (i < m)
                        {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                        Console.WriteLine();                        
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

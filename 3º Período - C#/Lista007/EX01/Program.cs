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
            Console.Write("Quantos quartos serão alugados? ");
            int aluguel = int.Parse(Console.ReadLine());
            Quarto[] vect = new Quarto[10];
            
            for (int i = 0; i < aluguel; i++)                
            {
                Console.WriteLine("\nAluguel #" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numquarto = int.Parse(Console.ReadLine());
                if ((numquarto-1) <10 && (numquarto-1) >=0)
                {
                    vect[numquarto-1] = new Quarto { _nome = nome, _email = email };
                }
                else
                {
                    Console.Write("Quarto indisponível, escolha outro numero entre [1 e 10]:");
                    Console.Write("Quarto:");
                    numquarto = int.Parse(Console.ReadLine());
                    vect[numquarto - 1] = new Quarto { _nome = nome, _email = email };
                }
            }
            Console.WriteLine("\nQuartos Ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                { 
                    Console.WriteLine((i + 1) + ": " + vect[i]._nome + " " + vect[i]._email);
                }
            }
            Console.ReadKey();
        }
    }
}

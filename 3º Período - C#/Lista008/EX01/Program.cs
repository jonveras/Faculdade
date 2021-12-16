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
            Console.Write("Quantos Funcionários serão registrados? ");
            int N = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < N; i++)
            {
                Console.Write("Funcionario #"+(i+1)+":\n");
                Console.Write("Digite o ID: ");
                int id = int.Parse(Console.ReadLine());
                Funcionario aux = funcionarios.Find(x => x._id == id);
                if (aux != null)
                {
                    Console.WriteLine("Esse ID já existe, digite outro ID: ");
                    id = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Digite o Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Digite o Salário: ");
                    double sal = double.Parse(Console.ReadLine());

                    funcionarios.Add(new Funcionario { _id = id, _nome = nome, _sal = sal });
                    Console.WriteLine();
                }                
            }

            Console.Write("Entre com o ID do funcionário que terá o salário aumentado: ");
            int idFunc = int.Parse(Console.ReadLine());

            Funcionario func = funcionarios.Find(x => x._id == idFunc);

            if (func != null)
            {
                Console.Write("Digite a porcentagem: ");
                double porc = double.Parse(Console.ReadLine());
                func.aumentaSal(porc);
            }
            else
            {
                Console.WriteLine("ID inexistente!");
            }

            Console.WriteLine();
            Console.WriteLine("Atualizando lista de Funcionários:");
            foreach (Funcionario item in funcionarios)
            {
                Console.WriteLine(item._id + " " + item._nome + " " + item._sal);
            }
            Console.ReadKey();
        }
    }
}

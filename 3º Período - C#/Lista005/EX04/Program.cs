using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);
            produto.Imprimir();
            Console.WriteLine("\n***");
            Console.Write("Digite o número a ser adicionado ao estoque: ");
            int atualizarQuantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(atualizarQuantidade);
            produto.Imprimir();
            Console.Write("Digite a quantidade a ser removida do estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            produto.RemoverProduto(qtde);
            produto.Imprimir();
            Console.ReadKey();
        }
    }
}

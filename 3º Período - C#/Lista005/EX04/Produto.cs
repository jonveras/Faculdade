using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04
{
    class Produto
    {
        private string _nome;    
        private double _preco;   
        private int _quantidade; 
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome 
        {
            get { return _nome; }
            set {
                if (value != "")
                {
                    _nome = value;
                }
            }
        }
        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        } 
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void Imprimir()
        {
            Console.Write("\n***\nDados do produto:\n");
            Console.WriteLine("Nome: " + _nome);
            Console.WriteLine("Preço: " + _preco);
            double res = ValorTotalEmEstoque();
            Console.WriteLine("Preço Final em Estoque: " + res);
        }
        public void AdicionarProduto (int quantidade)
        {
            _quantidade += quantidade;

        }
        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }
    }
}

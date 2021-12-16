using System;

namespace EX03
{
    class Carro
    {
        private string _marca; //Atributo
        private string _modelo; //Atributo
        private string _cor; //Atributo
        private double _preco; //Atributo

        public Carro(string marca, string modelo, string cor, double preco)
        {
            _marca = marca;
            _modelo = modelo;
            _cor = cor;
            if (preco < 0)
            {
                _preco = 0;
            }
            else
            {
                _preco = preco;
            }     
        }
        public string GetModelo()
        {
            return _modelo;
        }
        public void SetModelo(string modelo)
        {
            _modelo = modelo;
        }
        public void SetCor(string cor)
        {
            _cor = cor;
        }
        public string GetCor()
        {
            return _cor;    
        }
        public void SetPreco(double preco)
        {
            if (preco < 0) 
            {
                _preco = 0;
            }
            else
            {
                _preco = preco;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }
    }
}

using System;

namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o nome");
            string nome = Console.ReadLine();
            Console.WriteLine("digite o preco do produto");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a quantidade do produto");
            int qt = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome,preco,qt);
            
            Console.WriteLine("dados do produto \nNome: "+p.Nome+"\nPreço: "+p.Preco+"\nQuantidade: "+p.Quantidade+"\nTotal: "+p.valortotalestoque());
        }
    }
}


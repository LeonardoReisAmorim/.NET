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
            double total = p.valortotalestoque();
            Console.WriteLine("dados do produto: "+p.Nome+" preco: "+p.Preco+" quantidade"+p.Quantidade+" total: "+total);
        }
    }
}


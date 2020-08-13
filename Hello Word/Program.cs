using System;

namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite seu nome");
            String nome = Console.ReadLine();
            Console.WriteLine("digite quantos quartos tem");
            int qt = int.Parse(Console.ReadLine());
            Console.WriteLine("entre com os precos do produto");
            double preco = double.Parse(Console.ReadLine());
            
            Console.WriteLine("seu nome e: "+nome);
            Console.WriteLine("tem :"+qt+" quartos");
            Console.WriteLine("o seu produto custa: "+preco);
        }
    }
}

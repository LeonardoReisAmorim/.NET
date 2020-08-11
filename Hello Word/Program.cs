using System;

namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite seu nome");
            String nome = Console.ReadLine();
            Console.WriteLine("digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine(idade);
        }
    }
}

using System;

namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());
            double formula = 3.14*(raio*raio);
            Console.WriteLine("digite o raio");

            Console.WriteLine("o raio é: "+formula);
        }
    }
}

using System;

namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o 1 valor");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o 2 valor");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o 3 valor");
            double n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o 4 valor");
            double n4 = double.Parse(Console.ReadLine());
            double conta = (n1*n2)-(n3*n4);
            Console.WriteLine(conta);
        }
    }
}

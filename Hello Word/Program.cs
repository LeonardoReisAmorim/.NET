using System;

namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numero da peca");
            int npeca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("qt da peca");
            int qtpeca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("valor da peca");
            double vpeca1 = double.Parse(Console.ReadLine());
            Console.WriteLine("numero da peca");
            int npeca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("qt da peca");
            int qtpeca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("valor da peca");
            double vpeca2 = double.Parse(Console.ReadLine());

            double conta = (qtpeca1*vpeca1)+(qtpeca2*vpeca2);
                            //1*10 = 10         2*20=40          10+40=50
            Console.WriteLine("o resultado e: "+conta);
        }
    }
}

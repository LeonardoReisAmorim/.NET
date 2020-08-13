using System;

namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o numero do func");
            int nfunc = int.Parse(Console.ReadLine());
            Console.WriteLine("n horas trabalhadas");
            int nhoras = int.Parse(Console.ReadLine());
            Console.WriteLine("salario do func");
            double sal = double.Parse(Console.ReadLine());
            double conta = sal*nhoras;

            Console.WriteLine("number"+nfunc);
            Console.WriteLine("salary: "+conta.ToString("F2"));
        }
    }
}

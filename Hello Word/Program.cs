using System;

namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite quantas vezes quer q o loop continue");
            int x = int.Parse(Console.ReadLine());
            for(int i = 0; i<x; i++){
                Console.WriteLine("leo");
            }
        }
    }
}

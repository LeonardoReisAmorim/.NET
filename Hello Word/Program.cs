using System;

namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dados da 1 pessoa: ");
            Console.WriteLine("digite o nome");
            String nome1 = Console.ReadLine();
            Console.WriteLine("digite a idade");
            int idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("dados da 2 pessoa: ");
            Console.WriteLine("digite o nome");
            String nome2 = Console.ReadLine();
            Console.WriteLine("digite a idade");
            int idade2 = int.Parse(Console.ReadLine());

            int res = comparaidades(idade1, idade2);
            if(res==0){
                Console.WriteLine("idades iguais");
            }else if(res==idade1){
                Console.WriteLine("o nome da pessoa mais velha e: "+nome1);
            }else{
                Console.WriteLine("o nome da pessoa mais velha e: "+nome2);
            }
        }

        static int comparaidades(int a, int b){
            int m;
            if(a==b){
                return 0;
            }
            else if(a>b){
                m = a;
            }
            else{
                m = b;
            }
            return m;
        }
    }
}

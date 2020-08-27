using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("digite o nome");
            string nome1 = Console.ReadLine();
            Console.WriteLine("digite a idade");
            int idade1 = int.Parse(Console.ReadLine());
            Pessoa p1 = new Pessoa(nome1,idade1);

            Console.WriteLine("digite o nome");
            string nome2 = Console.ReadLine();
            Console.WriteLine("digite a idade");
            int idade2 = int.Parse(Console.ReadLine());
            Pessoa p2 = new Pessoa(nome2,idade2);*/

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Console.WriteLine("digite o nome");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("digite a idade");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o nome");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("digite a idade");
            p2.Idade = int.Parse(Console.ReadLine());

            int maior = p1.maioridade(p1.Idade, p2.Idade);

            if(maior==0){
                Console.WriteLine("idades iguais");
            } else if(maior==p1.Idade){
                Console.WriteLine(p1.Nome);
            }else{
                Console.WriteLine(p2.Nome);
            }
        }
    }
}

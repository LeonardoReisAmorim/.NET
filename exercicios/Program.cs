using System;
using System.Collections.Generic;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluguel> lista = new List<Aluguel>();
            Aluguel a1 = new Aluguel("maria", "maria@gmail", 5);
            Aluguel a2 = new Aluguel("marco", "marco@gmail", 1);
            Aluguel a3 = new Aluguel("alex", "alex@gmail", 8);
            lista.Add(a1);
            lista.Add(a2);
            lista.Add(a3);

            foreach(Aluguel i in lista){
                Console.WriteLine("aluguel: "+lista.Count);
                Console.WriteLine("nome: "+i.Nome+" email: "+i.Email+" quarto: "+i.Quarto);
            }
        }
    }
}

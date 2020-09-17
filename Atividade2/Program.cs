using System;
using System.Collections.Generic;
namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Pessoa> list = new List<Pessoa>();
           Pessoa p1 = new Pessoa("leo", 30);
           Pessoa p2 = new Pessoa("maria", 17);
           Pessoa p3 = new Pessoa("joao", 25);
           Pessoa p4 = new Pessoa("alice", 16);

           list.Add(p1);
           list.Add(p2);
           list.Add(p3);
           list.Add(p4);

           //foreach(Pessoa i in list){
            //   Console.WriteLine(i.Idade);
           //} 

           //Pessoa res = list.Find(x => x.Nome.Equals("leo"));
          
            //   Console.WriteLine(res.Idade+" "+res.Nome);

            List<Pessoa> novalista = list.FindAll(x => x.Idade <= 18);

            foreach(Pessoa i in novalista){
                Console.WriteLine(i.Nome+" "+i.Idade);
            }
          

           
        }
    }
}

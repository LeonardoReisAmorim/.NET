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

           list.Add(p1);
           list.Add(p2);

           //foreach(Pessoa i in list){
            //   Console.WriteLine(i.Idade);
           //} 

           Pessoa res = list.Find(x => x.Nome.Equals("leo"));
          
               Console.WriteLine(res.Idade+" "+res.Nome);
          

           
        }
    }
}

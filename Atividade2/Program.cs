using System;
using System.Collections.Generic;
namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Funcionarioss> list = new List<Funcionarioss>();
           Funcionarioss f1 = new Funcionarioss("maria brown", 333, 4000.00);
           Funcionarioss f2 = new Funcionarioss("alex grey", 536, 3000.00);
           Funcionarioss f3 = new Funcionarioss("bob green", 772, 5000.00);
           list.Add(f1);
           list.Add(f2);
           list.Add(f3);

           Console.WriteLine("entre com o id do funcionario que deseja pesquisar: ");
           int id = int.Parse(Console.ReadLine());

           Funcionarioss pesquisado = list.Find(x => x.Id==id);

           Console.WriteLine("entre com a porcentagem: ");
           double porcent = double.Parse(Console.ReadLine());
           pesquisado.ReajustarSal(porcent);
           pesquisado = f2;
           //list.Insert(1, pesquisado);
           //list.Remove(f2);
           Console.WriteLine("atualizado lista de funcionarios");

           foreach(Funcionarioss i in list){
               Console.WriteLine(i.Id+" "+i.Nome+" "+i.Salario.ToString("F2"));
           }
        }
    }
}

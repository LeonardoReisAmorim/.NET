using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("digite quantos funcionarios existem:");
           int x = int.Parse(Console.ReadLine());
           for(int i=0;i<x;i++){
               Console.Write("terceirizado: 1/2 (1 = é terceirizado, 2 = não é terceirizado");
               int terce = int.Parse(Console.ReadLine());
               if(terce==1){
                   FuncionarioTerceirizados f = new FuncionarioTerceirizados();
               } 
           }
        }
    }
}

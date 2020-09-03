using System;
using System.Collections.Generic;
namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("digite quantos funcionarios existem:");
           int x = int.Parse(Console.ReadLine());
           for(int i=0;i<x;i++){
               Console.WriteLine("FUNCIONARIO NUMERO: "+i+1);
               Console.Write("terceirizado: 1/2 (1 = é terceirizado, 2 = não é terceirizado");
               int terce = int.Parse(Console.ReadLine());
               if(terce==1){
                   FuncionarioTerceirizados[] ft = new FuncionarioTerceirizados[i];
                   Console.Write("digite seu nome: "); 
                   ft[i].Nome = Console.ReadLine();
                   Console.Write("digite a qt de horas trabalhadas: "); 
                   ft[i].HorasTrabalhadas = int.Parse(Console.ReadLine());
                   Console.Write("digite o valor por hora: "); 
                   ft[i].ValorPorHora = double.Parse(Console.ReadLine());
                   Console.Write("digite a despeja adicional: "); 
                   ft[i].DespejaAdicional = double.Parse(Console.ReadLine());
                   Console.WriteLine("pagamento: "+ft[i].pagamento());
               }else if(terce==2){
                   Funcionario[] f= new Funcionario[i];
                   Console.Write("digite seu nome");
                   f[i].Nome = Console.ReadLine();
                   Console.Write("digite a qt de horas trabalhadas: ");
                   f[i].HorasTrabalhadas = int.Parse(Console.ReadLine()); 
                   Console.Write("digite o valor por hora: "); 
                   f[i].ValorPorHora = double.Parse(Console.ReadLine());
                   Console.WriteLine("pagamento: "+f[i].pagamento());
               }else{
                   Console.WriteLine("digite um numero valido");
               } 
           }
        }
    }
}

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
                   FuncionarioTerceirizados[] f = new FuncionarioTerceirizados[i];
                   Console.Write("digite seu nome: "); 
                   f[i].Nome = Console.ReadLine();
                   Console.Write("digite a qt de horas trabalhadas: "); 
                   f[i].HorasTrabalhadas = int.Parse(Console.ReadLine());
                   Console.Write("digite o valor por hora: "); 
                   f[i].ValorPorHora = double.Parse(Console.ReadLine());
                   Console.Write("digite a despeja adicional: "); 
                   f[i].DespejaAdicional = double.Parse(Console.ReadLine());
                   Console.WriteLine("pagamento: "+f[i].pagamento());
               } 
           }
        }
    }
}

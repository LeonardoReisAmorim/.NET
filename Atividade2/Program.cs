using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
           Conta c1 = new Conta("Maria", 1010, 200.00);

           Console.WriteLine("Mostrar saldo atual de: "+c1.Nome+" saldo: "+c1.Saldo);
           Console.Write("Depositar: ");
           double valordeposito = double.Parse(Console.ReadLine());
           c1.depositar(valordeposito);
           Console.WriteLine("Mostrar saldo atual de: "+c1.Nome+" saldo: "+c1.Saldo); 
           Console.Write("sacar: ");
           double valorsaque = double.Parse(Console.ReadLine());
           c1.sacar(valorsaque);
           Console.WriteLine("Mostrar saldo atual de: "+c1.Nome+" saldo: "+c1.Saldo); 
        }
    }
}

using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
           Conta c1 = new Conta("Maria", 1010, 200.00);
           Conta c2 = new Conta("pedro", 1234, 100.00);

           Console.WriteLine("Mostrar saldo atual de: "+c1.Nome+" saldo: "+c1.Saldo.ToString("F2"));
           Console.Write("Depositar: ");
           double valordeposito = double.Parse(Console.ReadLine());
           c1.depositar(valordeposito);
           Console.WriteLine("Mostrar saldo atual de: "+c1.Nome+" saldo: "+c1.Saldo.ToString("F2")); 
           Console.Write("sacar: ");
           double valorsaque = double.Parse(Console.ReadLine());
           c1.sacar(valorsaque);
           Console.WriteLine("Mostrar saldo atual de: "+c1.Nome+" saldo: "+c1.Saldo.ToString("F2")); 

           Console.WriteLine("Mostrar saldo atual de: "+c2.Nome+" saldo: "+c2.Saldo.ToString("F2"));
           Console.Write("Depositar: ");
           double valordeposito2 = double.Parse(Console.ReadLine());
           c2.depositar(valordeposito2);
           Console.WriteLine("Mostrar saldo atual de: "+c2.Nome+" saldo: "+c2.Saldo.ToString("F2")); 
           Console.Write("sacar: ");
           double valorsaque2 = double.Parse(Console.ReadLine());
           c2.sacar(valorsaque2);
           Console.WriteLine("Mostrar saldo atual de: "+c2.Nome+" saldo: "+c2.Saldo.ToString("F2"));

           c1.transferir(50);
           c2.depositar(50);
           Console.WriteLine("Mostrar saldo atual de: "+c1.Nome+" saldo: "+c1.Saldo.ToString("F2")); 
           Console.WriteLine("Mostrar saldo atual de: "+c2.Nome+" saldo: "+c2.Saldo.ToString("F2"));
        }
    }
}

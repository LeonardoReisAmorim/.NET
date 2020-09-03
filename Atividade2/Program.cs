using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
           Conta contanormal = new Conta("maria", 1010, 200.00);
           ContaEmpresa contaEmpresa = new ContaEmpresa(5000.00, "antonio", 1234, 15000.00);

           Console.WriteLine("CONTA 1"); 
           Console.WriteLine("nome: "+contanormal.Nome+" mostrar o saldo atual: "+contanormal.Saldo.ToString("F2"));
           contanormal.depositar(300.00);
           Console.WriteLine("mostrar saldo atualizado: "+contanormal.Saldo.ToString("F2"));
           contanormal.sacar(50.00);
           Console.WriteLine("mostrar saldo atualizado: "+contanormal.Saldo.ToString("F2"));

           Console.WriteLine("CONTA 2");
           Console.WriteLine("nome: "+contaEmpresa.Nome+" mostrar saldo atual: "+contaEmpresa.Saldo.ToString("F2"));
           contaEmpresa.sacar(1000.00);
           Console.WriteLine("mostrar saldo atualizado: "+contaEmpresa.Saldo.ToString("F2"));
           contaEmpresa.depositar(2000.00);
           Console.WriteLine("mostrar saldo atualizado: "+contaEmpresa.Saldo.ToString("F2"));
           contaEmpresa.emprestar(3000.00);
           Console.WriteLine("mostrar saldo atualizado: "+contaEmpresa.Saldo.ToString("F2"));
        }
    }
}

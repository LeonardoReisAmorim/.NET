namespace Atividade2
{
    public class Conta
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Conta(string nome, int numero, double saldo)
        {
            this.Nome = nome;
            this.Numero = numero;
            this.Saldo = saldo;
        }

        public void sacar(double valor){
            Saldo -= valor;
        }

        public void depositar(double valor){
            Saldo +=valor;
        }
    }
}
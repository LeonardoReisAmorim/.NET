namespace Atividade2
{
    public class ContaEmpresa : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresa(double limiteEmprestimo,string nome, int numero, double saldo) : base(nome,numero,saldo)
        {
            this.LimiteEmprestimo = limiteEmprestimo;
        }

        public ContaEmpresa(){

        }

        public void emprestar(double valor){
            if(valor>this.LimiteEmprestimo){
                this.Saldo = this.Saldo;
            }else{
                this.Saldo += valor;
            }
        }
    }
}
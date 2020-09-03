namespace Atividade2
{
    public class Funcionario
    {
        
        public string Nome { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorPorHora { get; set; }

        public Funcionario(string nome, int horasTrabalhadas, double valorPorHora)
        {
            this.Nome = nome;
            this.HorasTrabalhadas = horasTrabalhadas;
            this.ValorPorHora = valorPorHora;
        }

        public Funcionario(){

        }

        public double pagamento(){
            return this.HorasTrabalhadas*this.ValorPorHora;
        }
    }
}
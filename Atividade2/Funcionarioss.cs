namespace Atividade2
{
    public class Funcionarioss
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double Salario { get; set; }

        public Funcionarioss(string nome, int id, double salario)
        {
            this.Nome = nome;
            this.Id = id;
            this.Salario = salario;
        }

        public void ReajustarSal(double x){
            Salario = Salario*(x/100+1); 
        }
    }
}
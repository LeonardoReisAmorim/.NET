namespace Atividade2
{
    public class FuncionarioTerceirizados : Funcionario
    {
        
        public double DespejaAdicional { get; set; }

        public FuncionarioTerceirizados(double despejaAdicional,string nome, int horasTrabalhadas, double valorPorHora) : base(nome, horasTrabalhadas, valorPorHora)
        {
            this.DespejaAdicional = despejaAdicional;
        }

        public FuncionarioTerceirizados(){

        }

        
    }
}
namespace exercicioum
{
    public class Consulta
    {
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public int Tipo_exame { get; set; }
        public string Nome_medico { get; set; }
        public Consulta(int cpf, string nome, string sobrenome, int idade, char sexo, string nome_medico)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
            this.Sexo = sexo;
            this.Nome_medico = nome_medico;
        }
        public Consulta(){}
    }
}
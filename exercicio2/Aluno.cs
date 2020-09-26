namespace exercicio1
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Primeiro_nome { get; set; }
        public string Sobrenome { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }

        public Aluno(int matricula, string primeiro_nome, string sobrenome, int nota1, int nota2, int nota3)
        {
            this.Matricula = matricula;
            this.Primeiro_nome = primeiro_nome;
            this.Sobrenome = sobrenome;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
        }

        public Aluno(){

        }

        public double media(){
            return (this.Nota1+this.Nota2+this.Nota3)/3;
        }

    }
}
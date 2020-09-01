namespace Atividade2
{
    public class Aluno
    {

        
        public string Nome { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Notaminima { get; set; }

        public Aluno(string nome, int nota1, int nota2, int nota3)
        {
            this.Nome = nome;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
            this.Notaminima = 60;
        }

        public int notatotal(){
            return Nota1+Nota2+Nota3;
        }

        public int faltaponto(int nota){
            return Notaminima-nota;
        }

    }
}
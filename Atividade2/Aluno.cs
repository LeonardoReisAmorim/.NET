namespace Atividade2
{
    public class Aluno
    {
        
        public string Nome { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public double Media { get; set; }

        public Aluno(string nome, int nota1, int nota2, int nota3, double media)
        {
            this.Nome = nome;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
            this.Media = media;

        }
    }
}
namespace Atividade2
{
    public class Aluno
    {

        
        public string Nome { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Notatotal { get; set; }
        public int Notaminima { get; set; }

        public Aluno(string nome, int nota1, int nota2, int nota3)
        {
            this.Nome = nome;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
            this.Notaminima = 60;
        }

        public int verificar_primeiro_semestre()
        {
            Notatotal = Nota1 + Nota2 + Nota3;
            if (Notatotal >= 30)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int verificar_segeter_semestre()
        {
            int Notatotal = Nota1 + Nota2 + Nota3;
            if (Notatotal >= 35)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int verficartotal(){
            if(Notatotal>=60){
                return Notatotal;
            }else{
                return Notaminima-Notatotal;
            }
        }

    }
}
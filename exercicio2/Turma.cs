using System.Collections.Generic;
using System.Linq;

namespace exercicio1
{
    public class Turma
    {

        public int N_turma { get; set; }
        public string Nome_turma { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Turma(int n_turma, string nome_turma)
        {
            this.N_turma = n_turma;
            this.Nome_turma = nome_turma;
            Alunos = new List<Aluno>();
        }

        public void AdicionarAluno(Aluno x){
            this.Alunos.Add(x);
        }

        public void RemoverAluno(Aluno x){
            this.Alunos.Remove(x);
        }

        public string 
    }
}
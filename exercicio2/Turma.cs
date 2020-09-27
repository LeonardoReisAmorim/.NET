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
        /*
        public void RemoverAluno(Aluno x){
            this.Alunos.Remove(x);
        }
        */
        public void RemoverAluno(string x){
            Aluno res = this.Alunos.Find(x => x.Equals(x));
            this.Alunos.Remove(res);
        }
        
        /*
        public string Listar(){
            string strValores = "";

            foreach (Aluno i in this.Alunos)
            {
                strValores += "\n" + i.ToString();
                
            }
            return strValores;
        }
        */
        public Aluno Consultar_matricula(int m){
            Aluno res = this.Alunos.Find(x => x.Matricula == m);
            return res;
        }

        public double Mostrar_media(string nome){
            Aluno res = this.Alunos.Find(x => x.Primeiro_nome.Equals(nome));

            return res.media();
        }

        public string Mostrar_nomes_e_notas_alunos(){
            string res = "";
            foreach(Aluno i in Alunos){
                res += "Primeiro nome: "+i.Primeiro_nome+"; Sobrenome: "+i.Sobrenome+"; primeira nota: "+i.Nota1+ "; segunda nota: "+i.Nota2+"; terceira nota: "+i.Nota3+"\n";
            }
            return res;
        }

        public string Todos_alunos_cadastrados(){
            string res = "";
            foreach(Aluno i in Alunos){
                res += "Primeiro nome: "+i.Primeiro_nome+"; Sobrenome: "+i.Sobrenome+"; Matricula: "+i.Matricula+"; primeira nota: "+i.Nota1+ "; segunda nota: "+i.Nota2+"; terceira nota: "+i.Nota3+"\n";
            }
            return res;
        }
    }
}
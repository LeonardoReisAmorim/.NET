using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno(333, "leo", "aa", 7,8,9);
            Aluno a2 = new Aluno(111, "caio", "ab", 6,5,3);
            Aluno a3 = new Aluno(222, "maria", "ac", 1,10,4);
            Turma turma = new Turma(1, "ds");
            turma.AdicionarAluno(a1);
            turma.AdicionarAluno(a2);
            turma.AdicionarAluno(a3);

            foreach(Aluno i in turma.Alunos){
                Console.WriteLine("Aluno: "+i.Primeiro_nome+" "+i.Sobrenome+" matricula "+i.Matricula+ " Primeira nota: "+i.Nota1+" Segunda nota: "+i.Nota2+ " Terceira nota: "+i.Nota3);
            }
        }
    }
}

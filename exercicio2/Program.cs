using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno(123, "leo", "aa", 7,8,9);
            Turma turma = new Turma(1, "ds");
            turma.AdicionarAluno(a1);
            foreach(Aluno i in turma.Alunos){
                Console.WriteLine(turma.MostrarAlunos());
            }
        }
    }
}

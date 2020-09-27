using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno(333, "leo", "aa", 7,8,9);
            Aluno a2 = new Aluno(111, "caio", "ab", 6,5,3);
            Aluno a3 = new Aluno(222, "joao", "ac", 1,10,4);
            Turma turma = new Turma(1, "ds");
            int j = 0;
            while(j==0){
                Console.WriteLine("1 - Adicionar Aluno\n2 - Remover Aluno\n3 - Consultar todos os dados do aluno pela matricula\n4 - Mostrar nome dos alunos e suas notas\n5 - Mostrar media de um aluno especifico\n6 - Listar todos os alunos cadastrados e seus dados\n7 - sair");
                int res = int.Parse(Console.ReadLine());

                switch(res){
                    case 1:
                         turma.AdicionarAluno(a1);
                         turma.AdicionarAluno(a2);
                         turma.AdicionarAluno(a3);
                         Console.WriteLine("alunos adicionados");
                    break;
                    case 2:
                         Console.WriteLine("digite o primeiro nome do aluno que quer remover");
                         string n_aluno = Console.ReadLine();
                         int resultadore = turma.RemoverAluno(n_aluno);
                         if(resultadore == 0){
                             Console.WriteLine("aluno não existe");
                         }else if(resultadore ==1){
                             Console.WriteLine("aluno removido");
                         }
                    break; 
                    case 3:
                        Console.WriteLine("digite a matricula do aluno");
                        int mat = int.Parse(Console.ReadLine());
                        Aluno resultado = turma.Consultar_matricula(mat);
                        Console.WriteLine("matricula: "+resultado.Matricula+"; primeiro nome: "+resultado.Primeiro_nome+"; sobrenome: "+resultado.Sobrenome+"; primeira nota: "+resultado.Nota1+ "; segunda nota: "+resultado.Nota2+"; terceira nota: "+resultado.Nota3); 
                    break; 
                    case 4:
                        Console.WriteLine(turma.Mostrar_nomes_e_notas_alunos()); 
                    break; 
                    case 5:
                        Console.WriteLine("digite o nome do aluno para receber a media");
                        string n = Console.ReadLine();
                        double result = turma.Mostrar_media(n);
                        Console.WriteLine("A media do aluno é: "+result); 
                    break; 
                    case 6:
                        Console.WriteLine(turma.Todos_alunos_cadastrados()); 
                    break; 
                    case 7:
                        j = 1; 
                    break; 
                    default:
                        Console.WriteLine("digite um valor valido"); 
                    break;   
                }
            }
            
            
            
            //Console.WriteLine(turma.Mostrar_nomes_e_notas_alunos());

            //Console.WriteLine(turma.Todos_alunos_cadastrados());
        }
    }
}

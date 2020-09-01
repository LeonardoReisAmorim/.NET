using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Alex", 27, 31, 32);

            Console.WriteLine("Nota final: "+a1.notatotal());

            if(a1.notatotal()>=60){
                Console.WriteLine("APROVADO");
            }else{
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM: "+ a1.faltaponto(a1.notatotal()));       
            }

        }
    }
}

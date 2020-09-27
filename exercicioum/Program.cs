using System;
using System.Collections.Generic;

namespace exercicioum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Consulta> list = new List<Consulta>();
            Consulta c1 = new Consulta();
            c1.Cpf = 123;
            c1.Idade = 18;
            c1.Nome = "leo";
            c1.Nome_medico = "deive";
            c1.Sexo = 'm';
            c1.Sobrenome = "reis";
            Console.WriteLine("digite o tipo de exame que deseja fazer");
            int te1 = int.Parse(Console.ReadLine());
            c1.Tipo_exame = te1;
            list.Add(c1);
            Consulta c2 = new Consulta();
            c2.Cpf = 132;
            c2.Idade = 36;
            c2.Nome = "anfa";
            c2.Nome_medico = "fsf";
            c2.Sexo = 'f';
            c2.Sobrenome = "fdswgd";
            Console.WriteLine("digite o tipo de exame que deseja fazer");
            int te2 = int.Parse(Console.ReadLine());
            c2.Tipo_exame = te2;
            list.Add(c2);
            Consulta c3 = new Consulta();
            c3.Cpf = 567;
            c3.Idade = 56;
            c3.Nome = "sdfe";
            c3.Nome_medico = "sgfw";
            c3.Sexo = 'm';
            c3.Sobrenome = "dsfg";
            Console.WriteLine("digite o tipo de exame que deseja fazer");
            int te3 = int.Parse(Console.ReadLine());
            c3.Tipo_exame = te3;
            list.Add(c3);

            //buscando paciente por cpf
            Console.WriteLine("digite o cpf do paciente que deseja pesquisar no sistema");
            int cpf = int.Parse(Console.ReadLine());
            Consulta rescpf = list.Find(x => x.Cpf == cpf);
            Console.WriteLine("CPF: "+rescpf.Cpf+" Idade: "+rescpf.Idade+" Nome: "+rescpf.Nome+" Sobrenome: "+rescpf.Sobrenome+ "Nome do medico: "+rescpf.Nome_medico+ " Sexo: "+rescpf.Sexo+ " tipo de exame: "+rescpf.Tipo_exame);
            Console.WriteLine("\n\n\n");

            //mostrar dados das pessoas maiores que 30 anos
            List<Consulta> listm30 = list.FindAll(x => x.Idade>30);
            foreach(Consulta i in listm30){
                Console.WriteLine("dados das pessoas maiores que 30 anos");
                Console.WriteLine("CPF: "+i.Cpf+" Idade: "+i.Idade+" Nome: "+i.Nome+" Sobrenome: "+i.Sobrenome+ "Nome do medico: "+i.Nome_medico+ " Sexo: "+i.Sexo+ " tipo de exame: "+i.Tipo_exame);
            }
            Console.WriteLine("\n\n\n");

            //mostrar exames marcados para mamografia
            List<Consulta> listmamografia = list.FindAll(x => x.Tipo_exame == 2);
            foreach(Consulta i in listmamografia){
                Console.WriteLine("dados dos exames para pacientes de mamografia");
                Console.WriteLine("CPF: "+i.Cpf+" Idade: "+i.Idade+" Nome: "+i.Nome+" Sobrenome: "+i.Sobrenome+ "Nome do medico: "+i.Nome_medico+ " Sexo: "+i.Sexo+ " tipo de exame: "+i.Tipo_exame);
            }
            Console.WriteLine("\n\n\n");

            //mostrar nome dos pacientes que marcaram exames de raio x
            List<Consulta> listnraiox = list.FindAll(x => x.Tipo_exame == 1);
            foreach(Consulta i in listnraiox){
                Console.WriteLine("nome dos pacientes que marcaram exames de raio x");
                Console.WriteLine(" Nome: "+i.Nome);
            }
            Console.WriteLine("\n\n\n");

            //excluir exame marcado do cliente
            Console.WriteLine("digite o nome do cliente que deseja excluir");
            string nome_excluir = Console.ReadLine();
            Consulta resnomeexcluir = list.Find(x => x.Nome.Equals(nome_excluir));
            list.Remove(resnomeexcluir);
            foreach(Consulta i in list){
                Console.WriteLine("dados atualizados");
                Console.WriteLine("CPF: "+i.Cpf+" Idade: "+i.Idade+" Nome: "+i.Nome+" Sobrenome: "+i.Sobrenome+ "Nome do medico: "+i.Nome_medico+ " Sexo: "+i.Sexo+ " tipo de exame: "+i.Tipo_exame);
            }
        }
    }
}

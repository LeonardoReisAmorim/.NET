namespace Atividade2
{
    public class Pessoa
    {
        
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public Pessoa(){
            
        }

        public int maioridade(int idade1, int idade2){
            if(idade1==idade2){
                return 0;
            }else if(idade1>idade2){
                return idade1;
            }else{
                return idade2;
            }
        }
    }
}
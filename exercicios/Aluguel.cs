namespace exercicios
{
    public class Aluguel
    {
        
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Aluguel(string nome, string email, int quarto)
        {
            this.Nome = nome;
            this.Email = email;
            this.Quarto = quarto;
        }

        public Aluguel(){
            
        }
    }
}
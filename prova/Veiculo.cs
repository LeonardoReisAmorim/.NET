namespace prova
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano_de_fabricacao { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }

        public Veiculo(string marca, string modelo, int ano_de_fabricacao, string color, double valor) 
        {
            this.Marca = marca;
                this.Modelo = modelo;
                this.Ano_de_fabricacao = ano_de_fabricacao;
                this.Cor = color;
                this.Valor = valor;       
        }

        public Veiculo() {}
    }
}
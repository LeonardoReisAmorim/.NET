namespace exercicios
{
    public class Produto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Valor { get; set; }

        public Produto(string marca, string modelo, double valor)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Valor = valor;
        }

        public Produto(){
            
        }
    }
}
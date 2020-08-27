namespace Hello_Word
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public double Total { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;

        }
        
        public Produto()
        {

        }

        public double valortotalestoque()
        {
            Total = Quantidade*Preco;
            return Total;
        }

        public double addprodutos(int qt){
            Total = (Quantidade+qt)*Preco;
            return Total;
        }
    }
}
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
            this.Total = quantidade*preco;

        }
        
        public Produto()
        {

        }

        public double valortotalestoque()
        {
            return Total;
        }

        public void addprodutos(int qt){
            Total = (Quantidade+qt)*Preco;
            
        }

        public void removeprodutos(int qt){
            Total = (Quantidade-qt)*Preco;
        }
    }
}
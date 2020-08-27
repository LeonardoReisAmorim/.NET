namespace Hello_Word
{
    public class produto
    {
        
        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }

        public produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;

        }

        public produto(){

        }

        public double valortotalestoque(){
            return preco*quantidade;
        }

        public int addprodutos(int qt){
            return quantidade+qt;
        }

        public int removeproduto(int qt){
            return quantidade-qt;
        }
    }
}
namespace Atividade2
{
    public class ProdutoUsado : Produto
    {
        
        public int AnoFabricacao { get; set; }

        public ProdutoUsado(int anoFabricacao,string nome, double preco) : base(nome, preco)
        {
            this.AnoFabricacao = anoFabricacao;
        }

        public override string Etiqueta(){
            return "Produto: "+this.Nome+"(usado) preço: "+this.Preco+" ano de fabricação: "+this.AnoFabricacao;
        }
    }
}
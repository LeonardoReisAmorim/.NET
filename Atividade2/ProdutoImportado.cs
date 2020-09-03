namespace Atividade2
{
    public class ProdutoImportado : Produto
    {
        
        public double TaxaImportacao { get; set; }

        public ProdutoImportado(double taxaImportacao, string nome, double preco) : base(nome, preco)
        {
            this.TaxaImportacao = taxaImportacao;
        }

        
    }
}
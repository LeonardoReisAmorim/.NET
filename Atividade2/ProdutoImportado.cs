namespace Atividade2
{
    public class ProdutoImportado : Produto
    {
        
        public double TaxaImportacao { get; set; }

        public ProdutoImportado(double taxaImportacao, string nome, double preco) : base(nome, preco)
        {
            this.TaxaImportacao = taxaImportacao;
        }

        public double precototal(){
            return this.Preco+this.TaxaImportacao;
        }
        public override string Etiqueta(){
            return "Produto: "+this.Nome+" preço: "+this.precototal()+ " (taxa de importação: "+this.TaxaImportacao+")";
        }
    }
}
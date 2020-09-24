using System.Collections.Generic;
using System.Linq;

namespace exercicios
{
    public class Compra
    {
        
        public string Comprador { get; set; }
        public int Codigo { get; set; }
        public List<Produto> Produtos { get; set; }

        public Compra(string comprador, int codigo)
        {
            this.Comprador = comprador;
            this.Codigo = codigo;
            Produtos = new List<Produto>();
        }
    }
}
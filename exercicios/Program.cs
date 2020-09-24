using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
           Produto p1 = new Produto("a", "b", 10.0);
           Produto p2 = new Produto("c", "d", 20.0);
           Produto p3 = new Produto("e", "f", 30.0);

           Compra c1 = new Compra("leo", 001);
           c1.Produtos.Add(p1);
           c1.Produtos.Add(p2);
           c1.Produtos.Add(p3);
        }
    }
}

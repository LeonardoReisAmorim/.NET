using System;
using System.Collections.Generic;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            
            Veiculo v1 = new Veiculo("ford", "fordgt", 1990, "Amarelo", 13000.00);
            Veiculo v2 = new Veiculo("ferrari", "ferrarigt", 1852, "Verde", 15000.00);
            Veiculo v3 = new Veiculo("lamborguini", "veneno", 1987, "Azul", 17000.00);
            Veiculo v4 = new Veiculo("porshe", "cayman", 1990, "Branco", 11000.00);
            Veiculo v5 = new Veiculo("Chevrolet", "onix", 1981, "Preto", 19000.00);
            Veiculo v6 = new Veiculo("lamborguini", "veneno", 1995, "Branco", 20000.00);
            
            // Adicionar veiculo novo
            veiculos.Add(v1);
            veiculos.Add(v2);
            veiculos.Add(v3);
            veiculos.Add(v4);
            veiculos.Add(v5);
            veiculos.Add(v6);

            // Imprimir todos os veiculos da lista
            Console.WriteLine("Imprimindo todos os veiculos da lista");
            foreach(Veiculo i in veiculos){
                Console.WriteLine("Marca: "+i.Marca+"; Modelo: "+i.Modelo+"; Ano de fabricação: "+i.Ano_de_fabricacao+"; Cor: "+i.Cor+"; Valor: "+i.Valor);
            }
            Console.WriteLine("\n\n");

            // Listar todos os dados dos veículos da lista de acordo com a marca solicitada
            Console.WriteLine("Listando todos os dados dos veículos da lista de acordo com a marca solicitada");
            Console.WriteLine("digite a marca");
            string marca_digitada = Console.ReadLine();
            List<Veiculo> veiculosmarca = veiculos.FindAll(x => x.Marca.Equals(marca_digitada));
            foreach(Veiculo i in veiculosmarca){
                Console.WriteLine("Marca: "+i.Marca+"; Modelo: "+i.Modelo+"; Ano de fabricação: "+i.Ano_de_fabricacao+"; Cor: "+i.Cor+"; Valor: "+i.Valor);
            }
            Console.WriteLine("\n\n");

            // Listar todos os dados dos veículos da lista de acordo com o ano de fabricação solicitado
            Console.WriteLine("Listando todos os dados dos veículos da lista de acordo com o ano de fabricação solicitado");
            Console.WriteLine("digite o ano de fabricação");
            int ano_fab_dig = int.Parse(Console.ReadLine());
            List<Veiculo> veiculosano_fab = veiculos.FindAll(x => x.Ano_de_fabricacao == ano_fab_dig);
            foreach(Veiculo i in veiculosano_fab){
                Console.WriteLine("Marca: "+i.Marca+"; Modelo: "+i.Modelo+"; Ano de fabricação: "+i.Ano_de_fabricacao+"; Cor: "+i.Cor+"; Valor: "+i.Valor);
            }
            Console.WriteLine("\n\n");

            // Listar todos os veículos com valores menores que R$ 15000.00
            Console.WriteLine("Listando todos os veículos com valores menores que R$ 15000.00");
            List<Veiculo> veiculosmenores_val = veiculos.FindAll(x => x.Valor < 15000.00);
            foreach(Veiculo i in veiculosmenores_val){
                Console.WriteLine("Marca: "+i.Marca+"; Modelo: "+i.Modelo+"; Ano de fabricação: "+i.Ano_de_fabricacao+"; Cor: "+i.Cor+"; Valor: "+i.Valor);
            }
            Console.WriteLine("\n\n");

            // Listar todos os veículos de cor branca
            Console.WriteLine("Listando todos os veículos de cor branca");
            List<Veiculo> veiculoscor_branca = veiculos.FindAll(x => x.Cor.Equals("Branco"));
            foreach(Veiculo i in veiculoscor_branca){
                Console.WriteLine("Marca: "+i.Marca+"; Modelo: "+i.Modelo+"; Ano de fabricação: "+i.Ano_de_fabricacao+"; Cor: "+i.Cor+"; Valor: "+i.Valor);
            }
            Console.WriteLine("\n\n");

            // Listar os dados dos veículos pelo modelo solicitado
            Console.WriteLine("Listando os dados dos veículos pelo modelo solicitado");
            Console.WriteLine("digite o modelo");
            string modelo_dig = Console.ReadLine();
            List<Veiculo> veiculos_modelo = veiculos.FindAll(x => x.Modelo.Equals(modelo_dig));
            foreach(Veiculo i in veiculos_modelo){
                Console.WriteLine("Marca: "+i.Marca+"; Modelo: "+i.Modelo+"; Ano de fabricação: "+i.Ano_de_fabricacao+"; Cor: "+i.Cor+"; Valor: "+i.Valor);
            }
            Console.WriteLine("\n\n");

            // Remover veículo da lista
            veiculos.Remove(v1);
            veiculos.Remove(v2);
            veiculos.Remove(v3);
            veiculos.Remove(v4);
            veiculos.Remove(v5);
            veiculos.Remove(v6);
        }
    }
}

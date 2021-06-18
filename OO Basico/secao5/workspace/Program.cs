using System;
using System.Globalization;
namespace workspace
{
    class Program
    {
        static void Main(string[] args)
        {

             Console.WriteLine("Entre os dados do produto:");
             Console.Write("Nome: ");
             string nome = Console.ReadLine();
             Console.Write("Preço: ");
             double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             Console.Write("Quantidade no estoque: ");
             int quantidade = int.Parse(Console.ReadLine());
             Console.WriteLine();
             Produto p = new Produto(nome, preco, quantidade);
             Console.WriteLine("Dados do produto: " + p);
             Console.WriteLine();
             Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
             int qte = int.Parse(Console.ReadLine());
             p.AdicionarProduto(qte);
             Console.WriteLine();
             Console.WriteLine("Dados atualizados: " + p);
             Console.WriteLine();
             Console.Write("Digite o número de produtos a ser removido do estoque: ");
             qte = int.Parse(Console.ReadLine());
             p.RemoverProduto(qte);
             Console.WriteLine();
             Console.WriteLine("Dados atualizados: " + p);

             Produto prod = new Produto(nome, preco);
            System.Console.WriteLine(prod);

            Produto ventilador = new Produto{Nome = "Ventilador", Preco = 250.00, Quantidade= 100};
            System.Console.WriteLine(ventilador);


        

             System.Console.WriteLine(p);
        }
    }
}

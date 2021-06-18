using System;
using System.Globalization;

namespace workspace{
    class Program
    {

        static void Main(string[] args){
           /*
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();
            
            System.Console.WriteLine("Entre com os valores do Triangulo X:  ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            System.Console.WriteLine("Entre com os valores do Triangulo Y:  ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double areaX = x.Area();
            double areaY = y.Area();

            //Se for igual, considera o valor de X;
            if(areaX > areaY){
                System.Console.WriteLine("Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            }else
            {
                System.Console.WriteLine("Área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            }
          
            
            Produto p = new Produto();

            System.Console.Write("Digite o nome do Produto: ");
            p.Nome = Console.ReadLine();
            System.Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Qquantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            //Não precisa colocar o .ToString, ela já chama por default, apenas passando o objeto;
            System.Console.WriteLine(p);

            double estoque = p.ValorTotalEstoque();
            System.Console.WriteLine("Valor total em estoque: "+ estoque);

            System.Console.Write("Adicionar produtos no estoque: ");
            p.AdicionarProduto(int.Parse(Console.ReadLine()));

            System.Console.WriteLine(p);
              */

             //Membros estáticosgi
              System.Console.Write("Digite o valor do raio: ");
              double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.WriteLine("Circunferência: "+ Calculadora.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture));
                System.Console.WriteLine("Volume: "+ Calculadora.Volume(raio).ToString("F2", CultureInfo.InvariantCulture));
                System.Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

       
    }
}

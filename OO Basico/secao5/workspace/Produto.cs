using System;
using System.Globalization;
namespace workspace{
    class Produto{
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque(){
            return Preco * Quantidade;

        }
        public void AdicionarProduto(int qtd){
            Quantidade += qtd;

        }
        public void RemoverProduto(int qtd){
            Quantidade -= qtd;

        }

       //Sobre-posição do método ToString da classe Object;
        public override string ToString(){
            return Nome  
            + " - R$: " 
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + " - Quantidade: "
            + Quantidade + " Unidades"
            + " - Total: " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
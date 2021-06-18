using System;
using System.Globalization;
namespace workspace{
    class Produto{
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor obriga inicializar as variáveis do objeto assim que instanciado

        public Produto(){}
        public Produto(string nome, double preco, int quantidade){
            Nome = nome;
            Preco= preco;
            Quantidade = quantidade;
        }
         public Produto(string nome, double preco){
            Nome = nome;
            Preco= preco;
           //Pode setar direto os valores (já inicia com esse valor)
            Quantidade = 10;
        }

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
using System;
using System.Globalization;
namespace workspace{
    class Produto{

        //Quando houver um lógica implementar manualmente
        private string _nome;
        //Auto proprerties (pode mudar a visibilidade tb, basta colocar o private antes do get-set)
        public double Preco { get; private set; }
        public  int Quantidade{ get; set;}

        //Construtor obriga inicializar as variáveis do objeto assim que instanciado

        public Produto(){}
        public Produto(string nome, double preco, int quantidade){
            _nome = nome;
            Preco= preco;
            Quantidade = quantidade;
        }
         public Produto(string nome, double preco){
            _nome = nome;
            Preco= preco;
           //Pode setar direto os valores (já inicia com esse valor)
            Quantidade = 10;
        }

        //#implementação de um properties definindo os métodos de get-set
      //O valor do parametro é value
        public string Nome{
            get{return _nome;}
            set{if(value != null && value.Length > 1){
                _nome = value;
                }
            }
        }
        /*
        public string GetNone(){
            return _nome;
        }

        public void SetNome(string nome){
            _nome = nome;
        }
        */
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
            return _nome  
            + " - R$: " 
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + " - Quantidade: "
            + Quantidade + " Unidades"
            + " - Total: " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
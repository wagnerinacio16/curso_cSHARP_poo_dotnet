using System;
using System.Globalization;

namespace projeto02{
    class Program{
        static void Main(string[] args){
            /*
            //Os byte vai até o 127; Quando incrementado, o mesmo retorna um valor negativo (ex: -128).
            sbyte x = 100;

          //  Console.WriteLine(x);

           
           //O byte vai até o 255; Quando incrementado, o mesmo retorna ao valor zero.
            byte n1 = 255;
            n1++;

           // Console.WriteLine(n1);
            int n2 = 1000;
            //Valor máximo do int; maior que isso, usar o long
            int n3 = 2147483647;
            //Quando tiver trabalhando com LONG, recomenda-se utilizar o L no final
            long n4 = 2147483648L;
            //Biblioteca do .net
            System.Console.WriteLine(n2);
            System.Console.WriteLine(n3);
            System.Console.WriteLine(n4);



            //# AULA 3 

            bool completo = false;
            System.Console.WriteLine(completo);
            char genero = 'F';
            System.Console.WriteLine(genero);

            //Pode usar a tebela UNICODE para colocar código de símbolos
            //Sempre usar o u para definir que é unicode
            char letra = '\u0040';
            System.Console.WriteLine(letra);

            float n5 = 8.2f;
            double n6 = 4.6;
            System.Console.WriteLine(n5);
            System.Console.WriteLine(n6);
            string nome = "Wagner";
            string sobrenome = "Inácio de Oliveira";
            //Concatenando string OBS: String é imutável, o que torna as aplicações mais seguras
            System.Console.WriteLine(nome + " "+ sobrenome);

            object obj1 =  "Animal";
            object obj2 = "Pessoa";

            System.Console.WriteLine(obj1);
            System.Console.WriteLine(obj2);

            //Existe funções para valores máximo e mínimos;
            //Pode ser usado para todos os tipos primitivos de dados;
            int n7 = int.MinValue;
            int n8 = int.MaxValue;

            System.Console.WriteLine(n7);
            System.Console.WriteLine(n8);


            //Saida de dados em C#


            double salario = 12.89760;

           Console.WriteLine(salario.ToString("F2"));
           Console.WriteLine(salario.ToString("F4", CultureInfo.InvariantCulture));

            string _nome = "Wagner Inácio de Oliveira";
           int idade = 22;
           

           //Utilizando placeholder
             Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", _nome, idade, salario);
            //Utilizando a interpolação;
            System.Console.WriteLine($"{_nome} tem {idade} anos e tem saldo igual a {salario:F2} reais");
            //Utilizando concatenação;
            System.Console.WriteLine(_nome +" tem "+ idade +" anos e tem saldo igaul a " + salario.ToString("F2") + " reais");


            //Conversão de valores e casting

            double d;
            float e;
            int f;

            d = 3.5;

            e = (float)d;
            f = (int)d;

            int g = 5;
            int h = 2;
            double resultado = (double) g/h;

            System.Console.WriteLine(resultado);


            //Operadores Aritimétiocos;
            //Fórumula Delta

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b , 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta))/(2.0*a);
            double x2 = (-b - Math.Sqrt(delta))/(2.0*a);

            System.Console.WriteLine(delta);
            System.Console.WriteLine(x1);
            System.Console.WriteLine(x2);



            //Entrada de Dados em C#

            string frase = Console.ReadLine();

            System.Console.WriteLine("Você digitou: "+ frase);

            //Utilizando o Split

            string s = Console.ReadLine();
            String[] v = s.Split(' ');
            //Pode ser feito assim tb
            string[] l = Console.ReadLine().Split(' ');

            string p = v[0];
            string o = v[1];
            string k = v[2];

            System.Console.WriteLine(s);
            System.Console.WriteLine(p);
            System.Console.WriteLine(o);
            System.Console.WriteLine(k);

            System.Console.WriteLine("X--------------------- Tipos Primitivos de Dados ---------------------X");
            //lendo tipos primitivos de Dados;
            int b1 = int.Parse(Console.ReadLine());
            char ch1 = char.Parse(Console.ReadLine());
            //Para ler o ponto.
            double d1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Você digitou: ");
            System.Console.WriteLine(b1);
            System.Console.WriteLine(ch1);
            //Assim imprime com o ponto.
            System.Console.WriteLine(d1.ToString("F2", CultureInfo.InvariantCulture));

            System.Console.WriteLine("X--------------------- Tipos Primitivos de Dados - SPLIT ---------------------X");

            System.Console.Write("Lendo os dados da Maria: ");
            string[] maria = Console.ReadLine().Split(' ');
            string _nome_ = maria[0];
            char sexo = char.Parse(maria[1]);
            int _idade = int.Parse(maria[2]);
            double altura = double.Parse(maria[3], CultureInfo.InvariantCulture);


            System.Console.WriteLine(_nome_);
            System.Console.WriteLine(sexo);
            System.Console.WriteLine(_idade);
            System.Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

           

            int a =10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;


            System.Console.WriteLine(c1);
            System.Console.WriteLine(c2);
            System.Console.WriteLine(c3);
            System.Console.WriteLine(c4);

            bool c5 = a <= 10;
            bool c6 =  a >=  10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            System.Console.WriteLine(c5);
            System.Console.WriteLine(c6);
            System.Console.WriteLine(c7);
            System.Console.WriteLine(c8);


            //Estrutura Condicional

            System.Console.Write("Digite um número inteiro: ");
            int ent = int.Parse(Console.ReadLine());


            if (ent % 2 == 0){
                System.Console.WriteLine("Número par!");
            }else{
                System.Console.WriteLine("Número impar!");
            }

            System.Console.Write("Digite a hora atual (ex: 19): ");
            int hora = int.Parse(Console.ReadLine());

            if(hora < 12){
                System.Console.WriteLine("Bom dia!");
           //Para otimizar, não precisa colocar hora >=12, pq se caiu no else, significa que a primeira é falsa 
           }else if( hora <18){
                System.Console.WriteLine("Boa tarde!");
            }else {
                System.Console.WriteLine("Boa noite!");
            }

           
            
            //Escopo e Inicialização: Uma var declarada dentro de um escopo(loop, método) só pode ser utilizada dentro do mesmo;
            //Para usar ela fora do escopo, é necessário inicializar a VAR fora do escopo;

            double preco = double.Parse(Console.ReadLine());

            if(preco >100.0){
                //desconto de 10%
                double desconto = preco * 0.1;
                //Aqui ela pode ser usada(dentro do escopo)    
                System.Console.WriteLine("Valor do desconto: " + desconto);
            }

               //-> Aqui já não pode, a não ser que a mesma fosse declarada e incialada fora do escopo do IF
               // System.Console.WriteLine("Valor do desconto: " + desconto);

               //Chama a função maior

                System.Console.WriteLine("Digite 3 números inteiros: ");
                int m1 = int.Parse(Console.ReadLine());
                int m2 = int.Parse(Console.ReadLine());
                int m3 = int.Parse(Console.ReadLine());

               int result = Maior(m1, m2, m3);
               System.Console.WriteLine("Maior número: "+ result);
            
                System.Console.Write("Digite um número: ");
                double sqrt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             
                   //Quando a condição for Verdadeira executa e volta
                   //Se FALSO ele pula fora, não executa nenhuma
                    while (sqrt >= 0.0){
                     double raiz = Math.Sqrt(sqrt);
                     System.Console.WriteLine("Raiz: " + raiz.ToString("F3", CultureInfo.InvariantCulture));
                     System.Console.Write("Digite outo número: ");
                     sqrt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                    System.Console.WriteLine("Número Negativo!");
              */

              //FOR

              System.Console.Write("Quantos números inteiros deseja digitar: ");
              int n = int.Parse(Console.ReadLine());

             int soma=0;
              for(int i = 0; i<=n-1; i++){
                  System.Console.Write("Digite o valor de #{0}: ", i+1);
                  int valor = int.Parse(Console.ReadLine());
                  soma += valor;

              }
              System.Console.WriteLine("Soma dos números: " + soma);
            
        }

        static int Maior(int a, int b, int c){
            int m=0;
            if(a > b && a > c){
                m = a;
            }else if(b > c){
                m = b;
            }else{
                m = c;
            }
            return m;
        }
    }
}

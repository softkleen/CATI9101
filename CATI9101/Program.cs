using System;
using System.Collections.Generic;

namespace CATI9101
{
    internal class Program
    {
        // atributos
        //public static int x;
        // construtores  -  criam e inicializam instância de classe 

        // métodos de acesso (get e set) - C# - Propriedades
      
        // métodos da classe - função/operação/açao do objeto
        static void Main(string[] args)
        {
            /*
             // declaração de variáveis 
             x = 10;
             var nome = "Maria";
             var teste = true;
             var valor = 12.89;
             var num = 15f;
             var y = false;

             byte[] vetor = new byte[x];// matriz de bytes
             vetor[0] = 87;
             vetor[1] = 101;
             vetor[2] = 108;
             vetor[3] = 108;
             vetor[4] = 115;
             for (int i = vetor.Length - 1; i > -1 ; -- i)
             {
                 //Console.WriteLine(vetor[i]);
             }
             // variáveis de inteiros
             byte l = 255; // 0-255
             short s = 32767; //16 bits - 65536
             s = -32768;
             s = 0;
             s = 32767;
             ushort ss = 65535; // valores positivos até 16 bits
             ss = 1;
             int w=0; //
             w = -2147483648;
             w = 2147483647;
             uint ww = 2147483648 + 2147483647;
             ulong tt = 18446744073709551615;
             long t = 9223372036854775807;
             t = -9223372036854775808;
             double A, B, C, D;
             A = 2.55;
             float c = 10.65f;
             string m = "senac";
             //m = m.Substring(2, 1);// letra "n"
             w++;
             bool chk = false;
             if (!chk)
             {
                 for (int i = 0; i < m.Length; i++)
                 {
                    //Console.WriteLine(m.Substring(i, 1));
                 }
                 chk = true;
             }
           
            // ---------------------------------------------------
            // maneiras de conversões de tipos
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine(); 
            Console.WriteLine("Digite o ano de seu nascimento:");
            //int ano = (int)Console.ReadLine(); // cast - não foi possível a conversão
            //int ano = int.Parse(Console.ReadLine()); // parse - funciona
            string ano = Console.ReadLine(); // classe Convert - funciona
            int idade = DateTime.Now.Year - int.Parse(ano);
            Console.WriteLine("Olá {0}, sua idade é {1} anos",nome,idade);
            
            bool atende = false;
            int[] vnumero = new int[10];
            string sair = string.Empty;
            int cont = 10;
            while (sair!="s" && cont > 0)
            {
                Console.WriteLine("Digite um número de 1 a 10: ");
                int numero = int.Parse(Console.ReadLine());

                do
                {
                    if (numero > 0 && numero < 11)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"{numero} x {i+1} = {numero*(i+1)}");
                            // Console.WriteLine(i+1 +"º - "+numero + " x " + (i+1) + " = " + numero * (i+1));
                        }
                        atende = true;
                    }
                    else
                    {
                        atende = false;
                        Console.WriteLine("Você deve digitar um valor entre 1 e 10");
                        numero = int.Parse(Console.ReadLine());
                    }
                   
                } while (!atende);
                cont--; // decrementa um número na variável contador
                vnumero[cont] = numero;
                
                Console.WriteLine("Deseja sair? (s) ou enter para continuar:");
                sair = Console.ReadLine();
                Console.Clear(); // limpa o console 
            }// fim do While
            Console.WriteLine();
            Console.Write("Você exibiu as tabuadas dos números ");
            foreach (var item in vnumero)
            {
                Console.Write($"{item}, ");
            }

            // declaração de matrizes
            string[] jogadores = { "José", "Paulo", "Gabriel", "Júlio", "Marcos" };
            //int[,] pontos = { {0,2 }, {1,3 }, {2,5 }, {3,4 } };
            string[] times = new string[5];
            int [,] tabela = new int[5,6];
            
            int[,] m = new int[4, 2];
            m[0,0] = 0;
            m[1,0] = 1;
            m[2,0] = 2;

            m[3,0] = 3;
            m[0,1]= 2;
                    
            foreach (string jogador in jogadores)
            {
                 Console.WriteLine(jogador);
            }
            for (int i = 0; i < jogadores.Length; i++)
            {
                Console.WriteLine("Digite o nome do {0}º jogador",(i+1));   
                jogadores[i] = Console.ReadLine();
            }

            //Minipulação de Strings
            string nome = "  Wellington Vieira dos santos  ";
            Console.WriteLine(nome + " - " + nome.Length);
            // retorna o número de caracteres
            Console.WriteLine(nome.Length);
            // removendo espaços do começo e do fim (TRIM)
            nome = nome.Trim(); 
            Console.WriteLine(nome + " - " + nome.Length);
            // exibindo os primeiros 4 caracters de nome
            Console.WriteLine(nome.Substring(0,4));
            // alterando a variável para manter apenas os primeiros 4 caracters
            // nome = nome.Substring(0,4);

            Console.WriteLine(nome.Remove(4));// mantém os 4 primeiros
            //string idade = "17";
            // Substituindo caracteres
            Console.WriteLine(nome.Replace(" ","%"));
            // insere caracteres em uma string
            Console.WriteLine(nome.Insert(4, "ll"));
            // retorma a posição da 1ª ocorrencia da string
            Console.WriteLine(nome.IndexOf("i"));

            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.ToLower());
            // divide uma string em um vetor de strings
            string[] vnome;
            vnome = nome.Split(' ');
            for (int i = 0; i < vnome.Length; i++)
            {
                Console.WriteLine(vnome[i]);
            }

            string frase = "socorra-me subi no onibus em marrocos";
            Console.WriteLine(frase);
            string fraseinv=string.Empty;
            for (int i =frase.Length -1; i > -1 ; i--)
            {
                fraseinv += frase.Substring(i, 1);
            }
            Console.WriteLine(fraseinv);

            // inverter texto convertendo para array
            char[] textoArray = frase.ToCharArray();
            Array.Reverse(textoArray);
            fraseinv = new string(textoArray);
            Console.WriteLine(fraseinv);
            Console.WriteLine();


            // Manipulação de Matrizes
            Console.WriteLine();
            int[] numeros = new int[6];
            Random random = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                int sorteado = random.Next(1,60);
                if (i==0)
                    numeros[i] = sorteado;
                else // a partir do segundo número sorteado
                {
                   if (Array.BinarySearch(numeros, sorteado) < 0)
                        numeros[i] = sorteado;
                }
                if (i != numeros.Length - 1)
                    Console.Write(numeros[i] + "-");
                else
                    Console.Write(numeros[i]);
            }
            Console.WriteLine();
            Array.Sort(numeros);// ordena os números no vetor
            for (int i = 0; i < numeros.Length; i++)
            {
                if (i != numeros.Length - 1)
                    Console.Write(numeros[i] + "-");
                else
                    Console.Write(numeros[i]);
            }
            */
            int p = 3; // número de cartões
            int j = 6; // quantidade de números por cartão
            int[,] vs = new int[p,j];
            for (int i = 0; i < p; i++)
            {
                for (int x = 0; x < j; x++)
                {
                    vs[i, x] = Sortear();
                    if (x>0)
                    {
                        while (verifica(vs,i, x, j, vs[i, x]))
                        {
                            vs[i, x] = Sortear();
                        } 
                    }
                
                
                }  
            }// matriz carregada

            // ordenar 
            for (int l = 0; l < p; l++)
            {// percorrer pelas linhas da matriz
                for (int r = 0; r < (j-1); r++)
                {
                    for (int c = r+1; c < j; c++)
                    {
                        int t;
                        if (vs[l,r]>=vs[l,c])
                        {
                            t = vs[l, r];
                            vs[l, r] = vs[l, c];
                            vs[l, c] = t;
                        }
                    }
                }
            }

            // exibe a matriz 
            Console.WriteLine();
            for (int i = 0; i < p; i++)
            {
                for (int x = 0; x < j; x++)
                {
                    Console.Write(vs[i, x] + "-");
                }
                Console.WriteLine();
            }
            
            //List<string> list = new List<string>();
            //Queue<string> queue = new Queue<string>();
            //Stack<string> stack = new Stack<string>();
            //list.Add("oi");
            //Array.BinarySearch(vs, 5);


            Console.ReadKey(); 
        }
        static int Sortear() 
        {
            Random random = new Random();
            return random.Next(1, 60); 
        }
        static bool verifica(int[,] a, int linha, int l, int j, int valor ) 
        {
            bool teste = true;
            for (int i = l-1; i < j; i++)
            {
                if (a[linha,i]==valor)
                {
                    teste = false;
                }
            }
            return teste;

        }
    }
 
}

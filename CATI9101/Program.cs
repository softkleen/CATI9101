using System;

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
            */
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




            Console.ReadKey(); 
        }

    }
 
}

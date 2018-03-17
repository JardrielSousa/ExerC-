using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma
{
    class Program
    {
        static void Main(string[] args)
        {
            //classe principal
            string n=null;
            menu(n);//metodo menu
            Console.ReadKey();
            
        }
        static int soma(int c, int d)//função
        {
            int a, b; //variaveis
            string n=null;
            Console.WriteLine("digite um número :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite um número :");
            b = Convert.ToInt32(Console.ReadLine());

            int soma = a + b;
            Console.WriteLine("======================");
            Console.WriteLine("Resultado Final:{0}",soma);
            Console.WriteLine("======================");

            menu(n);
            return soma;
        }
        static int subtrai(int c, int d)//função
        {
            int a, b; //variaveis
            string n = null;
            Console.WriteLine("digite um número :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite um número :");
            b = Convert.ToInt32(Console.ReadLine());

            int subtrai = a - b;
            Console.WriteLine("======================");
            Console.WriteLine("Resultado Final:{0}", subtrai);
            Console.WriteLine("======================");

            menu(n);
            return subtrai;
        }
        static int divide(int c, int d)//função
        {
            int a, b; //variaveis
            string n = null;
            Console.WriteLine("digite um número :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite um número :");
            b = Convert.ToInt32(Console.ReadLine());

            int divide = a / b;
            Console.WriteLine("======================");
            Console.WriteLine("Resultado Final:{0}", divide);
            Console.WriteLine("======================");

            menu(n);
            return divide;
        }
        static int multiplica(int c, int d)//função
        {
            int a, b; //variaveis
            string n = null;
            Console.WriteLine("digite um número :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite um número :");
            b = Convert.ToInt32(Console.ReadLine());

            int multiplica = a * b;

            Console.WriteLine("======================");
            Console.WriteLine("Resultado Final:{0}", multiplica);
            Console.WriteLine("======================");

            menu(n);
            return multiplica;
        }
        static string menu(string n)
        {
            string m=null;
            int a=0, b=0, opc = 0;//Menu

            Console.WriteLine("Menu");
            Console.WriteLine("======================");

            Console.WriteLine("1 - iniciar Soma");
            Console.WriteLine("2 - iniciar Subtrai");
            Console.WriteLine("3 - iniciar Divide");
            Console.WriteLine("4 - iniciar Multiplica");
            Console.WriteLine("5 - Encerrar");
            Console.WriteLine("======================");

            opc = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opc)//Estrutura de Decisão
            {
                case 1: soma(a, b);//metodo soma
                    break;
                case 2:
                    subtrai(a, b);//metodo subtrai
                    break;
                case 3:
                    divide(a, b);//metodo divide
                    break;
                case 4:
                    multiplica(a, b);//metodo multiplica
                    break;
                case 5: //finaliza o sistema
            Console.Clear();
                    Console.WriteLine("Encerrando...");
                    Console.WriteLine("Agradeço e Volte Sempre!!!");
                    break;

            }

            
            return n;
        }



    }
}

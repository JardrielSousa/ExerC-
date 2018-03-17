using System;

namespace Maiorde10num
{
    class Program
    {
        static void Main(string[] args)
        {

            int  maior=0,menor=0;//variavel com valor null
            int[] x = new int[10];//iniciando vetor

            for (int i=0;i<9;i++)//estrutura de repetição (10x)
            {
                Console.WriteLine("Digite um numero:");
                x[i] = Convert.ToInt32( Console.ReadLine());//pega os dados que o usuario digitou

                if (x[i]>maior)//estrutura de decisao pegar o maior numero
                {
                    maior = x[i];
                }
                if (x[i] <menor)
                {
                    menor = x[1];
                }

            }
            Console.WriteLine("O maior número é:{0}", maior);
            Console.WriteLine("O maior número é:{0}", menor);


            Console.ReadKey();
            }
        }
    }


    


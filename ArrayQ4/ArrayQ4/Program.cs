using System;

namespace ArrayQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];//vetor
            int positivo=0,negativo=0; //variaveis

            for ( int i=0;i<5;i++)// repetição
            {
                Console.WriteLine("Digite um número:");
                a[i] = Convert.ToInt32(Console.ReadLine());

                if (a[i] >=0)//estrutura de decisão
                {
                    positivo = positivo + 1;//incremento
                }
                if (a[i] < 0)
                {
                    negativo= negativo+1;
                }
            }
            Console.WriteLine("valores negativos:"+negativo);



            Console.ReadKey();

        }
    }
}

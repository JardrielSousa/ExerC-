using System;

namespace Atv1Q2Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int x , soma = 0;
            Console.WriteLine("Digite um numero");
            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= x;i++)
            {
                 soma = soma + i ;
                
                Console.Write(i);
                Console.WriteLine("-> soma com o valor anterior:"+soma);




            }
            Console.ReadKey();
        }
    }
}

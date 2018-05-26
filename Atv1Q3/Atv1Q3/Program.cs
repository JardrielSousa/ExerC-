using System;

namespace Atv1Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,soma;

            Console.WriteLine("Digite um valor:");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                soma = i * 2 + 1 ;
                Console.WriteLine(soma);
            }
            Console.ReadKey();
        }
    }
}

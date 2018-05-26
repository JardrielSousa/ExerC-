using System;

namespace AtvQ6SomadosParesNaSequencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i , soma=0;

            Console.WriteLine("Digite um numero , onde será determinada a soma dos números pares:");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
             
                if ( i % 2 == 0 )
                {
                    
                    soma = soma + i;
                    Console.WriteLine("número par:" + i);
                }
               
            }
            Console.WriteLine("Soma é :" + soma);
            Console.ReadKey();

        }
    }
}

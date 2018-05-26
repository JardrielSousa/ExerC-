using System;

namespace RepetePar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int contpar = 0, contimpar = 0, igual = 0,cont=1,numeros;

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Digite um número:");
                numeros = Convert.ToInt32(Console.ReadLine());
                num[i] = numeros;

              
                if (num[i]%2==0) {
                    contpar++;
                }
                else
                {
                    contimpar++;
                }
            }
            Console.WriteLine("Quantidade de números pares:"+contpar);
            Console.WriteLine("Quantidade de números impares:" + contimpar);
                

            }
            
        }
    }
}

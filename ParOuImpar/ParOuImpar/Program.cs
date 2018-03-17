using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pega os Dados do Usuário
            Console.WriteLine("Digite um numero");
            int n = Convert.ToInt32(Console.ReadLine()); //Declaração de váriavel

            int div;//Declaração de váriavel

            div = n % 2;//Operação

            if (div == 0) //Estrutura  de Decisão
            {
                Console.WriteLine("Ele é par");
            }
            else
            {
                Console.WriteLine("Ele é Impar");
            }

            Console.ReadKey();
        }

      
      
    }
}

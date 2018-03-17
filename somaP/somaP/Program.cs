using System;

namespace somaP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("======================");
            Console.WriteLine("O numero é:");
            Console.WriteLine(n1);

           

            Console.WriteLine("soma dos numeros");
            Console.WriteLine(n1);
            int soma = n1 + n1;

             Console.WriteLine("resultado da soma é:");
             Console.WriteLine(soma);
            
            Console.ReadKey();
        }
        
        }
    
    
}

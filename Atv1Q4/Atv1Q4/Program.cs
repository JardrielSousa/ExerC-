using System;

namespace Atv1Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n, cont=0, potencia=1;

            Console.WriteLine("Digite um numero inteiro:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero natural:");
            n = int.Parse(Console.ReadLine());

            while(cont != n)
            {
                potencia = potencia * x; //multiplica pelo primeiro valor digitado
                cont = cont + 1;                
            }
            Console.WriteLine("O valor {0} elevado a {1} é = {2} ", x, n, potencia);
            Console.ReadKey();
        }
    }
}

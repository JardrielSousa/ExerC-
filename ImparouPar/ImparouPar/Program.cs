using System;

namespace ImparouPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Digite um numero");
            a = Convert.ToInt32(Console.ReadLine());

            if (a%2 == 0)
            {
                Console.WriteLine("O número {0} é par !!!",a);
            }
            else
            {
                Console.WriteLine("O número {0} é Impar !!!", a);
            }
            Console.ReadKey();
        }
    }
}

using System;

namespace NumMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0, c=0;
            Console.WriteLine("Digite um numero");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um numero");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um numero");
            c = Convert.ToInt32(Console.ReadLine());

            if (a>b && a>c)
            {
                Console.WriteLine("{0} é o maior número!!!",a);
            }
            else if (b>a && b>c)
            {
                Console.WriteLine("{0} é o maior número!!!",b);
            }
            else
            {
                Console.WriteLine("{0} é o maior número!!!",c);
            }



            Console.ReadKey();


        }
        

    }
}

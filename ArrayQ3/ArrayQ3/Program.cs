using System;

namespace ArrayQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d = new int[11];
            int n, j;
            for (n=0;n<10;n++)
            {
                

                Console.WriteLine("digite um numero:");
               d[n] = Convert.ToInt32(Console.ReadLine());
            }

            for ( j = 0; j < 10; j++)
            {
                

                Console.WriteLine("n{0}:{1}", j,d[j]);
                
             
            }
            Console.ReadKey();
        }

    }
}

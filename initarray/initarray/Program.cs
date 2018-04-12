using System;

namespace initarray
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] array = new int[10];
            int n, j;

            for (n=0;n<10;n++)
            {
                array[n] = n + 100;
            }
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("element[{0}] = {1}",j,array[j]);
            }





          
            Console.ReadKey();
        }
    }
}

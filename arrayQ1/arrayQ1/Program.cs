using System;

namespace arrayQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[11];
            int i;
            for (i = 1; i <11; i++)
            {
              
                n[i] = 11-i;
                //Array.Reverse(n);
                Console.WriteLine("n:{0}", n[i]);
                
            }
            Console.ReadKey();

        }
    }
}

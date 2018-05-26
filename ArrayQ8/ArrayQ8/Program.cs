using System;

namespace ArrayQ8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            
       

            for (int i=0;i<array.Length;i++)
            {
                Console.WriteLine("Digite um numero [0-9]:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0;i<array.Length;i++)
            {
                Console.WriteLine("O número é:" + array[i]);
                
            }
            Console.ReadKey();
        }
    }
}

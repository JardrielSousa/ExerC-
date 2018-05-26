using System;

namespace ArrayQ9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];

            for (int i=0;i<array.Length;i++)
            {
                Console.WriteLine("digite um numero");
                array[i] = Convert.ToInt32(Console.ReadLine());
             }
            for (int i=0;i<array.Length;i++) {
                if (array[i]%2==0)
                {
                    Console.WriteLine("+1");
                }
                else
                {
                    Console.WriteLine("-1");
                }
            }
            Console.ReadKey();
         }
    }
}

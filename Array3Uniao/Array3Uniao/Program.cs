using System;

namespace Array3Uniao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            int[] b = new int[3];

            for (int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadKey();
        }
    }
}

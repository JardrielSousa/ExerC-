using System;

namespace ArrayQ1C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d = new int[6];
            int[] e = new int[6];
            int i;
            for(i=1;i<d.Length;i++)
            {

                d[i] = i+0;
                Console.WriteLine(d[i]);
                
            }
            for (i = 1; i < d.Length; i++)
            {

                
                e[i] = i * 10;
                Console.WriteLine(e[i]);
            }


            Console.ReadKey();
        }
    }
}

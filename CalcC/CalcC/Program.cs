using System;

namespace CalcC
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc n1 = new Calc();
            
            n1.soma();
            n1.multi();
            n1.div();
            n1.sub();
            Console.ReadKey();
        }
    }
}

using System;


namespace CalcGraus
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0, c;

            Console.WriteLine("Digite a temperatura");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("temperatura em Celsius:{0}", c);
            Console.WriteLine(soma(f, c));

            Console.ReadKey();

        }
        static int soma(int f, int c)
        {
            return f = (9 * c + 160) / 5;
        }
    }
}

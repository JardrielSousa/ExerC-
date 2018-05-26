using System;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            int d=0;
            Cadastro c = new Cadastro();
            c.dados();

            Console.WriteLine("digite um numero");
            d = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {
                case 1:
                    break;
            }
        }
    }
}

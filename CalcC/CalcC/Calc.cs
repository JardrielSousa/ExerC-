using System;
using System.Collections.Generic;
using System.Text;

namespace CalcC
{
    class Calc
    {
        double a, b; 


       public void dados()
        {
            Console.WriteLine("Digite um numero");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um numero");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public void  soma()
        {
            dados();
            double soma = a + b;
            Console.WriteLine( soma);
        }
        public void sub()
        {
            double sub = a - b;
            Console.WriteLine(sub);
        }
        public void div()
        {
            double div = a / b;
            Console.WriteLine(div);
        }
        public void multi()
        {
            double mul = a * b;
            Console.WriteLine(mul);
        }
    }
}

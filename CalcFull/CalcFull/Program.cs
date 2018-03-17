using System;

namespace CalcFull
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, opc = null;
            double a = 0, b = 0;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Olá {0}, seja bem Vindo a Call full", nome);

            Console.WriteLine("=======================================================================");
            Console.WriteLine("Aqui escolheremos uma Opção,uma operação matemática");
            Console.WriteLine("=======================================================================");

            Console.WriteLine("");
          
            Console.WriteLine("Digite o primeiro valor");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o primeiro valor");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite uma operação");
            opc = Console.ReadLine();
            switch (opc)
            {
                case "+":
                    Console.WriteLine("O resultado é:{0}", adicao(a, b));

                    break;
                case "-":
                    Console.WriteLine("O resultado é:{0}", subtracao(a, b));
                    break;
                case "/":
                    Console.WriteLine("O resultado é:{0}", divisao(a, b));
                    break;
                case "*":
                    Console.WriteLine("O resultado é:{0}", multiplicação(a, b));
                    break;

            }

            Console.ReadKey();
        }
        static void calc()
        {
          
        }
       static double adicao(double a , double b)
        {
           

            return a + b;
        }
        static double subtracao(double a, double b)
        {
      

            return a - b;
        }
        static double divisao(double a, double b)
        {
            
            return a / b;
        }
        static double multiplicação(double a, double b)
        {
            
            return a * b;
        }
    }
}

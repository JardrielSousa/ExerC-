using System;

namespace Atv1Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0, divisor, eprimo;

            Console.WriteLine("========Teste de primaridade=========");
            Console.WriteLine("Digite um numero");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <=1)
            {

                eprimo = 0;//se for menor que n , inicia a 0
            }
            else
            {
                eprimo = 1;//se n for maior que 1 , inicia 1

            }
            divisor = 2;//inicia divisor com 2
            while (divisor <= n / 2 && eprimo ==1) //divide o n por 2 e pega eprimo da estrutura anterior
            {
                if (n % divisor == 0)//se a divisão de n e divisor for igual a 0 não é primo
                {
                    eprimo = 0;
                }
                divisor++;//se não é primo
            }
            if (eprimo==1)
            {
                Console.WriteLine("é primo");
            }
            else
            {
                Console.WriteLine("não é primo");
            }
            Console.ReadKey();
        }
    }
}

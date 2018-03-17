using System;

namespace MediacomNome
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            string nome;
            double a = 0, b = 0;
            
            //pega os dados do usuario
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua nota teorica");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua nota pratica");
            b = Convert.ToInt32(Console.ReadLine());

            //chama e executa o metodo media
            Console.WriteLine(media(a,b));
            Console.ReadKey();
        }
        static double media(double pratica , double teorica)//metodo media
        {
            double npra, nteo, m;//variaveis locais do metodo

            nteo = teorica / 2 ;//operações
            npra = pratica / 1;
            m = (nteo + npra) / 2;

            return m;


        }

      

    }
}

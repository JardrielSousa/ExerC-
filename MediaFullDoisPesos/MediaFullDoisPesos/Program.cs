using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCompleta
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double npra, nteo;


            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("digite sua nota teoria:");
            nteo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite sua nota pratica:");
            npra = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Notas do Aluno:{0}", nome);

            Console.WriteLine("Sua nota é :{0}", media(npra, nteo));

            Console.ReadKey();
        }
        static double media(double pratica, double teoria)
        {

            double npra = pratica/1 * 1;
            double nteo = teoria/2 *2;
            double m = (npra + nteo) / 2;

            return m;


        }

    }
}

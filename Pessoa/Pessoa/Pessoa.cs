using System;
using System.Collections.Generic;
using System.Text;

namespace Pessoa
{
    class Pessoa
    {
        private string nome;
        private int idade;

       public void dados()
        {
            Console.WriteLine("Qual seu nome ?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade ?");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("seu nome é {0}",nome,"e tem:{1}",idade);
        }

        public void fazniver()
        {
            idade++;
            Console.WriteLine("Esse ano terá " + idade + " de idade !!!");
            Console.ReadKey();
        }
    }
}

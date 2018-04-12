using System;
using System.Collections.Generic;
using System.Text;

namespace Pessoa
{
    class Pessoa
    {
<<<<<<< HEAD
        private string nome;
        private int idade;
=======
        string nome;
        int idade;
>>>>>>> 7b037e740bd95b293fb655fce8a6d4f237eed5dc

       public void dados()
        {
            Console.WriteLine("Qual seu nome ?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade ?");
            idade = Convert.ToInt32(Console.ReadLine());

<<<<<<< HEAD
            Console.WriteLine("seu nome é {0}",nome,"e tem:{1}",idade);
=======
            Console.WriteLine("seu nome é{0}",nome,"e tem:{1}",idade);
>>>>>>> 7b037e740bd95b293fb655fce8a6d4f237eed5dc
        }

        public void fazniver()
        {
            idade++;
<<<<<<< HEAD
            Console.WriteLine("Esse ano terá " + idade + " de idade !!!");
=======
            Console.WriteLine("terá " + idade + " de idade !!!");
>>>>>>> 7b037e740bd95b293fb655fce8a6d4f237eed5dc
            Console.ReadKey();
        }
    }
}

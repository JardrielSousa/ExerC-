using System;

namespace ExecAtendimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta n = new Conta();
            n.dados();

            Console.WriteLine("===========================================");
            Console.WriteLine("Nome é {0}",n.Nome);
            Console.WriteLine("cpf:{0}", n.Cpf);
            Console.WriteLine("com saldo : {0}", n.Saldo);
            Console.ReadKey();

        }
    }
}

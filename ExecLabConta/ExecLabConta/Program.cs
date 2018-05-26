using System;

namespace ExecLabConta
{
    class Program
    {
        static void Main(string[] args)
        {
            int codRed;
            double sld;
            Conta obj1 = new Conta(1,100);
            obj1.creditar(50);
            obj1.consultarSaldo();
            
           
            Console.WriteLine("Seu saldo é:");
            Console.ReadKey();
        }
    }
}

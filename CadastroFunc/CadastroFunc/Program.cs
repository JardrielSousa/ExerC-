using System;

namespace CadastroFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            double aumento = 0 ;
            Func n1 = new Func();
            n1.pegadados();
            n1.bonifica(0);
            n1.demite();
        }
    }
}

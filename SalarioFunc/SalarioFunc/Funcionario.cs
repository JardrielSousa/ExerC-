using System;
using System.Collections.Generic;
using System.Text;

namespace SalarioFunc
{
    class Funcionario
    {
        public string nome,sobrenome;
        public int horastrabralhadas;
        public double valorporhora;


       public void nomecompleto()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome");
            sobrenome = Console.ReadLine();

            Console.WriteLine("Seu nome completo é:{0} {1}",nome,sobrenome);
            Console.ReadKey();

        }
        public void calcsalario()
        {
            Console.WriteLine("Quantas Horas Trabalhadas ?");
            horastrabralhadas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o valor ganho por Hora ?");
            valorporhora = Convert.ToDouble(Console.ReadLine());

            double salario = horastrabralhadas * valorporhora ;

            Console.WriteLine("Valor do salário é:{0}",salario);
            Console.ReadKey();
        }
    
    }
}

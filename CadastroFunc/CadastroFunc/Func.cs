using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFunc
{
    class Func
    {
        string nome;
        string departamento;
        double salario ;
        DateTime dataentrada;
        string rg;
        bool estanaempresa;

        public void pegadados()
        {
            Console.WriteLine("Nome do funcionario?");
            nome = Console.ReadLine();
            Console.WriteLine("Departamento que trabalha?");
            departamento = Console.ReadLine();
            Console.WriteLine("Qual salario do funcionario?");
            salario = Convert.ToDouble(Console.ReadLine());
           // Console.WriteLine("Qual data da entrada do funcionario ?");
            //dataentrada = Convert.ToDateTime(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Qual o rg?");
            rg = Console.ReadLine();
            Console.WriteLine("Ainda trabalha na empresa ?");
            Console.WriteLine("True para sim // e falso pra não ?");
            estanaempresa = Convert.ToBoolean(Console.ReadLine());


        }


        public double bonifica( double aumento)
        {
            double bonus=0;
            Console.WriteLine("valor da bonificação em Reais");
            bonus = Convert.ToDouble(Console.ReadLine());
            aumento = salario + bonus;
            Console.WriteLine("Valor do salario:" + aumento);
            return aumento;
        }
        public void demite()
        {


            if (estanaempresa==true)
            {
                Console.WriteLine("Funcionário Está trabalhando");
            }
            else
            {
                Console.WriteLine("Funcionário Foi demitido!!!");
            }
            Console.ReadKey();
        }

     
        
    }
}

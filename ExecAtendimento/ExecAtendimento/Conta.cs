using System;
using System.Collections.Generic;
using System.Text;

namespace ExecAtendimento
{
    class Conta
    {
        
        
            private string numero;
            private int cpf;
            private double saldo;
            private double limite= 100;
        


        public string Numero{
            get {
                return numero;
            }
            set {
                numero = value;
            }
            }
        public int Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }
        public double Limite
        {
            get
            {
                return limite;
            }
            set
            {
                limite = value;
            }
        }

        public void dados()
        {
            Console.WriteLine("Digite seu nome");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite seu CPF");
            Cpf = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu Numero da Conta ");
            Saldo = Convert.ToDouble(Console.ReadLine());

        }



    }
}

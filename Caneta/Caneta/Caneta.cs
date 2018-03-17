using System;
using System.Collections.Generic;
using System.Text;

namespace Caneta
{
    class Caneta
    {
        string modelo;
        string cor;
        
        double ponta;
        bool tampada;

        public void dados()
        {
            Console.WriteLine("Qual o modelo da Caneta?");
            modelo = Console.ReadLine();

            Console.WriteLine("Qual a cor?");
            cor = Console.ReadLine();

            Console.WriteLine("Espesurra da Ponta ?");
            ponta = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Quer Escrever?");
            tampada = Convert.ToBoolean(Console.ReadLine());
            
            Console.Clear();




            Console.WriteLine("=============DADOS==================");
            Console.WriteLine("Modelo:{0}",modelo);
            Console.WriteLine("Cor:{0}", cor);
            Console.WriteLine("Ponta:{0}", ponta);
            if (tampada == true)
            {
                Console.WriteLine("Não pode escrever!!!");
            }
            else
            {
                Console.WriteLine(" pode escrever!!!");
            }


        }
        public void escrever()
        {
            int opc=0;
            Console.WriteLine("Voce Quer a Caneta:");
            Console.WriteLine("1_Destampada");
            Console.WriteLine("2_Tampada");
            switch (opc)
            {
                case 1:
                    this.destampada();
                    break;
                case 2:
                    this.tampada1();
                    break;
            }

            Console.WriteLine(opc);
        }
        public void destampada()
        {
            this.tampada = false;
            Console.WriteLine("Pode Escrever!!!");
        }
        public void tampada1()
        {
            this.tampada = true;
            Console.WriteLine("Não Pode Escrever!!!");

        }
        

    }
}

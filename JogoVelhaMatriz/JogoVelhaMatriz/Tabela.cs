using System;
using System.Collections.Generic;
using System.Text;

namespace JogoVelhaMatriz
{
    class Tabela
    {   
        public void Tabela2()
        {

            string[,] tabuleiro = new string[3, 3];
            int a = 0;
            int i;
            tabuleiro[0, 0] = "1";
            tabuleiro[0, 1] = "2";
            tabuleiro[0, 2] = "3";

            tabuleiro[1, 0] = "4";
            tabuleiro[1, 1] = "5";
            tabuleiro[1, 2] = "6";

            tabuleiro[2, 0] = "7";
            tabuleiro[2, 1] = "8";
            tabuleiro[2, 2] = "9";
            Console.WriteLine("       1     2     3");
            Console.WriteLine("    -------------------");
            Console.Write(" A  ");
            for (i = 0; i < 3; i++)
            {
                Console.Write(" |  " + tabuleiro[0, i]);
            }

            Console.WriteLine(" |  ");

            Console.WriteLine("    -------------------");
            Console.Write(" B  ");
            for (i = 0; i < 3; i++)
            {

                Console.Write(" |  " + tabuleiro[1, i]);
            }
            Console.WriteLine(" | ");
            Console.WriteLine("    -------------------");
            Console.Write(" C  ");
            for (i = 0; i < 3; i++)
            {

                Console.Write(" |  " + tabuleiro[2, i]);
            }
            Console.WriteLine(" | ");
            Console.WriteLine("    -------------------");

        }
    }
}
       

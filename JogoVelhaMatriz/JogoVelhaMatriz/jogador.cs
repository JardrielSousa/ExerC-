using System;
using System.Collections.Generic;
using System.Text;

namespace JogoVelhaMatriz
{
    class jogador
    {
        public void Jogador()
        {
            string[,] tabuleiro = new string[3, 3];
            
            int x, o;
            

                Console.WriteLine("Jogador 1 : 'X' ");
                x = Convert.ToInt32(Console.ReadLine());

                    if(x == 1)
                     {

                tabuleiro[0, 0] = "X";
            }
                    if (x == 2)
                    {
                tabuleiro[0, 1] = "X";
                //Console.WriteLine("X", play[0, 1]);
            }
                    if(x == 3)
                     {
                tabuleiro[0, 2] = "X";
                //Console.WriteLine("X", play[0, 2]);
            }
                    if(x == 4)
                     {
                tabuleiro[1, 0] = "X";
                //Console.WriteLine("X", play[1, 0]);
            }
                    if (x == 5)
                     {
                tabuleiro[1, 1] = "X";
                //Console.WriteLine("X", play[1, 1]);
            }
                    if (x == 6)
                    {
                tabuleiro[1,2] = "X";
                //Console.WriteLine("X", play[1,2]);
            }
                    if (x == 7)

            {
                tabuleiro[2, 0] = "X";
                //Console.WriteLine("X", play[2, 0]);
            }
                    if (x == 8)
                    {
                tabuleiro[2, 1] = "X";
                //Console.WriteLine("X", play[2, 1]);
            }
                    if (x == 9)
                    {
                tabuleiro[2,2] = "X";
                //Console.WriteLine("X", play[2, 2]);
            }
                    if (x == 6)
                    {
                tabuleiro[2, 2] = "X";
            }


            Console.Clear();
            
        }
    }
}

using System;

namespace AtvJogodaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] posição = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            tabela n = new tabela();
            n.tabela2();
            string res=null;
            int cont_jogada,jogada,vez=0;
            do { 

                cont_jogada = 1;
                for (int i=0;i<=8;i++)
                {
                    posição[i] = " ";
                }
                do
                {
                    //n.tabela2();
                    Console.WriteLine("Digite uma posição [1-9]");
                    jogada = Convert.ToInt32(Console.ReadLine());
                    if (jogada < 1 || jogada > 9)
                    {
                        jogada = 0;
                    } else if (posição[jogada-1] != "")
                    {
                        jogada = 0;
                    }
                    else
                    {
                        if (vez%2==0)
                        {
                            Console.Write(posição[jogada-1]="X");
                        }
                        else
                        {
                            Console.Write(posição[jogada - 1] = "0");
                        }
                        cont_jogada++;
                        vez++;
                    }
                } while (cont_jogada <= 9);
                n.tabela2();
                Console.WriteLine("Deseja jogar novamente?[S/n]");
                res = Console.ReadLine();
                
            }while (res=="s");

            Console.ReadKey();
        }
    }
}

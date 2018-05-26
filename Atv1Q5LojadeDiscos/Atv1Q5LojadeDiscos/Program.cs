using System;

namespace Atv1Q5LojadeDiscos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] venda = new int[5];
            int dia=0, maior=0, i;
            int soma = 0;
            for (i=1;i<venda.Length;i++)
            {
                Console.WriteLine("vendas do dia {0}",i);
                venda[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 1; i < venda.Length; i++)
            {
                if (venda[i]>maior)//pega o valor da maior venda
                {
                    maior = venda[i]; // atribui a variavel maior 
                    dia = i; // pega o dia em que aconteceu a maior venda
                }

                soma = soma + venda[i]; // faz a soma da quantidade de discos vendidos
                
            }
            Console.WriteLine("==============Resultado==================" );
            Console.WriteLine("O dia com maior número de vendas : dia " + dia);
            Console.WriteLine("numero de discos vendidos no dia {0}: {1}" , dia , maior);
            Console.WriteLine("total de discos vendidos no mês:" + soma);
            Console.ReadKey();
        }
    }
}

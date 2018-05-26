using System;

namespace ContRepetidosVet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            int numeros=0,num=0,i,x;
            int cont = 1;
            
            for (i = 0; i < n.Length; i++)
            {
                Console.WriteLine("Digite um numero:");
                n[i] = Convert.ToInt32(Console.ReadLine());
                n[i] = numeros;
                for (i = 0; i < n.Length; i++)

                {
                    cont = 0;
                    
                    for (int j = 0; j < n.Length; j++)
                    {
                        

                        if (n[i] == n[j])
                        {
                            cont++;
                            
                        }

                        

                    }
                }

            }
            
            
          
            Console.WriteLine("Numeros repetidos"+cont);
            Console.ReadKey();
        }
    }
}

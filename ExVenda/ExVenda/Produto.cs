using System;

namespace ExVenda
{
    class Produto
    {
        private int cod;
        private string nome;
        private decimal valor;
        
        
       public int Cod
        {
            get;
            set;
        }
        public string Nome
        {
           
            get;
            set;
        }
        public decimal Valor
        {
            get;
            set;
        }

        public void listarProduto()
        {
            string[] itens = new string[5];
            int[] valor = new int[5];
            itens[0] = "cafe";
            itens[1] = "Arroz";
            itens[2] = "feijao";
            itens[3] = "macarrão";
            itens[4] = "carne de lata";

            valor[0] = 5;
            valor[1] = 3;
            valor[2] = 3;
            valor[3] = 2;
            valor[4] = 5;
            Console.WriteLine("=========Tabela de Preços=============");
            Console.WriteLine("Produtos            Valores ");
            for (int i=0;i<itens.Length;i++)
            {
               
                Console.Write("{0}", itens[i]);
                Console.Write("          {0}", valor[i]);
                Console.Write("\n");
            }
            
            
           

            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExVenda
{
    class Venda:Produto
    {
        private int cod;
        private DateTime data;
        private decimal total_notas ;
        Item itens = new Item();
        public void Abrirvenda()
        {
            Console.WriteLine("Abrindo Venda...");
            listarProduto();
            Calculartotal();
            Console.ReadKey();

            
        }
        public void EncerrarVenda()
        {
            Console.Clear();
            Console.WriteLine("Fechando Venda...");
            
        }
        private void Calculartotal()
        {
            
                
           
               
           
       
                 

        }
    }
}

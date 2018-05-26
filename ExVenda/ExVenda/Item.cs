using System;
using System.Collections.Generic;
using System.Text;

namespace ExVenda
{
    class Item:Produto
    {
        private int quantidade;
        private decimal total;
          
       public int Quantidade
        {
            get {
                return quantidade;
            }
            set {
                total = quantidade * Valor; 

            }
        }     

        public void menu()
        {
            int a=0;
            Console.WriteLine("==========menu==============");
            Console.WriteLine(" 1 - Iniciar Venda");
            Console.WriteLine(" 2 - Lista de Produtos");
            Console.WriteLine(" 3 - Cadastro de Produtos");
            Console.WriteLine(" 4 - Fechar Venda");
            Console.WriteLine("============================");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.Clear();
                    Venda b = new Venda();
                    b.Abrirvenda();         
                    break;

                case 2:                    
                    Produto d = new Produto();
                    d.listarProduto();
                    break;

                case 3:
                    Venda c = new Venda();
                    c.EncerrarVenda();
                    break;

                case 4:
                    Venda i = new Venda();
                    i.EncerrarVenda();
                    break;

                default: Console.WriteLine("Selecione uma opção valida!!!");
                    Console.Clear();
                    menu();  
                    break;

            }
            
        }

    }
    
    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    class Estoque
    {
        private string nomeproduto;
        private int codproduto;
        private int produtoatual;
        private int totalprodutos;


        public void incluirProduto()
        {
            produtoatual = produtoatual + 1;     
            
        }
    }
}

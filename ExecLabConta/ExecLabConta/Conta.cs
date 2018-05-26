using System;
using System.Collections.Generic;
using System.Text;

namespace ExecLabConta
{
    class Conta
    {
        private int numero;
        private double saldo;

        public Conta(int num,
            double valor){
            
            
           
        }
        public void creditar(double valor)
        {
            valor = saldo + valor;
        }        

        public int debitar( int valor) {
            return valor;
        }
        public double consultarSaldo()
        {
            
            return saldo;
        }
    }
}

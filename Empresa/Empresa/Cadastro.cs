using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    class Cadastro
    {
        
        private string nome;
        private int cpf;
        private string endereco;
        private DateTime datacadastro;

        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }
        public int Cpf
        {
            get
            {
                return this.cpf;
            }
            set
            {
                this.cpf = value;
            }
        }
        public string Endereco
        {
            get
            {
                return this.endereco;
            }
            set
            {
                this.endereco = value;
            }
        }
        
        public void dados()
        {
            Console.WriteLine("Digite o nome da cliente");
            Nome = Console.ReadLine();
            Console.WriteLine("Endereço do cliente");
            Endereco = Console.ReadLine();
            Console.WriteLine("Cpd da nome da cliente");
            Cpf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nome:"+Nome);
            Console.WriteLine("Endereço:" + Endereco);
            Console.WriteLine("Cpf:" + Cpf);
        }
        }

    }


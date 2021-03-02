using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto01.Entidades
{
    class Cliente
    {
        private int codigo;
        private string nome;
        private string email;

        public int Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }
        public string Email
        {
            set { email = value; }
            get { return email; }
        }
    }
}

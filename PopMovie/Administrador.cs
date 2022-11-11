using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopMovie
{
    public class Administrador
    {
        private string nome;
        private string email;
        private string senha;

        public Administrador(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public string getNome() { return nome; }
        public string getEmail() { return email; }
        public string getSenha() { return senha; }


    }
}

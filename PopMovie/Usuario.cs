using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopMovie
{
    public class Usuario
    {
        private string nome;
        private DateTime dataCadastro;
        private DateTime dataNascimento;
        private string email;
        private string senha;

        public Usuario(string nome, string email, DateTime dataCadastro, DateTime dataNascimento, string senha)
        {
            this.nome = nome;
            this.dataCadastro = dataCadastro;
            this.dataNascimento = dataNascimento;
            this.email = email;
            this.senha = senha;
        }

        public string getNome() { return nome; }
        public string getEmail() { return email; }
        public DateTime getDataCadastro() { return dataCadastro; }
        public DateTime getDataNascimento() { return dataNascimento; }
        public string getSenha() { return senha; }

    }
}

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
        private int totalFilmes;
        private int totalMinutos;

        public Usuario(string nome, DateTime dataCadastro, DateTime dataNascimento, string email, string senha, int totalFilmes, int totalMinutos)
        {
            this.nome = nome;
            this.dataCadastro = dataCadastro;
            this.dataNascimento = dataNascimento;
            this.email = email;
            this.senha = senha;
            this.totalFilmes = totalFilmes;
            this.totalMinutos = totalMinutos;
        }

        public string getNome() { return nome; }
        public string getEmail() { return email; }
        public DateTime getDataCadastro() { return dataCadastro; }
        public DateTime getDataNascimento() { return dataNascimento; }
        public string getSenha() { return senha; }
        public int getTotalFilmes() { return totalFilmes; }
        public int getTotalMinutos() { return totalMinutos; }

    }
}

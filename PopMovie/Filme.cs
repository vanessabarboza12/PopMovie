using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopMovie
{
    public class Filme
    {
        public string nome;
        public int anoLancamento;
        public int classificacao;
        public int duracao_min;
        public double notaImdb;
        public string genero;
        public string sinopse;
        public string diretor;

        public Filme(string nome, int ano, int classificacao, int duracao, double nota, string genero, string sinopse, string diretor) { 
            this.nome = nome;
            this.anoLancamento = ano;
            this.classificacao = classificacao;
            this.duracao_min = duracao;
            this.notaImdb = nota;
            this.sinopse = sinopse;
            this.diretor = diretor;
        }
    }
}

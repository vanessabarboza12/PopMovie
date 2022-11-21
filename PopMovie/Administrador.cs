using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool adicionarFilme (MySqlConnection conexaoBanco, Filme filme)
        {
            try
            {
                conexaoBanco.Open(); // abertura de conexão com o banco
                MySqlCommand cmdCadastroFilme = new MySqlCommand(); // criação de comando
                cmdCadastroFilme.Connection = conexaoBanco; // atribui uma conexão para o comando (obrigatório)
                //abaixo é definido o comando sql para mysqlcommand criado
                cmdCadastroFilme.CommandText = "INSERT INTO tb_filme (nome, ano_lancamento, classificacao, duracao_min, genero, nota_imdb, sinopse, diretor)" +
                                    "VALUES ( @nome, @ano_lancamento, @classificacao, @duracao_min, @genero, @nota_imdb, @sinopse, @diretor)";

                //atribuição dos valores para cada parâmetro necessário na consulta sql
                cmdCadastroFilme.Parameters.AddWithValue("nome", filme.nome);
                cmdCadastroFilme.Parameters.AddWithValue("ano_lancamento", filme.anoLancamento);
                cmdCadastroFilme.Parameters.AddWithValue("classificacao", filme.classificacao.ToString());
                cmdCadastroFilme.Parameters.AddWithValue("duracao_min", filme.duracao_min);
                cmdCadastroFilme.Parameters.AddWithValue("genero", filme.genero);
                cmdCadastroFilme.Parameters.AddWithValue("nota_imdb",filme.notaImdb);
                cmdCadastroFilme.Parameters.AddWithValue("sinopse", filme.sinopse);
                cmdCadastroFilme.Parameters.AddWithValue("diretor", filme.diretor);
                cmdCadastroFilme.ExecuteNonQuery(); //executa o comando sql (lembrando que 'ExecuteNonQuery' não retorna valores)
                cmdCadastroFilme.Dispose(); //liberação da memória utilizada pelo 'cmdCadastro'
                MessageBox.Show("Filme cadastrado com sucesso!");
                return true;
            }
            finally
            {
                if (conexaoBanco != null) conexaoBanco.Close(); //fechamento da coneexão com o banco;
            }
        }

        public void removerFilme(MySqlConnection conexaoBanco, int idFilme)
        {
            try
            {
                conexaoBanco.Open(); // abertura de conexão com o banco
                MySqlCommand cmdRemoveFilme = new MySqlCommand(); // criação de comando
                cmdRemoveFilme.Connection = conexaoBanco; // atribui uma conexão para o comando (obrigatório)
                //abaixo é definido o comando sql para mysqlcommand criado
                cmdRemoveFilme.CommandText = "DELETE FROM tb_filme where id = @id";

                //atribuição dos valores para cada parâmetro necessário na consulta sql
                cmdRemoveFilme.Parameters.AddWithValue("id", idFilme);
                cmdRemoveFilme.ExecuteNonQuery(); //executa o comando sql (lembrando que 'ExecuteNonQuery' não retorna valores)
                cmdRemoveFilme.Dispose(); //liberação da memória utilizada pelo 'cmdCadastro'
                MessageBox.Show("Filme de id "+ idFilme + " removido com sucesso!");
            }
            finally
            {
                if (conexaoBanco != null) conexaoBanco.Close(); //fechamento da coneexão com o banco;
            }
        }


    }
}

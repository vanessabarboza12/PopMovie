using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopMovie
{
    public class Telespectador
    {
        private string nome;
        private DateTime dataCadastro;
        private DateTime dataNascimento;
        private string email;
        private string senha;
        private int totalFilmes;
        private int totalMinutos;

        public Telespectador(string nome, DateTime dataCadastro, DateTime dataNascimento, string email, string senha, int totalFilmes, int totalMinutos)
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

        public void adicionarAvaliacao(MySqlConnection conexaoBanco, string emailTelespectador, int idFilme, double nota, string comentario)
        {
            try
            {
                conexaoBanco.Open(); // abertura de conexão com o banco;

                // Trecho abaixo é para pegar o id do telespectador logado para poder adicionar corretamente na tabela;
                MySqlCommand cmdPegaIdTelespectador = new MySqlCommand();
                cmdPegaIdTelespectador.Connection = conexaoBanco;
                cmdPegaIdTelespectador.CommandText = "SELECT id FROM tb_telespectador where email=@email";
                cmdPegaIdTelespectador.Parameters.AddWithValue("email", emailTelespectador);
                MySqlDataReader leitor = cmdPegaIdTelespectador.ExecuteReader();
                leitor.Read();
                int idTelespectador = leitor.GetInt32(0);
                leitor.Close();

                MySqlCommand cmdEnvioAvaliacao = new MySqlCommand(); // criação de comando
                cmdEnvioAvaliacao.Connection = conexaoBanco; // atribui uma conexão para o comando (obrigatório)
                //abaixo é definido o comando sql para mysqlcommand criado
                cmdEnvioAvaliacao.CommandText = "INSERT INTO tb_avaliacaofilme (id_telespectador, id_filme, nota_pessoal, comentario, data_avaliacao)" +
                                    "VALUES (@id_telespectador, @id_filme, @nota, @comentario, @data)";
                //atribuição dos valores para cada parâmetro necessário na consulta sql
                cmdEnvioAvaliacao.Parameters.AddWithValue("id_telespectador", idTelespectador);
                cmdEnvioAvaliacao.Parameters.AddWithValue("id_filme", idFilme);
                cmdEnvioAvaliacao.Parameters.AddWithValue("nota", nota);
                cmdEnvioAvaliacao.Parameters.AddWithValue("comentario", comentario);
                cmdEnvioAvaliacao.Parameters.AddWithValue("data",  DateTime.Now.Date.ToString("yyyy’-‘MM’-‘dd’"));
                cmdEnvioAvaliacao.ExecuteNonQuery(); //executa o comando sql (lembrando que 'ExecuteNonQuery' não retorna valores)
                cmdEnvioAvaliacao.Dispose(); //liberação da memória utilizada pelo comando 'cmdEnvioAvaliacao'


                MySqlCommand cmdAtualizacontadores = new MySqlCommand(); // criação de comando
                cmdAtualizacontadores.Connection = conexaoBanco; // atribui uma conexão para o comando (obrigatório)
                //abaixo é definido o comando sql para mysqlcommand criado
                cmdAtualizacontadores.CommandText = "UPDATE tb_telespectador " +
                    "INNER JOIN tb_avaliacaofilme ON tb_telespectador.id = tb_avaliacaofilme.id_telespectador " +
                    "INNER JOIN tb_filme ON tb_avaliacaofilme.id_filme = tb_filme.id " +
                    "SET " +
                    "tb_telespectador.total_minutos = (tb_telespectador.total_minutos + tb_filme.duracao_min), " +
                    "tb_telespectador.total_filmes = (tb_telespectador.total_filmes + 1) " +
                    "WHERE tb_telespectador.id = @id_telespectador and tb_filme.id = @id_filme";

                //atribuição dos valores para cada parâmetro necessário na consulta sql
                cmdAtualizacontadores.Parameters.AddWithValue("id_telespectador", idTelespectador);
                cmdAtualizacontadores.Parameters.AddWithValue("id_filme", idFilme);
                cmdAtualizacontadores.ExecuteNonQuery(); //executa o comando sql (lembrando que 'ExecuteNonQuery' não retorna valores)
                cmdAtualizacontadores.Dispose(); //liberação da memória utilizada pelo comando 'cmdAtualizacontadores'

                MessageBox.Show("Avaliação enviada com sucesso! \nAvalie outro filme ou clique em 'Voltar' para sair da tela");
            }
            finally
            {
                if (conexaoBanco != null) conexaoBanco.Close(); //fechamento da coneexão com o banco;
            }
        }

    }
}

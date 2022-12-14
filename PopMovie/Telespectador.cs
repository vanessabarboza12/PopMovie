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
        private int id;
        private DateTime dataUltimoAcesso;
        private DateTime dataCadastro;
        private DateTime dataNascimento;
        private string nome;
        private string email;
        private string senha;
        private int totalFilmes;
        private int totalMinutos;


        // Construtor para cadastro
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

        // Construtor para login
        public Telespectador(int id, string nome, DateTime dataUltimoAcesso, DateTime dataCadastro, DateTime dataNascimento, string email, string senha, int totalFilmes, int totalMinutos)
        {
            this.id = id;
            this.nome = nome;
            this.dataUltimoAcesso = dataUltimoAcesso;
            this.dataCadastro = dataCadastro;
            this.dataNascimento = dataNascimento;
            this.email = email;
            this.senha = senha;
            this.totalFilmes = totalFilmes;
            this.totalMinutos = totalMinutos;
        }

        public int getId() { return id; }
        public DateTime getDataUltimoAcesso() { return dataCadastro; }
        public DateTime getDataCadastro() { return dataCadastro; }
        public DateTime getDataNascimento() { return dataNascimento; }
        public string getNome() { return nome; }
        public string getEmail() { return email; }
        public string getSenha() { return senha; }
        public int getTotalFilmes() { return totalFilmes; }
        public int getTotalMinutos() { return totalMinutos; }



        public void adicionarAvaliacao(MySqlConnection conexaoBanco, int idTelespectador, int idFilme, double nota, string comentario)
        {
            try
            {
                conexaoBanco.Open(); // abertura de conexão com o banco;

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
                atualizaContadores(conexaoBanco, "incremento", idTelespectador, idFilme);
                
                cmdEnvioAvaliacao.Dispose(); //liberação da memória utilizada pelo comando 'cmdEnvioAvaliacao'
                MessageBox.Show("Avaliação enviada com sucesso! \nAvalie outro filme ou clique em 'Voltar' para sair da tela");
            }
            finally
            {
                if (conexaoBanco != null) conexaoBanco.Close(); //fechamento da coneexão com o banco;
            }
        }

        public void removerAvaliacao(MySqlConnection conexaoBanco, int idAvaliacao)
        {
            try
            {
                conexaoBanco.Open(); // abertura de conexão com o banco;

                // Trecho abaixo é para pegar o id do telespectador e do filme;
                MySqlCommand cmdPegaIds = new MySqlCommand();
                cmdPegaIds.Connection = conexaoBanco;
                cmdPegaIds.CommandText = "SELECT id_telespectador, id_filme FROM tb_avaliacaofilme where id_avaliacao = @idAvaliacao";
                cmdPegaIds.Parameters.AddWithValue("idAvaliacao", idAvaliacao);
                MySqlDataReader leitor = cmdPegaIds.ExecuteReader();
                leitor.Read();
                int idTelespectador = leitor.GetInt32(0);
                int idFilme = leitor.GetInt32(1);
                leitor.Close();

                MySqlCommand cmdRemoveFilme = new MySqlCommand(); // criação de comando
                cmdRemoveFilme.Connection = conexaoBanco; // atribui uma conexão para o comando (obrigatório)
                //abaixo é definido o comando sql para mysqlcommand criado
                cmdRemoveFilme.CommandText = "DELETE FROM tb_avaliacaofilme where id_avaliacao = @id";
                //atribuição dos valores para cada parâmetro necessário na consulta sql
                cmdRemoveFilme.Parameters.AddWithValue("id", idAvaliacao);

                atualizaContadores(conexaoBanco, "decremento", idTelespectador, idFilme);
                cmdRemoveFilme.ExecuteNonQuery(); //executa o comando sql (lembrando que 'ExecuteNonQuery' não retorna valores)
                
                cmdRemoveFilme.Dispose(); //liberação da memória utilizada pelo 'cmdCadastro'
                MessageBox.Show("Avaliação de id " + idAvaliacao + " foi removida com sucesso!");
            }
            finally
            {
                if (conexaoBanco != null) conexaoBanco.Close(); //fechamento da coneexão com o banco;
            }
        }

        public void atualizaContadores(MySqlConnection conexaoBanco, string operacao, int idTelespectador, int idFilme)
        {
            MySqlCommand cmdAtualizacontadores = new MySqlCommand(); // criação de comando
            cmdAtualizacontadores.Connection = conexaoBanco; // atribui uma conexão para o comando (obrigatório)
                                                             //abaixo é definido o comando sql para mysqlcommand criado

            if (operacao == "incremento")
            {
                cmdAtualizacontadores.CommandText = "UPDATE tb_telespectador " +
                    "INNER JOIN tb_avaliacaofilme ON tb_telespectador.id = tb_avaliacaofilme.id_telespectador " +
                    "INNER JOIN tb_filme ON tb_avaliacaofilme.id_filme = tb_filme.id " +
                    "SET " +
                    "tb_telespectador.total_minutos = (tb_telespectador.total_minutos + tb_filme.duracao_min), " +
                    "tb_telespectador.total_filmes = (tb_telespectador.total_filmes + 1) " +
                    "WHERE tb_telespectador.id = @id_telespectador and tb_filme.id = @id_filme";
            }
            else
            {
                cmdAtualizacontadores.CommandText = "UPDATE tb_telespectador " +
                    "INNER JOIN tb_avaliacaofilme ON tb_telespectador.id = tb_avaliacaofilme.id_telespectador " +
                    "INNER JOIN tb_filme ON tb_avaliacaofilme.id_filme = tb_filme.id " +
                    "SET " +
                    "tb_telespectador.total_minutos = (tb_telespectador.total_minutos - tb_filme.duracao_min), " +
                    "tb_telespectador.total_filmes = (tb_telespectador.total_filmes - 1) " +
                    "WHERE tb_telespectador.id = @id_telespectador and tb_filme.id = @id_filme";
            }

            //atribuição dos valores para cada parâmetro necessário na consulta sql
            cmdAtualizacontadores.Parameters.AddWithValue("id_telespectador", idTelespectador);
            cmdAtualizacontadores.Parameters.AddWithValue("id_filme", idFilme);

            cmdAtualizacontadores.ExecuteNonQuery(); //executa o comando sql (lembrando que 'ExecuteNonQuery' não retorna valores)
            cmdAtualizacontadores.Dispose(); //liberação da memória utilizada pelo comando 'cmdAtualizacontadores'
        }

    }
}

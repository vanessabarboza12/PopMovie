using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopMovie
{
    public class BancoDeDados
    {
        private string dadosConexao;

        public BancoDeDados()
        {
            dadosConexao = @"server=127.0.0.1;uid=root;pwd=;database=bd_popmovie;ConnectionTimeout=1";
            //dadosConexao = @"server=127.0.0.1;uid=root;pwd=ifsp@MySql21;database=bd_lp2;ConnectionTimeout=1";
        }
        public void cadastroUsuario(Usuario usuario)
        {
            MySqlConnection connectionBD = null;
            MySqlCommand cmdInsert = null;
            try
            {
                connectionBD = new MySqlConnection(dadosConexao);
                //abre a conexão com o banco
                connectionBD.Open();
                // Executa um comando INSERT para inserir um registro na tabela 'Funcionario'
                // Como o INSERT não retorna valores, devemos executar o comando 'ExecuteNonQuery'
                cmdInsert = new MySqlCommand();
                //atribui uma conexão ao comando (obrigatório)
                cmdInsert.Connection = connectionBD;

                //seta o comando sql que será executado
                cmdInsert.CommandText = "INSERT INTO tb_usuario (nome, data_cadastro, data_nascimento, email, senha, total_filmes, total_minutos)" +
                                    "VALUES ( @nome, @dataCadastro, @dataNascimento, @email, @senha, @total_filmes, @total_minutos)";

                //seta os parametros que deverão ser passados para a consulta sql
                cmdInsert.Parameters.AddWithValue("nome", usuario.getNome());
                cmdInsert.Parameters.AddWithValue("dataCadastro", usuario.getDataCadastro());
                cmdInsert.Parameters.AddWithValue("dataNascimento", usuario.getDataNascimento());
                cmdInsert.Parameters.AddWithValue("email", usuario.getEmail());
                cmdInsert.Parameters.AddWithValue("senha", usuario.getSenha());
                cmdInsert.Parameters.AddWithValue("total_filmes", usuario.getTotalFilmes());
                cmdInsert.Parameters.AddWithValue("total_minutos", usuario.getTotalMinutos());
                //executa o comando / consulta sql
                cmdInsert.ExecuteNonQuery();
            }
            finally
            {
                //libera a memória utilizada pelos comandos
                if (cmdInsert != null) cmdInsert.Dispose();
                //fecha a conexão com o banco!
                if (connectionBD != null) connectionBD.Close();
            }
        }

        public void loginUsuario(string email, string senha)
        {
            MySqlConnection connectionBD = null;
            MySqlCommand cmdValidacao = null;
            try
            {
                connectionBD = new MySqlConnection(dadosConexao);
                connectionBD.Open();
                cmdValidacao = new MySqlCommand();
                cmdValidacao.Connection = connectionBD;

                cmdValidacao.CommandText = "SELECT * FROM tb_usuario where email=@email and senha=@senha";

                cmdValidacao.Parameters.AddWithValue("email", email);
                cmdValidacao.Parameters.AddWithValue("senha", senha);

                MySqlDataReader leitor = cmdValidacao.ExecuteReader();

                if (leitor.Read())
                {
                        TelaUsuario telaUsuario = new TelaUsuario();
                        telaUsuario.Show();
                }
                connectionBD.Close();
            }
            finally
            {
                //libera a memória utilizada pelos comandos
                if (cmdValidacao != null) cmdValidacao.Dispose();
                //fecha a conexão com o banco!
                if (connectionBD != null) connectionBD.Close();
            }

        }
    }
 }

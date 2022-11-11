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
    public class Conexao
    {
        private string dadosConexao;

        public Conexao()
        {
            dadosConexao = @"server=127.0.0.1;uid=root;pwd=;database=bd_popmovie;ConnectionTimeout=1";
        }

        public void cadastroUsuario(Telespectador telespectador)
        {
            MySqlConnection connectionBD = null;
            MySqlCommand cmdCadastro = null;
            try
            {
                connectionBD = new MySqlConnection(dadosConexao); // criação da conexão (objeto da classe MySqlConnection)
                connectionBD.Open(); // abertura de conexão com o banco
                cmdCadastro = new MySqlCommand(); // criação de comando e atribuindo nome cmdCadastro
                cmdCadastro.Connection = connectionBD; // atribui uma conexão para o comando (obrigatório)

                //abaixo é definido o comando sql para o 'cmdCadastro'
                cmdCadastro.CommandText = "INSERT INTO tb_telespectador (nome, data_cadastro, data_nascimento, email, senha, total_filmes, total_minutos)" +
                                    "VALUES ( @nome, @dataCadastro, @dataNascimento, @email, @senha, @total_filmes, @total_minutos)";

                //atribuição dos valores para cada parâmetro necessário na consulta sql
                cmdCadastro.Parameters.AddWithValue("nome", telespectador.getNome());
                cmdCadastro.Parameters.AddWithValue("dataCadastro", telespectador.getDataCadastro());
                cmdCadastro.Parameters.AddWithValue("dataNascimento", telespectador.getDataNascimento());
                cmdCadastro.Parameters.AddWithValue("email", telespectador.getEmail());
                cmdCadastro.Parameters.AddWithValue("senha", telespectador.getSenha());
                cmdCadastro.Parameters.AddWithValue("total_filmes", telespectador.getTotalFilmes());
                cmdCadastro.Parameters.AddWithValue("total_minutos", telespectador.getTotalMinutos());
               
                cmdCadastro.ExecuteNonQuery(); //executa o comando sql (lembrando que 'ExecuteNonQuery' não retorna valores)
            }
            finally
            {
                if (cmdCadastro != null) cmdCadastro.Dispose(); //liberação da memória utilizada pelo 'cmdCadastro'
                if (connectionBD != null) connectionBD.Close(); //fechamento da coneexão com o banco;
            }
        }

        public void loginUsuario(string email, string senha)
        {
            MySqlConnection connectionBD = null;
            MySqlCommand cmdLogin = null;
            try
            {
                connectionBD = new MySqlConnection(dadosConexao);
                connectionBD.Open();
                cmdLogin = new MySqlCommand();
                cmdLogin.Connection = connectionBD;
                cmdLogin.CommandText = "SELECT * FROM tb_telespectador where email=@email and senha=@senha";
                cmdLogin.Parameters.AddWithValue("email", email);
                cmdLogin.Parameters.AddWithValue("senha", senha);
                MySqlDataReader leitor = cmdLogin.ExecuteReader();

                if (leitor.Read())
                {
                        FormTelespectador telaUsuario = new FormTelespectador();
                        telaUsuario.Show();
                }
                else
                {   
                    leitor.Close();
                    cmdLogin.CommandText = "SELECT * FROM tb_administrador where email=@email and senha=@senha";
                    leitor = cmdLogin.ExecuteReader();
                    if (leitor.Read())
                    {
                        FormAdministrador telaAdministrador = new FormAdministrador();
                        telaAdministrador.Show();
                    }
                }
                connectionBD.Close();
            }
            finally
            {
                if (cmdLogin != null) cmdLogin.Dispose();
                if (connectionBD != null) connectionBD.Close();
            }

        }
    }
 }

using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PopMovie
{
    public class Conexao
    {
        private string dadosConexao;

        public Conexao()
        {
            dadosConexao = @"server=sql10.freesqldatabase.com;uid=sql10562225;pwd=;database=sql10562225;ConnectionTimeout=1";
            //banco local -> dadosConexao = @"server=127.0.0.1;uid=root;pwd= {vazio ou ifspifsp talvez};database=bd_popmovie;ConnectionTimeout=1";
        }


        //método para criptografia de senha
        public static string SHA256Hash(string content)
        {
            SHA256 sh = new SHA256CryptoServiceProvider();
            sh.ComputeHash(UTF8Encoding.UTF8.GetBytes(content));
            byte[] result = sh.Hash;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("x2"));
            }
            return sb.ToString();
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
                    else
                    {

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

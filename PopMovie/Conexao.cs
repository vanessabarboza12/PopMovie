using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PopMovie
{
    public class Conexao
    {
        private string dadosConexao;
        public MySqlConnection conexaoBanco;

        public Conexao()
        {
            dadosConexao = @"server=sql10.freesqldatabase.com;uid=sql10578872;pwd=GLlFwGdMDj;database=sql10578872;ConnectionTimeout=1";////banco local -> dadosConexao = @"server=127.0.0.1;uid=root;pwd= {vazio ou ifspifsp talvez};database=bd_popmovie;ConnectionTimeout=1";
            conexaoBanco = new MySqlConnection(dadosConexao);
        }

        public string criptografarSenha(string content) //método para criptografia de senha
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

        public static bool emailJaCadastrado(string email, MySqlConnection conexaoBanco)// //Método utilizado durante o cadastro para verificar se o email já está sendo utilizado por um usuário (seja telespectador ou adm)
        {
            MySqlCommand cmdValida = new MySqlCommand();
            cmdValida.Connection = conexaoBanco;
            cmdValida.CommandText = "SELECT * FROM tb_telespectador where email=@email;";
            cmdValida.Parameters.AddWithValue("email", email);
            MySqlDataReader leitor = cmdValida.ExecuteReader();

            if (leitor.Read())
            {
                return true;
            }
            else
            {
                leitor.Close();
                cmdValida.CommandText = "SELECT * FROM tb_administrador where email=@email;";
                leitor = cmdValida.ExecuteReader();
                if (leitor.Read())
                {
                    leitor.Close();
                    return true;
                }
                else
                {
                    leitor.Close();
                    return false;
                }
            }
        }

        public void cadastroTelespectador(Telespectador telespectador)
        {
            try
            {
                conexaoBanco.Open(); // abertura de conexão com o banco
                if (emailJaCadastrado(telespectador.getEmail(), conexaoBanco) == true)
                {
                    MessageBox.Show("Cadastro não realizado. Email já em uso!");
                }
                else
                {
                    MySqlCommand cmdCadastro = new MySqlCommand(); // criação de comando e atribuindo nome cmdCadastro
                    cmdCadastro.Connection = conexaoBanco; // atribui uma conexão para o comando (obrigatório)
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
                    cmdCadastro.Dispose(); //liberação da memória utilizada pelo 'cmdCadastro'
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    Application.OpenForms[1].Close(); // Fecha tela de cadastro e retorna para tela inicial
                }
            }
            finally
            {
                if (conexaoBanco != null) conexaoBanco.Close(); //fechamento da coneexão com o banco;
            }
        }

        public void loginUsuario(string email, string senha)
        {
            try
            {
                conexaoBanco.Open();
                MySqlCommand cmdLogin = new MySqlCommand();
                cmdLogin.Connection = conexaoBanco;
                cmdLogin.CommandText = "SELECT * FROM tb_telespectador where email=@email and senha=@senha";
                cmdLogin.Parameters.AddWithValue("email", email);
                cmdLogin.Parameters.AddWithValue("senha", senha);
                MySqlDataReader leitor = cmdLogin.ExecuteReader();

                if (leitor.Read())
                {
                    Telespectador telespectador = new Telespectador(leitor.GetString(1), leitor.GetDateTime(2), leitor.GetDateTime(3), leitor.GetString(4), leitor.GetString(5), leitor.GetInt32(6), leitor.GetInt32(7));
                    FormTelespectador telaTelespectador = new FormTelespectador(telespectador);
                    Application.OpenForms[1].Close();
                    MessageBox.Show("Login realizado com sucesso!");
                    Application.OpenForms[1].Close(); // Fecha a tela de login após abrir tela de telespectador
                    Application.OpenForms[0].WindowState = FormWindowState.Minimized; // minimiza tela inicial (primeira tela)
                    telaTelespectador.Show();
                }
                else
                {   
                    leitor.Close();
                    cmdLogin.CommandText = "SELECT * FROM tb_administrador where email=@email and senha=@senha";
                    leitor = cmdLogin.ExecuteReader();
                    cmdLogin.Dispose();

                    if (leitor.Read())
                    {
                      
                        Administrador administrador = new Administrador(leitor.GetString(1), leitor.GetString(2), leitor.GetString(3));
                        FormAdministrador telaAdministrador = new FormAdministrador(conexaoBanco, administrador);
                        MessageBox.Show("Login realizado com sucesso!");
                        Application.OpenForms[1].Close(); // Fecha a tela de login após abrir tela de admin
                        Application.OpenForms[0].WindowState = FormWindowState.Minimized; // minimiza tela inicial (primeira tela)
                        telaAdministrador.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login não realizado com sucesso. Senha ou email incorreto!");
                    }
                }
            }
            finally
            {
                conexaoBanco.Close();
                if (conexaoBanco != null) conexaoBanco.Close();
            }
        }
    }
}

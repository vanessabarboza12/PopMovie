using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopMovie
{
    public partial class FormCadastro : Form
    {
        private BancoDeDados banco;
        public FormCadastro(BancoDeDados banco)
        {
            InitializeComponent();
            this.banco = banco;
            txbSenha.PasswordChar = '*';
            txbConfirmaSenha.PasswordChar = '*';
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text.Trim();
            if (nome == "")
            {
                MessageBox.Show("Preencha o campo \"Nome\"");
                return;
            }

            DateTime dataCadastro = DateTime.Now.Date;
            dataCadastro.ToString("yyyy’-‘MM’-‘dd’");
            DateTime dataNascimento = dateNascimento.Value.Date;
            dataNascimento.ToString("yyyy’-‘MM’-‘dd’");

            if (dataNascimento == null)
            {
                MessageBox.Show("Preencha o campo \"Data de nascimento\"");
                return;
            }

            string email = txbEmail.Text.Trim();
            if (email == "")
            {
                MessageBox.Show("Preencha o campo \"Email\"");
                return;
            }

            string senha = txbSenha.Text.Trim();
            if (senha == "")
            {
                MessageBox.Show("Preencha o campo \"senha\"");
                return;
            }

            string confirmaSenha = txbConfirmaSenha.Text.Trim();
            if (confirmaSenha == "")
            {
                MessageBox.Show("Preencha o campo \"Confirmação da senha\"");
                return;
            }

            if (confirmaSenha != senha)
            {
                MessageBox.Show("Confirmação de senha não confere! Digite novamente");
                return;
            }

            int totalFilmes = 0;
            int totalMinutos = 0;

            try
            {
                Usuario usuario = new Usuario(nome, dataCadastro, dataNascimento, email, senha, totalFilmes, totalMinutos);
                banco.cadastroUsuario(usuario);

                //informa o usuário que o usuario foi cadastrado no banco
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (MySqlException erro)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(erro.GetType().ToString());
                sb.AppendLine(erro.Message);
                sb.Append(erro.SqlState);
                sb.AppendLine("\n");
                sb.AppendLine(erro.StackTrace);
                MessageBox.Show(sb.ToString(), "ERRO BANCO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //tratamento dos demais erros que possam ocorrer
            catch (Exception erro)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(erro.GetType().ToString());
                sb.AppendLine(erro.Message);
                sb.AppendLine("\n");
                sb.AppendLine(erro.StackTrace);
                MessageBox.Show(sb.ToString(), "ERRO Desconhecido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

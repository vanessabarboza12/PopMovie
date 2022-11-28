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
        private Conexao banco;
        public FormCadastro(Conexao banco)
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
            try
            {
                System.Net.Mail.MailAddress validacaoEmail = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                MessageBox.Show("Valor para o campo \"Email\" é inválido");
                return;
            }

            string senha = txbSenha.Text.Trim();
            if (senha == "" || senha.Length < 4)
            {
                MessageBox.Show("Preencha o campo \"senha\" com no mínimo 4 caracteres");
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
            else
            {
                senha = banco.criptografarSenha(senha);
            }

            int totalFilmes = 0;
            int totalMinutos = 0;

            try
            {
                Telespectador telespectador = new Telespectador(nome, dataCadastro, dataNascimento, email, senha, totalFilmes, totalMinutos);
                banco.cadastroTelespectador(telespectador);
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}

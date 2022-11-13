﻿using MySql.Data.MySqlClient;
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
    public partial class FormLogin : Form
    {
        private Conexao banco;
        public FormLogin(Conexao banco)
        {
            InitializeComponent();
            this.banco = banco;
            txbSenha.PasswordChar = '*';
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
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
            if (senha == "" || senha.Length < 8)
            {
                MessageBox.Show("Preencha o campo \"senha\" com no mínimo 8 caracteres");
                return;
            }
            else
            {
                senha = banco.criptografarSenha(senha);
            }

            try
            {
                bool login = banco.loginUsuario(email, senha);
                //informa o usuário que o usuario foi cadastrado no banco
                if (login == true)
                { 
                    MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login não realizado com sucesso. Senha ou email incorreto!");
                }

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
    }
}

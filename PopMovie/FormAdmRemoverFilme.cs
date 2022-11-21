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
    public partial class FormAdmRemoverFilme : Form
    {
        private MySqlConnection conexaoBanco;
        private Administrador admin;
        public FormAdmRemoverFilme(MySqlConnection conexao, Administrador admin)
        {
            this.conexaoBanco = conexao;
            this.admin = admin;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmRemoverFilme_Load(object sender, EventArgs e)
        {
            // IMPORTANTE
            // Ao ser carregado esse forms, é aberto uma conexão com o banco para para pegar todos os filmes do banco e exibir no dataGridFilmes
            conexaoBanco.Open();
            MySqlCommand cmdExibeFilme = new MySqlCommand();
            cmdExibeFilme.Connection = conexaoBanco;
            cmdExibeFilme.CommandText = "SELECT * FROM tb_filme";
            MySqlDataReader leitor = cmdExibeFilme.ExecuteReader();
            DataTable tabelaFilmes = new DataTable();
            tabelaFilmes.Load(leitor);
            dataGridFilmes.DataSource = tabelaFilmes;
            if (conexaoBanco != null) conexaoBanco.Close(); // boa prática de fechar banco quando não está mais sendo requisitado

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridFilmes.CurrentCell != null)
            {
                int idFilme = Convert.ToInt32(dataGridFilmes.CurrentRow.Cells[0].Value);
                dataGridFilmes.Rows.Remove(dataGridFilmes.CurrentRow);

                try
                {
                    admin.removerFilme(conexaoBanco, idFilme);
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
            else
            {
                MessageBox.Show("Selecione alguma célula de um filme que você deseja deletar antes de clicar para remover!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

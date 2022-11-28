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
    public partial class FormAdmRemoverUsuario : Form
    {
        private MySqlConnection conexaoBanco;
        private Administrador admin;
        public FormAdmRemoverUsuario(MySqlConnection conexaoBanco, Administrador admin)
        {
            this.conexaoBanco = conexaoBanco;
            this.admin = admin;
            InitializeComponent();
        }

        private void FormAdmRemoverUsuario_Load(object sender, EventArgs e)
        {
            conexaoBanco.Open();
            MySqlCommand cmdExibeFilme = new MySqlCommand();
            cmdExibeFilme.Connection = conexaoBanco;
            cmdExibeFilme.CommandText = "SELECT * FROM tb_telespectador";
            MySqlDataReader leitor = cmdExibeFilme.ExecuteReader();
            DataTable tabelaFilmes = new DataTable();
            tabelaFilmes.Load(leitor);
            dataGridTelespectadores.DataSource = tabelaFilmes;
            if (conexaoBanco != null) conexaoBanco.Close(); // boa prática de fechar banco quando não está mais sendo requisitado
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoverConta_Click(object sender, EventArgs e)
        {
            if (dataGridTelespectadores.CurrentCell != null)
            {
                int idTelespectador = Convert.ToInt32(dataGridTelespectadores.CurrentRow.Cells[0].Value);
                dataGridTelespectadores.Rows.Remove(dataGridTelespectadores.CurrentRow);

                try
                {
                    admin.removerTelespectador(conexaoBanco, idTelespectador);
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
                MessageBox.Show("Selecione alguma célula de um telespectador que você deseja deletar antes de clicar para remover!");
            }
        }
    }
}

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
    public partial class FormTeleBuscarFilme : Form
    {
        private Telespectador telespectador;
        private MySqlConnection conexaoBanco;
        private string buscaFilme;
        public FormTeleBuscarFilme(MySqlConnection conexaoBanco, Telespectador telespectador, string buscaFilme)
        {
            this.conexaoBanco = conexaoBanco;
            this.telespectador = telespectador;
            this.buscaFilme = buscaFilme;
            InitializeComponent();
        }

        private void FormTeleBuscarFilme_Load(object sender, EventArgs e)
        {
            // Ao ser carregado esse forms, é aberto uma conexão com o banco para para pegar todos os filmes do banco e exibir no dataGridFilmes
            conexaoBanco.Open();
            MySqlCommand cmdExibePesquisaFilme = new MySqlCommand();
            cmdExibePesquisaFilme.Connection = conexaoBanco;
            cmdExibePesquisaFilme.CommandText = "SELECT * FROM tb_filme WHERE nome LIKE \'%" + @buscaFilme + "%\'";
            cmdExibePesquisaFilme.Parameters.AddWithValue("buscaFilme", buscaFilme);
            MySqlDataReader leitor = cmdExibePesquisaFilme.ExecuteReader();
            DataTable tabelaFilmes = new DataTable();
            tabelaFilmes.Load(leitor);
            if (tabelaFilmes.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum filme foi encontrado com sua pesquisa!");
                this.Close();
            }
            else
            {
                dataGridBuscaFilmes.DataSource = tabelaFilmes;
                lblTermoPesquisa.Text = buscaFilme;
            }

            if (conexaoBanco != null) conexaoBanco.Close(); // boa prática de fechar banco quando não está mais sendo requisitado
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
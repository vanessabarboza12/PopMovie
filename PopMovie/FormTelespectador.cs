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
    public partial class FormTelespectador : Form
    {
        private Telespectador telespectador;
        private MySqlConnection conexaoBanco;
        public FormTelespectador(MySqlConnection conexaoBanco, Telespectador telespectador)
        {
            this.conexaoBanco = conexaoBanco;
            this.telespectador = telespectador;
            InitializeComponent();
        }

        private void FormTelespectador_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Olá, Telespectador(a) " + telespectador.getNome();
            lblTotalFilmes.Text = telespectador.getTotalFilmes().ToString();
            lblTotalMinutos.Text = telespectador.getTotalMinutos().ToString();
            comboBoxFiltro.Enabled = false;
            comboBoxValor.Enabled = false;
        }

        private void btnBuscarFilme_Click(object sender, EventArgs e)
        {
            string pesquisaFilme = txbBuscaFilme.Text.Trim();
        
            if (rBtnSim.Checked)
            {
                int filtro = comboBoxFiltro.SelectedIndex;
                string valor = comboBoxValor.SelectedItem.ToString();
                FormTeleBuscarFilme janelaBuscarFilme = new FormTeleBuscarFilme(conexaoBanco, telespectador, pesquisaFilme, filtro, valor);
                janelaBuscarFilme.ShowDialog();
                clearTextBox();
            }
            else
            {
                FormTeleBuscarFilme janelaBuscarFilme = new FormTeleBuscarFilme(conexaoBanco, telespectador, pesquisaFilme);
                janelaBuscarFilme.ShowDialog();
                clearTextBox();
            }
        }

        private void btnMeusFilmes_Click(object sender, EventArgs e)
        {
            FormTeleFilmesAvaliados janelaFilmesAvaliados = new FormTeleFilmesAvaliados(conexaoBanco, telespectador);
            janelaFilmesAvaliados.ShowDialog();
        }

        private void pictureRecarregarContadores_Click(object sender, EventArgs e)
        {
            conexaoBanco.Open();
            MySqlCommand cmdRecarregaContadores = new MySqlCommand();
            cmdRecarregaContadores.Connection = conexaoBanco;
            cmdRecarregaContadores.CommandText = "SELECT total_filmes, total_minutos FROM tb_telespectador where id = @id";
            cmdRecarregaContadores.Parameters.AddWithValue("id", telespectador.getId());
            MySqlDataReader leitor = cmdRecarregaContadores.ExecuteReader();
            leitor.Read();

            lblTotalFilmes.Text = leitor.GetInt32(0).ToString();
            lblTotalMinutos.Text = leitor.GetInt32(1).ToString();

            leitor.Close();
            cmdRecarregaContadores.Dispose();
            conexaoBanco.Close();
        }

        private void rBtnSim_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFiltro.Enabled = true;
            comboBoxValor.Enabled = true;

            comboBoxValor.Items.Clear();
            comboBoxFiltro.Items.Add("Gênero"); //index 0
            comboBoxFiltro.Items.Add("Idade mínima para assistir"); // 1
            comboBoxFiltro.Items.Add("Ano de lançamento (a partir de)"); //2
            comboBoxFiltro.Items.Add("Duração máxima em minutos"); //3
            comboBoxFiltro.Items.Add("Nota mínima do IMDB"); //4
        }

        private void rBtnNao_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFiltro.Enabled = false;
            comboBoxValor.Enabled = false;
            comboBoxFiltro.Items.Clear();
        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFiltro.SelectedIndex == 0) // genero
            {

                comboBoxValor.Items.Clear();
                comboBoxValor.Items.Add("Action");
                comboBoxValor.Items.Add("Adventure");
                comboBoxValor.Items.Add("Animation");
                comboBoxValor.Items.Add("Biography");
                comboBoxValor.Items.Add("Comedy");
                comboBoxValor.Items.Add("Crime");
                comboBoxValor.Items.Add("Drama");
                comboBoxValor.Items.Add("Family");
                comboBoxValor.Items.Add("Fantasy");
                comboBoxValor.Items.Add("Film-Noir");
                comboBoxValor.Items.Add("History");
                comboBoxValor.Items.Add("Horror");
                comboBoxValor.Items.Add("Mystery");
                comboBoxValor.Items.Add("Sci-Fi");
                comboBoxValor.Items.Add("Thriller");
                comboBoxValor.Items.Add("Western");
            }
            else if (comboBoxFiltro.SelectedIndex == 1)
            {
                comboBoxValor.Items.Clear();
                comboBoxValor.Items.Add("0");
                comboBoxValor.Items.Add("4");
                comboBoxValor.Items.Add("8");
                comboBoxValor.Items.Add("12");
                comboBoxValor.Items.Add("14");
                comboBoxValor.Items.Add("16");
                comboBoxValor.Items.Add("18");

            }
            else if (comboBoxFiltro.SelectedIndex == 2)
            {
                comboBoxValor.Items.Clear();
                comboBoxValor.Items.Add("1920");
                comboBoxValor.Items.Add("1930");
                comboBoxValor.Items.Add("1950");
                comboBoxValor.Items.Add("1970");
                comboBoxValor.Items.Add("1990");
                comboBoxValor.Items.Add("2000");
                comboBoxValor.Items.Add("2005");;
                comboBoxValor.Items.Add("2010");
                comboBoxValor.Items.Add("2015");
                comboBoxValor.Items.Add("2018");
                comboBoxValor.Items.Add("2020");
                comboBoxValor.Items.Add("2021");
                comboBoxValor.Items.Add("2022");
            }
            else if (comboBoxFiltro.SelectedIndex == 3)
            {
                comboBoxValor.Items.Clear();
                comboBoxValor.Items.Add("60");
                comboBoxValor.Items.Add("75");
                comboBoxValor.Items.Add("90"); ;
                comboBoxValor.Items.Add("105");
                comboBoxValor.Items.Add("120");
                comboBoxValor.Items.Add("150");
                comboBoxValor.Items.Add("180");
                comboBoxValor.Items.Add("240");
            }
            else if (comboBoxFiltro.SelectedIndex == 4)
            {
                comboBoxValor.Items.Clear();
                comboBoxValor.Items.Add("1");
                comboBoxValor.Items.Add("2");
                comboBoxValor.Items.Add("3"); ;
                comboBoxValor.Items.Add("4");
                comboBoxValor.Items.Add("5");
                comboBoxValor.Items.Add("6");
                comboBoxValor.Items.Add("7");
                comboBoxValor.Items.Add("8");
                comboBoxValor.Items.Add("9");
            }
        }

        private void btnSairConta_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].WindowState = FormWindowState.Normal; // Primeira tela (inicial), deixa de estar minimizada e volta ao normal
        }

        private void clearTextBox() // redefinir campos após submeter avaliação
        {
            comboBoxFiltro.SelectedIndex = -1;
            comboBoxValor.SelectedIndex = -1;
            rBtnSim.Checked = false;
            rBtnNao.Checked = false;
        }
    }
}

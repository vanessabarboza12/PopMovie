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
            lblUsuario.Text = "Olá, Telespectador(a) " + telespectador.getNome();
            lblTotalFilmes.Text = telespectador.getTotalFilmes().ToString();
            lblTotalMinutos.Text = telespectador.getTotalMinutos().ToString();
        }



        private void btnSairConta_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].WindowState = FormWindowState.Normal; // Primeira tela (inicial), deixa de estar minimizada e volta ao normal
        }

        private void btnBuscarFilme_Click(object sender, EventArgs e)
        {
            string pesquisaFilme = txbBuscaFilme.Text.Trim();
            FormTeleBuscarFilme janelaBuscarFilme = new FormTeleBuscarFilme(conexaoBanco, telespectador, pesquisaFilme); 
            janelaBuscarFilme.ShowDialog();
        }

        private void btnMeusFilmes_Click(object sender, EventArgs e)
        {
            FormTeleFilmesAvaliados janelaFilmesAvaliados = new FormTeleFilmesAvaliados(conexaoBanco, telespectador);
            janelaFilmesAvaliados.ShowDialog();
        }

        private void FormTelespectador_Load(object sender, EventArgs e)
        {
    
        }
    }
}

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
    public partial class FormAdministrador : Form
    {
        private MySqlConnection conexaoBanco;
        private Administrador admin;
        public FormAdministrador(MySqlConnection conexao, Administrador admin)
        {
            this.admin = admin;
            this.conexaoBanco = conexao;
            InitializeComponent();
            lblAdministrador.Text = "Olá, administrador(a) " + admin.getNome();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adcFilme_btn_Click(object sender, EventArgs e)
        {
            FormAdmAddFilme janelaAddFilme = new FormAdmAddFilme(conexaoBanco, admin);
            janelaAddFilme.ShowDialog();
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].WindowState = FormWindowState.Normal; // Primeira tela (inicial), deixa de estar minimizada e volta ao normal
        }
    }
}

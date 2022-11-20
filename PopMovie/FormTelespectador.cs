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
        public FormTelespectador(Telespectador t)
        {
            this.telespectador = t;
            InitializeComponent();
            lblUsuario.Text = "Olá, Telespectador(a) " + telespectador.getNome();
            lblTotalFilmes.Text = telespectador.getTotalFilmes().ToString();
            lblTotalMinutos.Text = telespectador.getTotalMinutos().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buscar_btn_Click(object sender, EventArgs e)
        {

        }

        private void btnSairConta_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].WindowState = FormWindowState.Normal; // Primeira tela (inicial), deixa de estar minimizada e volta ao normal
        }
    }
}

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
    public partial class FormInicial : Form
    {
        private Conexao banco;
        public FormInicial()
        {
            InitializeComponent();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            banco = new Conexao();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FormLogin janelaLogin = new FormLogin(banco);
            janelaLogin.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro janelaCadastro = new FormCadastro(banco);
            janelaCadastro.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

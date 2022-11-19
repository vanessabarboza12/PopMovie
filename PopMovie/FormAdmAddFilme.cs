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
    public partial class FormAdmAddFilme : Form
    {
        private MySqlConnection conexaoBanco;
        private Administrador admin;
        public FormAdmAddFilme(MySqlConnection conexao, Administrador admin)
        {
            this.conexaoBanco = conexao;
            this.admin = admin;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nomeFilme = txbNomeAdcFilme.Text.Trim();
            if (nomeFilme == "")
            {
                MessageBox.Show("Preencha o campo \"Nome do Filme\"");
                return;
            }

            string genero = txbGeneroAdcFilme.Text.Trim();
            if (genero == "")
            {
                MessageBox.Show("Preencha o campo \"Genero(s) do Filme\"");
                return;
            }

            string nomeDiretor = txbDiretorAdcFilme.Text.Trim();
            if (nomeDiretor == "")
            {
                MessageBox.Show("Preencha o campo \"Nome do Diretor\"");
                return;
            }

            int anoLancamento = Convert.ToInt32(numAnoAdcFilme);

            double notaImdb = Convert.ToDouble(numNotaAdcFilme);

            int classificacao = Convert.ToInt32(numClassificacaoAdcFilme);

            int duracao = Convert.ToInt32(numDuracaoAdcFilme);

            string sinopseFilme = txbSinopseAdcFilme.Text.Trim();
            if (sinopseFilme == "")
            {
                MessageBox.Show("Preencha o campo \"Sinopse do Filme\"");
                return;
            }
         
            try
            {
                Filme filme = new Filme(nomeFilme, anoLancamento, classificacao, duracao, notaImdb, genero, sinopseFilme, nomeDiretor);
                admin.adicionarFilme(conexaoBanco, filme);
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
    }
}

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

            decimal anoLancamento = numAnoAdcFilme.Value;

            decimal notaImdb = numNotaAdcFilme.Value;

            decimal classificacao = numClassificacaoAdcFilme.Value;

            decimal duracao = numDuracaoAdcFilme.Value;

            string sinopseFilme = txbSinopseAdcFilme.Text.Trim();
            if (sinopseFilme == "")
            {
                MessageBox.Show("Preencha o campo \"Sinopse do Filme\"");
                return;
            }
         
            try
            {
                Filme filme = new Filme(nomeFilme, Convert.ToInt32(anoLancamento), Convert.ToInt32(classificacao), Convert.ToInt32(duracao), Convert.ToDouble(notaImdb), genero, sinopseFilme, nomeDiretor);
                
                bool filmeAdicionado = admin.adicionarFilme(conexaoBanco, filme);
                if (filmeAdicionado == true){
                    this.Close();
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
    }
}

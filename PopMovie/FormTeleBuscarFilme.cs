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
        private string filtro;
        private string valor;

        public FormTeleBuscarFilme(MySqlConnection conexaoBanco, Telespectador telespectador, string buscaFilme)
        {
            this.conexaoBanco = conexaoBanco;
            this.telespectador = telespectador;
            this.buscaFilme = buscaFilme;
            InitializeComponent();
        }

        public FormTeleBuscarFilme(MySqlConnection conexaoBanco, Telespectador telespectador, string buscaFilme, int filtro, string valor)
        {
            this.conexaoBanco = conexaoBanco;
            this.telespectador = telespectador;
            this.buscaFilme = buscaFilme;
            this.valor = valor;
            //no forms anterior, foi passado o index referente ao filtro no combobox, já o trecho abaixo é necessário pois irá atribuir o nome do campo referente ao filtro na tabela de filmes
            if (filtro == 0) this.filtro = "genero";
            if (filtro == 1) this.filtro = "classificacao";
            if (filtro == 2) this.filtro = "ano_lancamento";
            if (filtro == 3) this.filtro = "duracao_min";
            if (filtro == 4) this.filtro = "nota_imdb";
            InitializeComponent();
        }

        private void FormTeleBuscarFilme_Load(object sender, EventArgs e)
        {
            // Ao ser carregado esse forms, é aberto uma conexão com o banco para para pegar todos os filmes do banco e exibir no dataGridFilmes
            conexaoBanco.Open();
            MySqlCommand cmdExibePesquisaFilme = new MySqlCommand();
            
            cmdExibePesquisaFilme.Connection = conexaoBanco;
            if (filtro == null || valor == null)
            {
                cmdExibePesquisaFilme.CommandText = "SELECT * FROM tb_filme WHERE nome LIKE \'%" + @buscaFilme + "%\'";
                cmdExibePesquisaFilme.Parameters.AddWithValue("buscaFilme", buscaFilme);
            }
            else
            {
                if (filtro == "genero") // comparação de texto com like
                {
                    cmdExibePesquisaFilme.CommandText = "SELECT * FROM tb_filme WHERE nome LIKE \'%" + @buscaFilme + "%\' and " + @filtro + " LIKE \'%" + @valor + "%\'";
                    cmdExibePesquisaFilme.Parameters.AddWithValue("buscaFilme", buscaFilme);
                    cmdExibePesquisaFilme.Parameters.AddWithValue("filtro", filtro);
                    cmdExibePesquisaFilme.Parameters.AddWithValue("valor", valor);
                }
                else // comparação numérica
                {
                    if (filtro == "duracao_min")
                    { 
                        cmdExibePesquisaFilme.CommandText = "SELECT * FROM tb_filme WHERE nome LIKE \'%" + @buscaFilme + "%\' and " + @filtro + " <= @valor";
                    }
                    else
                    { 
                        cmdExibePesquisaFilme.CommandText = "SELECT * FROM tb_filme WHERE nome LIKE \'%" + @buscaFilme + "%\' and " + @filtro + " >= @valor";
                    }
                    cmdExibePesquisaFilme.Parameters.AddWithValue("buscaFilme", buscaFilme);
                    cmdExibePesquisaFilme.Parameters.AddWithValue("filtro", filtro);
                    cmdExibePesquisaFilme.Parameters.AddWithValue("valor", Convert.ToInt32(valor));
                }
            }
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
                int opcaoId;
               
                //Percorre adiciona todos id para o combobox qujando for avaliar um filme
                for (int i = 0; i < dataGridBuscaFilmes.Rows.Count; i++)
                {
                    opcaoId = Convert.ToInt32(dataGridBuscaFilmes.Rows[i].Cells[0].Value);
                    comboBoxIdFilmes.Items.Add(opcaoId);
                }
            }

            if (conexaoBanco != null) conexaoBanco.Close(); // boa prática de fechar banco quando não está mais sendo requisitado
        }


        private void btnRemoverFilme_Click(object sender, EventArgs e)
        {
            int idFilme = Convert.ToInt32(comboBoxIdFilmes.SelectedItem);
            double nota = Convert.ToDouble(numNotaAvaliacao.Value);
            string comentario = txbComentario.Text.Trim();

            try
            {
                telespectador.adicionarAvaliacao(conexaoBanco, telespectador.getId(), idFilme, nota, comentario);
                clearTextBox();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearTextBox() // redefinir campos após submeter avaliação
        {
            comboBoxIdFilmes.SelectedIndex = -1;
            numNotaAvaliacao.Value = 0;
            txbComentario.Clear();
        }
    }
}
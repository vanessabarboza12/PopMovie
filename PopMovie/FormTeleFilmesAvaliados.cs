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
    public partial class FormTeleFilmesAvaliados : Form
    {
        private Telespectador telespectador;
        private MySqlConnection conexaoBanco;
        public FormTeleFilmesAvaliados(MySqlConnection conexaoBanco, Telespectador telespectador)
        {
            this.conexaoBanco = conexaoBanco;
            this.telespectador = telespectador;
            InitializeComponent();
        }

        private void FormTeleFilmesAvaliados_Load(object sender, EventArgs e)
        {
            conexaoBanco.Open(); // abertura de conexão com o banco;

            // Trecho abaixo é para pegar o id do telespectador logado para poder adicionar corretamente na tabela;
            MySqlCommand cmdPegaIdTelespectador = new MySqlCommand();
            cmdPegaIdTelespectador.Connection = conexaoBanco;
            cmdPegaIdTelespectador.CommandText = "SELECT id FROM tb_telespectador where email=@email";
            cmdPegaIdTelespectador.Parameters.AddWithValue("email", telespectador.getEmail());
            MySqlDataReader leitor = cmdPegaIdTelespectador.ExecuteReader();
            leitor.Read();
            int idTelespectador = leitor.GetInt32(0);
            leitor.Close();
            leitor.Dispose();

            MySqlCommand cmdMinhasAvaliacoes = new MySqlCommand();
            cmdMinhasAvaliacoes.Connection = conexaoBanco;
            cmdMinhasAvaliacoes.CommandText = "SELECT av.id_avaliacao as 'ID do envio', av.data_avaliacao as 'Data de envio', flm.nome as 'Nome do Filme', flm.ano_lancamento as 'Ano', " +
                                               "av.nota_pessoal as 'Nota pessoal', av.comentario as 'Meu comentario' FROM tb_avaliacaofilme as av " +
                                               "INNER JOIN tb_filme as flm ON flm.id = av.id_filme WHERE av.id_telespectador = @id;";
            cmdMinhasAvaliacoes.Parameters.AddWithValue("id", idTelespectador);
            leitor = cmdMinhasAvaliacoes.ExecuteReader();
            DataTable tabelaFilmes = new DataTable();
            tabelaFilmes.Load(leitor);

            dataGridMeusFilmes.DataSource = tabelaFilmes;

            if (conexaoBanco != null) conexaoBanco.Close(); // boa prática de fechar banco quando não está mais sendo requisitado
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoverFilme_Click(object sender, EventArgs e)
        {
            if (dataGridMeusFilmes.CurrentCell != null)
            {
                int idAvaliacao = Convert.ToInt32(dataGridMeusFilmes.CurrentRow.Cells[0].Value);
                dataGridMeusFilmes.Rows.Remove(dataGridMeusFilmes.CurrentRow);

                try
                {
                    telespectador.removerAvaliacao(conexaoBanco, idAvaliacao);
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
                MessageBox.Show("Selecione alguma célula de uma avaliação que você deseja deletar antes de clicar para remover!");
            }
        }
    }
}

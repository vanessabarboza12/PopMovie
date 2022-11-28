namespace PopMovie
{
    partial class FormTeleBuscarFilme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.idFilme = new System.Windows.Forms.Label();
            this.NotaFilme = new System.Windows.Forms.Label();
            this.btnRemoverFilme = new System.Windows.Forms.Button();
            this.dataGridBuscaFilmes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTermoPesquisa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbComentario = new System.Windows.Forms.TextBox();
            this.numNotaAvaliacao = new System.Windows.Forms.NumericUpDown();
            this.comboBoxIdFilmes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscaFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNotaAvaliacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 51);
            this.label1.TabIndex = 25;
            this.label1.Text = "Resultado da Busca";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.btnVoltar.Location = new System.Drawing.Point(672, 412);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 37);
            this.btnVoltar.TabIndex = 28;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // idFilme
            // 
            this.idFilme.AutoSize = true;
            this.idFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFilme.ForeColor = System.Drawing.Color.Red;
            this.idFilme.Location = new System.Drawing.Point(41, 286);
            this.idFilme.Name = "idFilme";
            this.idFilme.Size = new System.Drawing.Size(129, 25);
            this.idFilme.TabIndex = 35;
            this.idFilme.Text = "Id do Filme: ";
            // 
            // NotaFilme
            // 
            this.NotaFilme.AutoSize = true;
            this.NotaFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaFilme.ForeColor = System.Drawing.Color.Red;
            this.NotaFilme.Location = new System.Drawing.Point(41, 335);
            this.NotaFilme.Name = "NotaFilme";
            this.NotaFilme.Size = new System.Drawing.Size(63, 25);
            this.NotaFilme.TabIndex = 36;
            this.NotaFilme.Text = "Nota:";
            // 
            // btnRemoverFilme
            // 
            this.btnRemoverFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            this.btnRemoverFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverFilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.btnRemoverFilme.Location = new System.Drawing.Point(47, 394);
            this.btnRemoverFilme.Name = "btnRemoverFilme";
            this.btnRemoverFilme.Size = new System.Drawing.Size(234, 55);
            this.btnRemoverFilme.TabIndex = 37;
            this.btnRemoverFilme.Text = "Adicionar Avaliação";
            this.btnRemoverFilme.UseVisualStyleBackColor = false;
            this.btnRemoverFilme.Click += new System.EventHandler(this.btnRemoverFilme_Click);
            // 
            // dataGridBuscaFilmes
            // 
            this.dataGridBuscaFilmes.AllowUserToAddRows = false;
            this.dataGridBuscaFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuscaFilmes.Location = new System.Drawing.Point(12, 71);
            this.dataGridBuscaFilmes.MultiSelect = false;
            this.dataGridBuscaFilmes.Name = "dataGridBuscaFilmes";
            this.dataGridBuscaFilmes.ReadOnly = true;
            this.dataGridBuscaFilmes.RowHeadersWidth = 50;
            this.dataGridBuscaFilmes.Size = new System.Drawing.Size(776, 190);
            this.dataGridBuscaFilmes.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(501, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Termo pesquisado: ";
            // 
            // lblTermoPesquisa
            // 
            this.lblTermoPesquisa.AutoSize = true;
            this.lblTermoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermoPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            this.lblTermoPesquisa.Location = new System.Drawing.Point(643, 48);
            this.lblTermoPesquisa.Name = "lblTermoPesquisa";
            this.lblTermoPesquisa.Size = new System.Drawing.Size(18, 20);
            this.lblTermoPesquisa.TabIndex = 40;
            this.lblTermoPesquisa.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(338, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Comentário: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(339, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "(opcional)";
            // 
            // txbComentario
            // 
            this.txbComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComentario.Location = new System.Drawing.Point(467, 284);
            this.txbComentario.Multiline = true;
            this.txbComentario.Name = "txbComentario";
            this.txbComentario.Size = new System.Drawing.Size(294, 88);
            this.txbComentario.TabIndex = 43;
            // 
            // numNotaAvaliacao
            // 
            this.numNotaAvaliacao.DecimalPlaces = 1;
            this.numNotaAvaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNotaAvaliacao.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numNotaAvaliacao.Location = new System.Drawing.Point(176, 335);
            this.numNotaAvaliacao.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNotaAvaliacao.Name = "numNotaAvaliacao";
            this.numNotaAvaliacao.Size = new System.Drawing.Size(105, 29);
            this.numNotaAvaliacao.TabIndex = 44;
            // 
            // comboBoxIdFilmes
            // 
            this.comboBoxIdFilmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIdFilmes.FormattingEnabled = true;
            this.comboBoxIdFilmes.Location = new System.Drawing.Point(176, 284);
            this.comboBoxIdFilmes.Name = "comboBoxIdFilmes";
            this.comboBoxIdFilmes.Size = new System.Drawing.Size(105, 32);
            this.comboBoxIdFilmes.TabIndex = 45;
            // 
            // FormTeleBuscarFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(804, 465);
            this.Controls.Add(this.comboBoxIdFilmes);
            this.Controls.Add(this.numNotaAvaliacao);
            this.Controls.Add(this.txbComentario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTermoPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridBuscaFilmes);
            this.Controls.Add(this.btnRemoverFilme);
            this.Controls.Add(this.NotaFilme);
            this.Controls.Add(this.idFilme);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTeleBuscarFilme";
            this.Text = "Busca de filmes";
            this.Load += new System.EventHandler(this.FormTeleBuscarFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscaFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNotaAvaliacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label idFilme;
        private System.Windows.Forms.Label NotaFilme;
        private System.Windows.Forms.Button btnRemoverFilme;
        private System.Windows.Forms.DataGridView dataGridBuscaFilmes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTermoPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbComentario;
        private System.Windows.Forms.NumericUpDown numNotaAvaliacao;
        private System.Windows.Forms.ComboBox comboBoxIdFilmes;
    }
}
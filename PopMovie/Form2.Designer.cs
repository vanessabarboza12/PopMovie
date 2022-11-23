namespace PopMovie
{
    partial class Busca
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
            this.dataGridMeusFilmes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.selectNota = new System.Windows.Forms.ComboBox();
            this.id_Filme = new System.Windows.Forms.TextBox();
            this.idFilme = new System.Windows.Forms.Label();
            this.NotaFilme = new System.Windows.Forms.Label();
            this.btnRemoverFilme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMeusFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMeusFilmes
            // 
            this.dataGridMeusFilmes.AllowUserToAddRows = false;
            this.dataGridMeusFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMeusFilmes.Location = new System.Drawing.Point(12, 67);
            this.dataGridMeusFilmes.MultiSelect = false;
            this.dataGridMeusFilmes.Name = "dataGridMeusFilmes";
            this.dataGridMeusFilmes.RowHeadersWidth = 50;
            this.dataGridMeusFilmes.Size = new System.Drawing.Size(776, 161);
            this.dataGridMeusFilmes.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 55);
            this.label1.TabIndex = 25;
            this.label1.Text = "Resultado Da Busca";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.btnVoltar.Location = new System.Drawing.Point(672, 403);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 37);
            this.btnVoltar.TabIndex = 28;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // selectNota
            // 
            this.selectNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectNota.FormattingEnabled = true;
            this.selectNota.Location = new System.Drawing.Point(270, 331);
            this.selectNota.Name = "selectNota";
            this.selectNota.Size = new System.Drawing.Size(126, 32);
            this.selectNota.TabIndex = 31;
            // 
            // id_Filme
            // 
            this.id_Filme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_Filme.Location = new System.Drawing.Point(270, 278);
            this.id_Filme.Name = "id_Filme";
            this.id_Filme.Size = new System.Drawing.Size(126, 29);
            this.id_Filme.TabIndex = 32;
            // 
            // idFilme
            // 
            this.idFilme.AutoSize = true;
            this.idFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFilme.ForeColor = System.Drawing.Color.Red;
            this.idFilme.Location = new System.Drawing.Point(41, 278);
            this.idFilme.Name = "idFilme";
            this.idFilme.Size = new System.Drawing.Size(167, 31);
            this.idFilme.TabIndex = 35;
            this.idFilme.Text = "Id Do Filme: ";
            // 
            // NotaFilme
            // 
            this.NotaFilme.AutoSize = true;
            this.NotaFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaFilme.ForeColor = System.Drawing.Color.Red;
            this.NotaFilme.Location = new System.Drawing.Point(41, 332);
            this.NotaFilme.Name = "NotaFilme";
            this.NotaFilme.Size = new System.Drawing.Size(80, 31);
            this.NotaFilme.TabIndex = 36;
            this.NotaFilme.Text = "Nota:";
            // 
            // btnRemoverFilme
            // 
            this.btnRemoverFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            this.btnRemoverFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverFilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.btnRemoverFilme.Location = new System.Drawing.Point(47, 385);
            this.btnRemoverFilme.Name = "btnRemoverFilme";
            this.btnRemoverFilme.Size = new System.Drawing.Size(234, 55);
            this.btnRemoverFilme.TabIndex = 37;
            this.btnRemoverFilme.Text = "Adicionar Avaliação";
            this.btnRemoverFilme.UseVisualStyleBackColor = false;
            // 
            // Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(804, 465);
            this.Controls.Add(this.btnRemoverFilme);
            this.Controls.Add(this.NotaFilme);
            this.Controls.Add(this.idFilme);
            this.Controls.Add(this.id_Filme);
            this.Controls.Add(this.selectNota);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridMeusFilmes);
            this.Name = "Busca";
            this.Text = "Busca";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMeusFilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMeusFilmes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox selectNota;
        private System.Windows.Forms.TextBox id_Filme;
        private System.Windows.Forms.Label idFilme;
        private System.Windows.Forms.Label NotaFilme;
        private System.Windows.Forms.Button btnRemoverFilme;
    }
}
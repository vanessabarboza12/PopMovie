namespace PopMovie
{
    partial class FormTeleFilmesAvaliados
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
            this.btnRemoverFilme = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMeusFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMeusFilmes
            // 
            this.dataGridMeusFilmes.AllowUserToAddRows = false;
            this.dataGridMeusFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMeusFilmes.Location = new System.Drawing.Point(27, 76);
            this.dataGridMeusFilmes.MultiSelect = false;
            this.dataGridMeusFilmes.Name = "dataGridMeusFilmes";
            this.dataGridMeusFilmes.RowHeadersWidth = 50;
            this.dataGridMeusFilmes.Size = new System.Drawing.Size(746, 266);
            this.dataGridMeusFilmes.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 55);
            this.label1.TabIndex = 24;
            this.label1.Text = "Meus Filme";
            // 
            // btnRemoverFilme
            // 
            this.btnRemoverFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            this.btnRemoverFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverFilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.btnRemoverFilme.Location = new System.Drawing.Point(297, 376);
            this.btnRemoverFilme.Name = "btnRemoverFilme";
            this.btnRemoverFilme.Size = new System.Drawing.Size(234, 55);
            this.btnRemoverFilme.TabIndex = 25;
            this.btnRemoverFilme.Text = "Remover Filme";
            this.btnRemoverFilme.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.btnVoltar.Location = new System.Drawing.Point(657, 394);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 37);
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // FormTeleFilmesAvaliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(804, 465);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRemoverFilme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridMeusFilmes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTeleFilmesAvaliados";
            this.Text = "Meus Filmes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMeusFilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMeusFilmes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoverFilme;
        private System.Windows.Forms.Button btnVoltar;
    }
}
namespace PopMovie
{
    partial class RemoverFilme
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
            this.txbGeneroRemovFilme = new System.Windows.Forms.TextBox();
            this.txbNomeRemovFilme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDiretorRemovFilme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "Remover Filme";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbGeneroRemovFilme
            // 
            this.txbGeneroRemovFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGeneroRemovFilme.Location = new System.Drawing.Point(341, 168);
            this.txbGeneroRemovFilme.Name = "txbGeneroRemovFilme";
            this.txbGeneroRemovFilme.Size = new System.Drawing.Size(374, 29);
            this.txbGeneroRemovFilme.TabIndex = 17;
            // 
            // txbNomeRemovFilme
            // 
            this.txbNomeRemovFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeRemovFilme.Location = new System.Drawing.Point(341, 105);
            this.txbNomeRemovFilme.Name = "txbNomeRemovFilme";
            this.txbNomeRemovFilme.Size = new System.Drawing.Size(374, 29);
            this.txbNomeRemovFilme.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Genero do Filme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nome do Filme: ";
            // 
            // txbDiretorRemovFilme
            // 
            this.txbDiretorRemovFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiretorRemovFilme.Location = new System.Drawing.Point(341, 237);
            this.txbDiretorRemovFilme.Name = "txbDiretorRemovFilme";
            this.txbDiretorRemovFilme.Size = new System.Drawing.Size(374, 29);
            this.txbDiretorRemovFilme.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Diretor do Filme: ";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(279, 383);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(273, 59);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(279, 306);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(273, 62);
            this.btnRemover.TabIndex = 20;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // RemoverFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 465);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txbDiretorRemovFilme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbGeneroRemovFilme);
            this.Controls.Add(this.txbNomeRemovFilme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "RemoverFilme";
            this.Text = "RemoverFilme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbGeneroRemovFilme;
        private System.Windows.Forms.TextBox txbNomeRemovFilme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDiretorRemovFilme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRemover;
    }
}
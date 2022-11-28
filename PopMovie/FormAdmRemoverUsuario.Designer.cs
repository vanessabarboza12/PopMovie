namespace PopMovie
{
    partial class FormAdmRemoverUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRemoverConta = new System.Windows.Forms.Button();
            this.dataGridTelespectadores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTelespectadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 55);
            this.label1.TabIndex = 26;
            this.label1.Text = "Gerenciar Telespectadores ";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.btnVoltar.Location = new System.Drawing.Point(659, 400);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 37);
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRemoverConta
            // 
            this.btnRemoverConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            this.btnRemoverConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.btnRemoverConta.Location = new System.Drawing.Point(295, 382);
            this.btnRemoverConta.Name = "btnRemoverConta";
            this.btnRemoverConta.Size = new System.Drawing.Size(234, 55);
            this.btnRemoverConta.TabIndex = 28;
            this.btnRemoverConta.Text = "Remover Conta";
            this.btnRemoverConta.UseVisualStyleBackColor = false;
            this.btnRemoverConta.Click += new System.EventHandler(this.btnRemoverConta_Click);
            // 
            // dataGridTelespectadores
            // 
            this.dataGridTelespectadores.AllowUserToAddRows = false;
            this.dataGridTelespectadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTelespectadores.Location = new System.Drawing.Point(29, 99);
            this.dataGridTelespectadores.MultiSelect = false;
            this.dataGridTelespectadores.Name = "dataGridTelespectadores";
            this.dataGridTelespectadores.ReadOnly = true;
            this.dataGridTelespectadores.RowHeadersWidth = 50;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridTelespectadores.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridTelespectadores.Size = new System.Drawing.Size(746, 266);
            this.dataGridTelespectadores.TabIndex = 30;
            // 
            // FormAdmRemoverUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(804, 465);
            this.Controls.Add(this.dataGridTelespectadores);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRemoverConta);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdmRemoverUsuario";
            this.Text = "Remoção de Conta";
            this.Load += new System.EventHandler(this.FormAdmRemoverUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTelespectadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRemoverConta;
        private System.Windows.Forms.DataGridView dataGridTelespectadores;
    }
}
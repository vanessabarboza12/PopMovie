namespace PopMovie
{
    partial class FormTelespectador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelespectador));
            this.txbBuscaFilme = new System.Windows.Forms.TextBox();
            this.btnBuscarFilme = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMinutosAssistidos = new System.Windows.Forms.Label();
            this.btnMeusFilmes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filtro1 = new System.Windows.Forms.Label();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxValor = new System.Windows.Forms.ComboBox();
            this.btnSairConta = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTotalMinutos = new System.Windows.Forms.Label();
            this.lblTotalFilmes = new System.Windows.Forms.Label();
            this.pictureRecarregarContadores = new System.Windows.Forms.PictureBox();
            this.rBtnSim = new System.Windows.Forms.RadioButton();
            this.rBtnNao = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRecarregarContadores)).BeginInit();
            this.SuspendLayout();
            // 
            // txbBuscaFilme
            // 
            this.txbBuscaFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscaFilme.Location = new System.Drawing.Point(17, 115);
            this.txbBuscaFilme.Name = "txbBuscaFilme";
            this.txbBuscaFilme.Size = new System.Drawing.Size(569, 29);
            this.txbBuscaFilme.TabIndex = 1;
            // 
            // btnBuscarFilme
            // 
            this.btnBuscarFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            this.btnBuscarFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.btnBuscarFilme.Location = new System.Drawing.Point(622, 102);
            this.btnBuscarFilme.Name = "btnBuscarFilme";
            this.btnBuscarFilme.Size = new System.Drawing.Size(153, 51);
            this.btnBuscarFilme.TabIndex = 2;
            this.btnBuscarFilme.Text = "Buscar";
            this.btnBuscarFilme.UseVisualStyleBackColor = false;
            this.btnBuscarFilme.Click += new System.EventHandler(this.btnBuscarFilme_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total de filmes assistidos: ";
            // 
            // lblMinutosAssistidos
            // 
            this.lblMinutosAssistidos.AutoSize = true;
            this.lblMinutosAssistidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutosAssistidos.ForeColor = System.Drawing.Color.Red;
            this.lblMinutosAssistidos.Location = new System.Drawing.Point(15, 387);
            this.lblMinutosAssistidos.Name = "lblMinutosAssistidos";
            this.lblMinutosAssistidos.Size = new System.Drawing.Size(377, 33);
            this.lblMinutosAssistidos.TabIndex = 4;
            this.lblMinutosAssistidos.Text = "Total de minutos assistidos:";
            // 
            // btnMeusFilmes
            // 
            this.btnMeusFilmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            this.btnMeusFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeusFilmes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.btnMeusFilmes.Location = new System.Drawing.Point(622, 209);
            this.btnMeusFilmes.Name = "btnMeusFilmes";
            this.btnMeusFilmes.Size = new System.Drawing.Size(153, 121);
            this.btnMeusFilmes.TabIndex = 7;
            this.btnMeusFilmes.Text = "Meus Filmes";
            this.btnMeusFilmes.UseVisualStyleBackColor = false;
            this.btnMeusFilmes.Click += new System.EventHandler(this.btnMeusFilmes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(16, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(461, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Busque o filme que deseja avaliar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adicionar filtros?";
            // 
            // filtro1
            // 
            this.filtro1.AutoSize = true;
            this.filtro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtro1.ForeColor = System.Drawing.Color.Red;
            this.filtro1.Location = new System.Drawing.Point(16, 209);
            this.filtro1.Name = "filtro1";
            this.filtro1.Size = new System.Drawing.Size(90, 31);
            this.filtro1.TabIndex = 11;
            this.filtro1.Text = "Filtro: ";
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(186, 213);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(400, 32);
            this.comboBoxFiltro.TabIndex = 12;
            this.comboBoxFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltro_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(16, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Opções:";
            // 
            // comboBoxValor
            // 
            this.comboBoxValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxValor.FormattingEnabled = true;
            this.comboBoxValor.Location = new System.Drawing.Point(186, 256);
            this.comboBoxValor.Name = "comboBoxValor";
            this.comboBoxValor.Size = new System.Drawing.Size(400, 32);
            this.comboBoxValor.TabIndex = 14;
            // 
            // btnSairConta
            // 
            this.btnSairConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            this.btnSairConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.btnSairConta.Location = new System.Drawing.Point(627, 349);
            this.btnSairConta.Name = "btnSairConta";
            this.btnSairConta.Size = new System.Drawing.Size(148, 75);
            this.btnSairConta.TabIndex = 17;
            this.btnSairConta.Text = "Sair da conta";
            this.btnSairConta.UseVisualStyleBackColor = false;
            this.btnSairConta.Click += new System.EventHandler(this.btnSairConta_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblUsuario.Location = new System.Drawing.Point(15, 23);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(393, 39);
            this.lblUsuario.TabIndex = 18;
            this.lblUsuario.Text = "Olá, telespectador(a) ?";
            // 
            // lblTotalMinutos
            // 
            this.lblTotalMinutos.AutoSize = true;
            this.lblTotalMinutos.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMinutos.Location = new System.Drawing.Point(409, 388);
            this.lblTotalMinutos.Name = "lblTotalMinutos";
            this.lblTotalMinutos.Size = new System.Drawing.Size(29, 31);
            this.lblTotalMinutos.TabIndex = 20;
            this.lblTotalMinutos.Text = "?";
            // 
            // lblTotalFilmes
            // 
            this.lblTotalFilmes.AutoSize = true;
            this.lblTotalFilmes.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFilmes.Location = new System.Drawing.Point(409, 337);
            this.lblTotalFilmes.Name = "lblTotalFilmes";
            this.lblTotalFilmes.Size = new System.Drawing.Size(29, 31);
            this.lblTotalFilmes.TabIndex = 21;
            this.lblTotalFilmes.Text = "?";
            // 
            // pictureRecarregarContadores
            // 
            this.pictureRecarregarContadores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureRecarregarContadores.BackgroundImage")));
            this.pictureRecarregarContadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureRecarregarContadores.Location = new System.Drawing.Point(482, 339);
            this.pictureRecarregarContadores.Name = "pictureRecarregarContadores";
            this.pictureRecarregarContadores.Size = new System.Drawing.Size(36, 31);
            this.pictureRecarregarContadores.TabIndex = 22;
            this.pictureRecarregarContadores.TabStop = false;
            this.pictureRecarregarContadores.Click += new System.EventHandler(this.pictureRecarregarContadores_Click);
            // 
            // rBtnSim
            // 
            this.rBtnSim.AutoSize = true;
            this.rBtnSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnSim.ForeColor = System.Drawing.Color.White;
            this.rBtnSim.Location = new System.Drawing.Point(330, 163);
            this.rBtnSim.Name = "rBtnSim";
            this.rBtnSim.Size = new System.Drawing.Size(78, 35);
            this.rBtnSim.TabIndex = 23;
            this.rBtnSim.TabStop = true;
            this.rBtnSim.Text = "Sim";
            this.rBtnSim.UseVisualStyleBackColor = true;
            this.rBtnSim.CheckedChanged += new System.EventHandler(this.rBtnSim_CheckedChanged);
            // 
            // rBtnNao
            // 
            this.rBtnNao.AutoSize = true;
            this.rBtnNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnNao.ForeColor = System.Drawing.Color.White;
            this.rBtnNao.Location = new System.Drawing.Point(457, 163);
            this.rBtnNao.Name = "rBtnNao";
            this.rBtnNao.Size = new System.Drawing.Size(82, 35);
            this.rBtnNao.TabIndex = 24;
            this.rBtnNao.TabStop = true;
            this.rBtnNao.Text = "Não";
            this.rBtnNao.UseVisualStyleBackColor = true;
            this.rBtnNao.CheckedChanged += new System.EventHandler(this.rBtnNao_CheckedChanged);
            // 
            // FormTelespectador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(804, 446);
            this.Controls.Add(this.rBtnNao);
            this.Controls.Add(this.rBtnSim);
            this.Controls.Add(this.pictureRecarregarContadores);
            this.Controls.Add(this.lblTotalFilmes);
            this.Controls.Add(this.lblTotalMinutos);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnSairConta);
            this.Controls.Add(this.comboBoxValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.filtro1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMeusFilmes);
            this.Controls.Add(this.lblMinutosAssistidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarFilme);
            this.Controls.Add(this.txbBuscaFilme);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTelespectador";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormTelespectador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRecarregarContadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbBuscaFilme;
        private System.Windows.Forms.Button btnBuscarFilme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMinutosAssistidos;
        private System.Windows.Forms.Button btnMeusFilmes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label filtro1;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxValor;
        private System.Windows.Forms.Button btnSairConta;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTotalMinutos;
        private System.Windows.Forms.Label lblTotalFilmes;
        private System.Windows.Forms.PictureBox pictureRecarregarContadores;
        private System.Windows.Forms.RadioButton rBtnSim;
        private System.Windows.Forms.RadioButton rBtnNao;
    }
}
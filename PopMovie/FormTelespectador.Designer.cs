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
            this.busca_usuario = new System.Windows.Forms.TextBox();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMinutosAssistidos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filtro1 = new System.Windows.Forms.Label();
            this.selectFiltro1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectFiltro2 = new System.Windows.Forms.ComboBox();
            this.checkBox_sim = new System.Windows.Forms.CheckBox();
            this.checkBox_nao = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTotalMinutos = new System.Windows.Forms.Label();
            this.lblTotalFilmes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // busca_usuario
            // 
            this.busca_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busca_usuario.Location = new System.Drawing.Point(17, 115);
            this.busca_usuario.Name = "busca_usuario";
            this.busca_usuario.Size = new System.Drawing.Size(569, 29);
            this.busca_usuario.TabIndex = 1;
            // 
            // buscar_btn
            // 
            this.buscar_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buscar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_btn.Location = new System.Drawing.Point(614, 104);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(161, 49);
            this.buscar_btn.TabIndex = 2;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.UseVisualStyleBackColor = false;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
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
            this.lblMinutosAssistidos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMinutosAssistidos.Location = new System.Drawing.Point(15, 387);
            this.lblMinutosAssistidos.Name = "lblMinutosAssistidos";
            this.lblMinutosAssistidos.Size = new System.Drawing.Size(377, 33);
            this.lblMinutosAssistidos.TabIndex = 4;
            this.lblMinutosAssistidos.Text = "Total de minutos assistidos:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(622, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 121);
            this.button1.TabIndex = 7;
            this.button1.Text = "Meus Filmes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
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
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
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
            this.filtro1.ForeColor = System.Drawing.SystemColors.Window;
            this.filtro1.Location = new System.Drawing.Point(16, 209);
            this.filtro1.Name = "filtro1";
            this.filtro1.Size = new System.Drawing.Size(190, 31);
            this.filtro1.TabIndex = 11;
            this.filtro1.Text = "Primeiro Filtro:";
            // 
            // selectFiltro1
            // 
            this.selectFiltro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFiltro1.FormattingEnabled = true;
            this.selectFiltro1.Location = new System.Drawing.Point(345, 213);
            this.selectFiltro1.Name = "selectFiltro1";
            this.selectFiltro1.Size = new System.Drawing.Size(241, 32);
            this.selectFiltro1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(16, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Segundo Filtro:";
            // 
            // selectFiltro2
            // 
            this.selectFiltro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFiltro2.FormattingEnabled = true;
            this.selectFiltro2.Location = new System.Drawing.Point(345, 256);
            this.selectFiltro2.Name = "selectFiltro2";
            this.selectFiltro2.Size = new System.Drawing.Size(241, 32);
            this.selectFiltro2.TabIndex = 14;
            // 
            // checkBox_sim
            // 
            this.checkBox_sim.AutoSize = true;
            this.checkBox_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sim.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox_sim.Location = new System.Drawing.Point(345, 163);
            this.checkBox_sim.Name = "checkBox_sim";
            this.checkBox_sim.Size = new System.Drawing.Size(79, 35);
            this.checkBox_sim.TabIndex = 15;
            this.checkBox_sim.Text = "Sim";
            this.checkBox_sim.UseVisualStyleBackColor = true;
            // 
            // checkBox_nao
            // 
            this.checkBox_nao.AutoSize = true;
            this.checkBox_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_nao.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox_nao.Location = new System.Drawing.Point(506, 163);
            this.checkBox_nao.Name = "checkBox_nao";
            this.checkBox_nao.Size = new System.Drawing.Size(83, 35);
            this.checkBox_nao.TabIndex = 16;
            this.checkBox_nao.Text = "Não";
            this.checkBox_nao.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(627, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 75);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sair da conta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Window;
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
            // FormTelespectador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(804, 446);
            this.Controls.Add(this.lblTotalFilmes);
            this.Controls.Add(this.lblTotalMinutos);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox_nao);
            this.Controls.Add(this.checkBox_sim);
            this.Controls.Add(this.selectFiltro2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectFiltro1);
            this.Controls.Add(this.filtro1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMinutosAssistidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscar_btn);
            this.Controls.Add(this.busca_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTelespectador";
            this.Text = "Tela Telespectador";
            this.Load += new System.EventHandler(this.FormTelespectador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox busca_usuario;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMinutosAssistidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label filtro1;
        private System.Windows.Forms.ComboBox selectFiltro1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectFiltro2;
        private System.Windows.Forms.CheckBox checkBox_sim;
        private System.Windows.Forms.CheckBox checkBox_nao;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTotalMinutos;
        private System.Windows.Forms.Label lblTotalFilmes;
    }
}
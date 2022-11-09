namespace PopMovie
{
    partial class TelaUsuario
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
            this.busca_usuario = new System.Windows.Forms.TextBox();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filtro1 = new System.Windows.Forms.Label();
            this.selectFiltro1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectFiltro2 = new System.Windows.Forms.ComboBox();
            this.checkBox_sim = new System.Windows.Forms.CheckBox();
            this.checkBox_nao = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Olá, Usuário";
            // 
            // busca_usuario
            // 
            this.busca_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busca_usuario.Location = new System.Drawing.Point(19, 106);
            this.busca_usuario.Name = "busca_usuario";
            this.busca_usuario.Size = new System.Drawing.Size(463, 29);
            this.busca_usuario.TabIndex = 1;
            // 
            // buscar_btn
            // 
            this.buscar_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buscar_btn.Location = new System.Drawing.Point(501, 103);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(119, 32);
            this.buscar_btn.TabIndex = 2;
            this.buscar_btn.Text = "Buscar!";
            this.buscar_btn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total de filmes assistidos: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total de minutos assistidos:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(411, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 29);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(432, 364);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 29);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(501, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 93);
            this.button1.TabIndex = 7;
            this.button1.Text = "Meus Filmes!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(426, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Busque o filme que deseja avaliar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adicionar filtros?";
            // 
            // filtro1
            // 
            this.filtro1.AutoSize = true;
            this.filtro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtro1.Location = new System.Drawing.Point(13, 185);
            this.filtro1.Name = "filtro1";
            this.filtro1.Size = new System.Drawing.Size(190, 31);
            this.filtro1.TabIndex = 11;
            this.filtro1.Text = "Primeiro Filtro:";
            // 
            // selectFiltro1
            // 
            this.selectFiltro1.FormattingEnabled = true;
            this.selectFiltro1.Location = new System.Drawing.Point(209, 195);
            this.selectFiltro1.Name = "selectFiltro1";
            this.selectFiltro1.Size = new System.Drawing.Size(156, 21);
            this.selectFiltro1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Segundo Filtro:";
            // 
            // selectFiltro2
            // 
            this.selectFiltro2.FormattingEnabled = true;
            this.selectFiltro2.Location = new System.Drawing.Point(209, 244);
            this.selectFiltro2.Name = "selectFiltro2";
            this.selectFiltro2.Size = new System.Drawing.Size(156, 21);
            this.selectFiltro2.TabIndex = 14;
            // 
            // checkBox_sim
            // 
            this.checkBox_sim.AutoSize = true;
            this.checkBox_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sim.Location = new System.Drawing.Point(234, 144);
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
            this.checkBox_nao.Location = new System.Drawing.Point(326, 145);
            this.checkBox_nao.Name = "checkBox_nao";
            this.checkBox_nao.Size = new System.Drawing.Size(83, 35);
            this.checkBox_nao.TabIndex = 16;
            this.checkBox_nao.Text = "Não";
            this.checkBox_nao.UseVisualStyleBackColor = true;
            // 
            // TelaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 409);
            this.Controls.Add(this.checkBox_nao);
            this.Controls.Add(this.checkBox_sim);
            this.Controls.Add(this.selectFiltro2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectFiltro1);
            this.Controls.Add(this.filtro1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscar_btn);
            this.Controls.Add(this.busca_usuario);
            this.Controls.Add(this.label1);
            this.Name = "TelaUsuario";
            this.Text = "TelaUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox busca_usuario;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label filtro1;
        private System.Windows.Forms.ComboBox selectFiltro1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectFiltro2;
        private System.Windows.Forms.CheckBox checkBox_sim;
        private System.Windows.Forms.CheckBox checkBox_nao;
    }
}
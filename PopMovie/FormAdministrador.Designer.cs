namespace PopMovie
{
    partial class FormAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.adcFilme_btn = new System.Windows.Forms.Button();
            this.removeFilm_btn = new System.Windows.Forms.Button();
            this.gerenciarContas_btn = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdministrador
            // 
            resources.ApplyResources(this.lblAdministrador, "lblAdministrador");
            this.lblAdministrador.ForeColor = System.Drawing.Color.Red;
            this.lblAdministrador.Name = "lblAdministrador";
            // 
            // adcFilme_btn
            // 
            this.adcFilme_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.adcFilme_btn, "adcFilme_btn");
            this.adcFilme_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.adcFilme_btn.Name = "adcFilme_btn";
            this.adcFilme_btn.UseVisualStyleBackColor = false;
            this.adcFilme_btn.Click += new System.EventHandler(this.adcFilme_btn_Click);
            // 
            // removeFilm_btn
            // 
            this.removeFilm_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.removeFilm_btn, "removeFilm_btn");
            this.removeFilm_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.removeFilm_btn.Name = "removeFilm_btn";
            this.removeFilm_btn.UseVisualStyleBackColor = false;
            this.removeFilm_btn.Click += new System.EventHandler(this.removeFilm_btn_Click);
            // 
            // gerenciarContas_btn
            // 
            this.gerenciarContas_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.gerenciarContas_btn, "gerenciarContas_btn");
            this.gerenciarContas_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.gerenciarContas_btn.Name = "gerenciarContas_btn";
            this.gerenciarContas_btn.UseVisualStyleBackColor = false;
            this.gerenciarContas_btn.Click += new System.EventHandler(this.gerenciarContas_btn_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(193)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormAdministrador
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gerenciarContas_btn);
            this.Controls.Add(this.removeFilm_btn);
            this.Controls.Add(this.adcFilme_btn);
            this.Controls.Add(this.lblAdministrador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Button adcFilme_btn;
        private System.Windows.Forms.Button removeFilm_btn;
        private System.Windows.Forms.Button gerenciarContas_btn;
        private System.Windows.Forms.Button btnSair;
    }
}
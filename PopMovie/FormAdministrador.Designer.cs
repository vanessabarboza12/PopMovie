﻿namespace PopMovie
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
            this.gerencia_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdministrador
            // 
            resources.ApplyResources(this.lblAdministrador, "lblAdministrador");
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Click += new System.EventHandler(this.label1_Click);
            // 
            // adcFilme_btn
            // 
            this.adcFilme_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.adcFilme_btn, "adcFilme_btn");
            this.adcFilme_btn.Name = "adcFilme_btn";
            this.adcFilme_btn.UseVisualStyleBackColor = false;
            this.adcFilme_btn.Click += new System.EventHandler(this.adcFilme_btn_Click);
            // 
            // removeFilm_btn
            // 
            this.removeFilm_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.removeFilm_btn, "removeFilm_btn");
            this.removeFilm_btn.Name = "removeFilm_btn";
            this.removeFilm_btn.UseVisualStyleBackColor = false;
            // 
            // gerencia_btn
            // 
            this.gerencia_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.gerencia_btn, "gerencia_btn");
            this.gerencia_btn.Name = "gerencia_btn";
            this.gerencia_btn.UseVisualStyleBackColor = false;
            // 
            // FormAdministrador
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.gerencia_btn);
            this.Controls.Add(this.removeFilm_btn);
            this.Controls.Add(this.adcFilme_btn);
            this.Controls.Add(this.lblAdministrador);
            this.Name = "FormAdministrador";
            this.Load += new System.EventHandler(this.FormAdministrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Button adcFilme_btn;
        private System.Windows.Forms.Button removeFilm_btn;
        private System.Windows.Forms.Button gerencia_btn;
    }
}
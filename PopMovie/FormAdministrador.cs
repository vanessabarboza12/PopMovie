﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopMovie
{
    public partial class FormAdministrador : Form
    {
        private Administrador administrador;
        public FormAdministrador(Administrador a)
        {
            this.administrador = a;
            InitializeComponent();
            lblAdministrador.Text = "Olá, administrador(a) " + administrador.getNome();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adcFilme_btn_Click(object sender, EventArgs e)
        {

        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}

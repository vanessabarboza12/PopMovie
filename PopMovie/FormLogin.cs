﻿using MySql.Data.MySqlClient;
using System;
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
    public partial class FormLogin : Form
    {
        private BancoDeDados banco;
        public FormLogin(BancoDeDados banco)
        {
            InitializeComponent();
            this.banco = banco;
            txbSenha.PasswordChar = '*';
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {


        }
    }
}

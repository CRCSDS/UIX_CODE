﻿using System;
using System.Windows.Forms;

namespace unix_code
{
    public partial class Muestra : Form
    {
        public Muestra(String user)
        {
            InitializeComponent();
            String username = user;
            labelUsername.Text = username;
        }
        private void Muestra_Load(object sender, EventArgs e)
        {

        }

        private void cerrarsesion_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form3 = new Login();
            form3.Show();
        }
    }
}

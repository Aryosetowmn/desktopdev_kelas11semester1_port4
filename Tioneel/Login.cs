﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tioneel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                new Dashboard().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                txtPassword.Clear();
                txtUsername.Clear();
                txtPassword.Focus();
            }
        }
    }
}

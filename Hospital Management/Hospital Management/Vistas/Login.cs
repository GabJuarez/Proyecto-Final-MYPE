﻿using Hospital_Management.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUser.Focus();
        }
        private void Login_Load(object sender, EventArgs e) { }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string user;
            string pass;
            user = txtUser.Text;
            pass = txtPassword.Text;
            
            if (user == "Gabriel" && pass == "juarez"){
                this.Hide();
                Controles menu = new Controles();
                menu.Show(); 
            }
            else if (user == "Gabriel" && pass == "cuevas")
            {
                this.Hide();
                OpPacientes op = new OpPacientes();
                op.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        
    }
}

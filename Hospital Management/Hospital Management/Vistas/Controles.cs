using Hospital_Management.Modelo_de_datos;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management.Vistas
{
    public partial class Controles : Form
    {
        public Controles()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e){ }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label6_Click(object sender, EventArgs e) { }     
        private void label5_Click(object sender, EventArgs e) { }      
        private void label4_Click(object sender, EventArgs e) { }        
        private void label3_Click(object sender, EventArgs e) { }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroForm registro = new RegistroForm();
            registro.Show();
        }

        

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial historial = new Historial();
            historial.Show();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estadisticas estadisticas = new Estadisticas();
            estadisticas.Show();
        }
    }
}

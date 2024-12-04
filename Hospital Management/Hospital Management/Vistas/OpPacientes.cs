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
    public partial class OpPacientes : Form
    {
        public OpPacientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void OpPacientes_Load(object sender, EventArgs e)
        {
            
        }
        /*En este formulario solo se realizan instancias de las otras pantallas del apartado de los pacientes
         este formulario contiene controles para ir a la pantalla de las citas y a la pantalla de estadisticas,
        tambien posee la opcion de cerrar la aplicacion y de volver al a la pantalla de ingreso de credenciales*/
        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendarCita agendar = new AgendarCita();
            agendar.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e) { }
        private void btnEstadisticas_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EstadisticasCitas estadisticasc = new EstadisticasCitas();
            estadisticasc.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteCitas formReportes = new ReporteCitas();
            formReportes.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}

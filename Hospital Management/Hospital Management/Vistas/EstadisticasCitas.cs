using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Hospital_Management.Modelo_de_datos;

namespace Hospital_Management.Vistas
{
    public partial class EstadisticasCitas : Form
    {
        public EstadisticasCitas()
        {
            InitializeComponent();
            this.Load += new EventHandler(EstadisticasCitas_Load);
        }

        private void EstadisticasCitas_Load(object sender, EventArgs e)
        {
            CargarDatosCitas();
            CrearGraficosDoctoresYHoras();
        }
        private void EstadisticasCitas_Load_1(object sender, EventArgs e) { }

        private void CargarDatosCitas()
        {
            AgendarCita agendarCita = new AgendarCita();
            agendarCita.ConfigurarDataGridView();
            agendarCita.ActualizarDataGridView();
        }

        private void CrearGraficosDoctoresYHoras()
        {
            CrearGraficoDoctores();
            CrearGraficoHoras();
        }

        private void CrearGraficoDoctores()
        {
            chartDoctores.Series.Clear();
            chartDoctores.Legends.Clear(); 

            // agrupando las citas

            var datosDoctores = ListaC.Citas
                .GroupBy(c => c.Doctor)
                .Select(g => new { Doctor = g.Key, Total = g.Count() })
                .ToList();

            if (chartDoctores.Series.Count == 0)
            {
                chartDoctores.Series.Add("Doctores");  
            }

            // agregando los puntos al gráfico
            foreach (var item in datosDoctores)
            {
                chartDoctores.Series[0].Points.AddXY(item.Doctor, item.Total);
            }
        }

        private void CrearGraficoHoras()
        {
            chartHoras.Series.Clear();  
            chartHoras.Legends.Clear();

            //agrupando las citas
            var datosHoras = ListaC.Citas
                .GroupBy(c => c.Hora)
                .Select(g => new { Hora = g.Key, Total = g.Count() })
                .ToList();

            if (chartHoras.Series.Count == 0)
            {
                chartHoras.Series.Add("Horas");  
            }

            foreach (var item in datosHoras)
            {
                chartHoras.Series[0].Points.AddXY(item.Hora, item.Total);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario de estadísticas y mostrar el formulario de pacientes
            this.Hide();
            OpPacientes controles = new OpPacientes();
            controles.Show();
        }
    }
}

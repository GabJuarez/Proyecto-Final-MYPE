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
            // Asociamos el evento de carga del formulario
            this.Load += new EventHandler(EstadisticasCitas_Load);
        }

        private void EstadisticasCitas_Load(object sender, EventArgs e)
        {
            // Cargar los datos de las citas y crear los gráficos al cargar el formulario
            CargarDatosCitas();
            CrearGraficosDoctoresYHoras();
        }
        private void EstadisticasCitas_Load_1(object sender, EventArgs e) { }

        private void CargarDatosCitas()
        {
            // Asegurarse de que los datos de las citas estén cargados
            AgendarCita agendarCita = new AgendarCita();
            agendarCita.ConfigurarDataGridView();
            agendarCita.ActualizarDataGridView();
        }

        private void CrearGraficosDoctoresYHoras()
        {
            // Crear los gráficos de Doctores y Horas
            CrearGraficoDoctores();
            CrearGraficoHoras();
        }

        private void CrearGraficoDoctores()
        {
            // Actualizar datos del gráfico de Doctores
            chartDoctores.Series.Clear();  // Elimina las series del gráfico
            chartDoctores.Legends.Clear(); // Elimina las leyendas

            // Agrupar las citas por Doctor y contar el total de citas
            var datosDoctores = ListaC.Citas
                .GroupBy(c => c.Doctor)
                .Select(g => new { Doctor = g.Key, Total = g.Count() })
                .ToList();

            // Crear una nueva serie si no existe
            if (chartDoctores.Series.Count == 0)
            {
                chartDoctores.Series.Add("Doctores");  // Añadir una serie con nombre
            }

            // Agregar los puntos al gráfico
            foreach (var item in datosDoctores)
            {
                chartDoctores.Series[0].Points.AddXY(item.Doctor, item.Total);
            }
        }

        private void CrearGraficoHoras()
        {
            // Actualizar datos del gráfico de Horas
            chartHoras.Series.Clear();  // Elimina las series del gráfico
            chartHoras.Legends.Clear(); // Elimina las leyendas

            // Agrupar las citas por Hora y contar el total de citas
            var datosHoras = ListaC.Citas
                .GroupBy(c => c.Hora)
                .Select(g => new { Hora = g.Key, Total = g.Count() })
                .ToList();

            // Crear una nueva serie si no existe
            if (chartHoras.Series.Count == 0)
            {
                chartHoras.Series.Add("Horas");  // Añadir una serie con nombre
            }

            // Agregar los puntos al gráfico
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

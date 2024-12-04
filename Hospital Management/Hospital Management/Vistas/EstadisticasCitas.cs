using System;
using System.Collections.Generic;
using System.Drawing;
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
            agendarCita.Show();
            agendarCita.Hide();
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

            chartDoctores.Series[0].ChartType = SeriesChartType.RangeBar;


            // diccionario de colores para los doctores
            var coloresDoctores = new Dictionary<string, Color>
            {
                 { "Gabriel", Color.DeepSkyBlue },
                 { "Silvio", Color.LightGreen },
                 { "Alex", Color.IndianRed },
                 { "Slles", Color.Orange },
                 { "Juan", Color.Purple },
                 { "Anthony", Color.Brown },
                 { "Jenora", Color.Magenta },
                 { "Regina", Color.Cyan }
            };

            // agregando los puntos al gráfico con colores específicos
            foreach (var item in datosDoctores)
            {
                int pointIndex = chartDoctores.Series[0].Points.AddXY(item.Doctor, item.Total);
                chartDoctores.Series[0].Points[pointIndex].Color = coloresDoctores[item.Doctor];
                // Configurar las labels para mostrar el nombre del doctor y el total de citas
                chartDoctores.Series[0].Points[pointIndex].Label = $"{item.Doctor}\n{item.Total}";

              
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

            chartHoras.Series[0].ChartType = SeriesChartType.Pyramid;

            var coloresHoras = new Dictionary<string, Color> 
            {
                { "08:00 - 09:00", Color.DeepSkyBlue },
                { "10:00 - 11:00", Color.LightGreen },
                { "01:00 - 02:00", Color.IndianRed },
                { "03:00 - 04:00", Color.DeepPink }
            };

            foreach (var item in datosHoras)
            {
                int pointIndex = chartHoras.Series[0].Points.AddXY(item.Hora, item.Total);
                if (coloresHoras.ContainsKey(item.Hora))
                {
                    chartHoras.Series[0].Points[pointIndex].Color = coloresHoras[item.Hora];
                }

                var porcentaje = (double)item.Total / ListaC.Citas.Count * 100;

                // configuracion de las etiquetas mostrando los porcentajes en el grafico
                chartHoras.Series[0].Points[pointIndex].Label = $"{item.Hora}\n{item.Total} ({porcentaje:F2}%)";
                chartHoras.Series[0].Points[pointIndex].ToolTip = $"{item.Hora}: {item.Total} citas ({porcentaje:F2}%)";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpPacientes controles = new OpPacientes();
            controles.Show();
        }
    }
}

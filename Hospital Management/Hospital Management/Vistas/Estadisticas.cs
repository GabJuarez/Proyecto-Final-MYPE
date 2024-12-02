using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Hospital_Management.Modelo_de_datos;

namespace Hospital_Management.Vistas
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
            this.Load += new EventHandler(Estadisticas_Load);
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            Historial historial = new Historial();
            historial.ActualizarDataGridView();

            CrearGraficos();
        }

        private void CrearGraficos()
        {
            List<Registro> registros = ListaR.Registros;

            if (registros == null || registros.Count == 0)
            {
                MessageBox.Show("No hay datos disponibles para crear los gráficos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // actualizar los datos
            chartGenero.Series.Clear(); 
            chartGenero.Legends.Clear(); 
            var datosGenero = registros.GroupBy(r => r.Genero)
                                       .Select(g => new { Genero = g.Key, Total = g.Count() })
                                       .ToList();

      
            if (chartGenero.Series.Count == 0)
            {
                chartGenero.Series.Add("Genero"); 
            }

            foreach (var item in datosGenero)
            {
                chartGenero.Series[0].Points.AddXY(item.Genero, item.Total);
            }

          // actualizaar requerimiento de sala
            chartRequerimientoSala.Series.Clear(); 
            chartRequerimientoSala.Legends.Clear(); 
            var datosSala = registros.GroupBy(r => r.RequerimientoDeSala)
                                     .Select(g => new { RequerimientoDeSala = g.Key, Total = g.Count() })
                                     .ToList();

           
            if (chartRequerimientoSala.Series.Count == 0)
            {
                chartRequerimientoSala.Series.Add("RequerimientoSala"); 
            }

            foreach (var item in datosSala)
            {
                chartRequerimientoSala.Series[0].Points.AddXY(item.RequerimientoDeSala, item.Total);
            }

            // actualizar tipo de sangre
            chartTipoSangre.Series.Clear(); 
            chartTipoSangre.Legends.Clear(); 
            var datosSangre = registros.GroupBy(r => r.Tiposangre)
                                       .Select(g => new { TipoSangre = g.Key, Total = g.Count() })
                                       .ToList();

            if (chartTipoSangre.Series.Count == 0)
            {
                chartTipoSangre.Series.Add("TipoSangre"); 
            }

            foreach (var item in datosSangre)
            {
                chartTipoSangre.Series[0].Points.AddXY(item.TipoSangre, item.Total);
            }
        }

        private Chart CrearGrafico(string titulo, IEnumerable<object> data, string xValueMember, string yValueMember, SeriesChartType chartType)
        {
            // Crear y configurar un gráfico genérico
            Chart chart = new Chart();
            chart.Titles.Add(titulo);

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                ChartType = chartType,
                IsValueShownAsLabel = true // Mostrar los valores en las etiquetas
            };
            series.Points.DataBind(data, xValueMember, yValueMember, null);

            chart.Series.Add(series);
            return chart;
        }

        private void AjustarTamañoGrafico(Chart chart)
        {
            // Ajustar el tamaño para que todos los gráficos quepan en el formulario
            chart.Dock = DockStyle.Top;
            chart.Height = this.Height / 3;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controles controles = new Controles();
            controles.Show();
        }
    }
}

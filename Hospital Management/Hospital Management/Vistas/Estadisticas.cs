using System;
using System.Collections.Generic;
using System.Drawing;
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
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            // Cargar el historial de datos al iniciar el formulario
            Historial historial = new Historial();
            historial.ActualizarDataGridView();

            CrearGraficos();
        }

        private void CrearGraficos()
        {
            //el to list que sale mas adelante en la creacion de los graficos es para que la consulta se ejecute inmediatamente

            List<Registro> registros = ListaR.Registros;

            if (registros == null || registros.Count == 0)
            {
                MessageBox.Show("No hay datos disponibles para crear los gráficos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            chartGenero.Series.Clear();
            chartGenero.Legends.Clear();

            // agrupando
            var datosGenero = registros.GroupBy(r => r.Genero)
                                       .Select(g => new { Genero = g.Key, Total = g.Count() })
                                       .ToList();

            if (chartGenero.Series.Count == 0)
            {
                chartGenero.Series.Add("Genero"); // Crear serie genero
            }

            // personalizacion de colores de los graficos
            foreach (var item in datosGenero)
            {
                int pointIndex = chartGenero.Series[0].Points.AddXY(item.Genero, item.Total);
                // Asignacion de colores
                chartGenero.Series[0].Points[pointIndex].Color = item.Genero == "Masculino" ? Color.DeepSkyBlue : Color.Pink;
            }

            // chart de requerimiento de sala
            chartRequerimientoSala.Series.Clear(); // limpiando
            chartRequerimientoSala.Legends.Clear();

            // Agrupando
            var datosSala = registros.GroupBy(r => r.RequerimientoDeSala)
                                     .Select(g => new { RequerimientoDeSala = g.Key, Total = g.Count() })
                                     .ToList();

            // Crear la serie
            if (chartRequerimientoSala.Series.Count == 0)
            {
                chartRequerimientoSala.Series.Add("RequerimientoSala"); //crear serie requerimiento de sala
            }

            chartRequerimientoSala.Series[0].ChartType = SeriesChartType.RangeBar; //formato del grafico
                                                                                   // Agregar los datos con colores personalizados
            foreach (var item in datosSala)
            {
                int pointIndex = chartRequerimientoSala.Series[0].Points.AddXY(item.RequerimientoDeSala, item.Total);
                // asignacion de colores
                chartRequerimientoSala.Series[0].Points[pointIndex].Color = item.RequerimientoDeSala == "Sí" ? Color.Green : Color.Red;
            }

            //chart de tipo de sangre
            chartTipoSangre.Series.Clear(); //limpiando
            chartTipoSangre.Legends.Clear();

            // aqui creo la leyenda para el grafico de pastel
            Legend leyenda = new Legend();
            leyenda.Docking = Docking.Bottom;
            chartTipoSangre.Legends.Add(leyenda);

            // Agrupando
            var datosSangre = registros.GroupBy(r => r.Tiposangre)
                                       .Select(g => new { TipoSangre = g.Key, Total = g.Count() })
                                       .ToList();

            if (chartTipoSangre.Series.Count == 0)
            {
                chartTipoSangre.Series.Add("TipoSangre");  // creando serie tipo de sangre
            }

            chartTipoSangre.Series[0].ChartType = SeriesChartType.Pie; // dando formato pastel al chart

            // agregando los datos con etiquetas
            foreach (var item in datosSangre)
            {
                int pointIndex = chartTipoSangre.Series[0].Points.AddXY(item.TipoSangre, item.Total);
                chartTipoSangre.Series[0].Points[pointIndex].Label = $"{item.TipoSangre}: {item.Total} ({item.Total * 100.0 / registros.Count:F1}%)";
            }
        }




        private void AjustarTamañoGrafico(Chart chart)
        {
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

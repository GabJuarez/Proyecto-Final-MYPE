using Hospital_Management.Modelo_de_datos;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management.Vistas
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controles controles = new Controles();
            controles.Show();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        public void ActualizarDataGridView()
        {
            FileStream fs = null;
            BinaryReader reader = null;

            try
            {
                // Verificar si el archivo de registros existe
                if (!File.Exists("registros.bin"))
                {
                    dgvHistorial.DataSource = null;
                    MessageBox.Show("No se encontraron registros guardados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Abrir el archivo para leer
                fs = new FileStream("registros.bin", FileMode.Open);
                reader = new BinaryReader(fs);

                List<Registro> registros = new List<Registro>();

                // Leer los datos del archivo y agregarlos a la lista
                while (fs.Position < fs.Length)
                {
                    string id = reader.ReadString();
                    string nombre = reader.ReadString();
                    string direccion = reader.ReadString();
                    string contacto = reader.ReadString();
                    string edad = reader.ReadString();
                    string genero = reader.ReadString();
                    string tipoSangre = reader.ReadString();
                    string enfermedadAnterior = reader.ReadString();
                    string sintomas = reader.ReadString();
                    string diagnostico = reader.ReadString();
                    string medicamentos = reader.ReadString();
                    string requerimientodesala = reader.ReadString();
                    string tipodesala = reader.ReadString();

                    // Crear un nuevo registro y agregarlo a la lista
                    registros.Add(new Registro(id, nombre, direccion, contacto, edad, genero, tipoSangre, enfermedadAnterior, sintomas, diagnostico, medicamentos, requerimientodesala, tipodesala));
                }

                // Actualizar el DataGridView con los registros leídos
                dgvHistorial.DataSource = registros;

                // Almacenar los registros en la clase estática DataStore (si es necesario)
                ListaR.Registros = registros;
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre alguna excepción
                MessageBox.Show($"Error al actualizar el DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar los objetos BinaryReader y FileStream para liberar recursos
                reader?.Close();
                fs?.Close();
            }
        }


        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvHistorial_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (dgvHistorial.SelectedRows.Count > 0)
            {
                int rowIndex = dgvHistorial.SelectedRows[0].Index;

                Registro registroSeleccionado = (Registro)dgvHistorial.Rows[rowIndex].DataBoundItem;

                EditarRegistroForm frmEditar = new EditarRegistroForm(registroSeleccionado);

                if (frmEditar.ShowDialog() == DialogResult.OK)
                {
                    ActualizarDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }
        
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            ReportDataSource dataSource = new ReportDataSource("dsRegistros", ListaR.Registros);
            ReporteRegistros reporte = new ReporteRegistros();
            reporte.ReportViewer2.LocalReport.DataSources.Clear();
            reporte.ReportViewer2.LocalReport.DataSources.Add(dataSource);
            reporte.ReportViewer2.LocalReport.ReportEmbeddedResource = "Hospital_Management.Reportes.rptRegistros.rdlc";
            reporte.ReportViewer2.RefreshReport();
            reporte.ShowDialog();
        }
        











    }

}



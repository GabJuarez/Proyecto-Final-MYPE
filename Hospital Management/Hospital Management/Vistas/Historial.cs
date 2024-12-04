using Hospital_Management.Modelo_de_datos;
using Microsoft.Reporting.WinForms;
using OfficeOpenXml;
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
using LicenseContext = OfficeOpenXml.LicenseContext;

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
                if (!File.Exists("registros.bin"))
                {
                    dgvHistorial.DataSource = null;
                    MessageBox.Show("No se encontraron registros guardados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                fs = new FileStream("registros.bin", FileMode.Open);
                reader = new BinaryReader(fs);

                ListaR.Registros.Clear();

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


                    ListaR.Registros.Add(new Registro(id, nombre, direccion, contacto, edad, genero, tipoSangre, enfermedadAnterior, sintomas, diagnostico, medicamentos, requerimientodesala, tipodesala));
                }


                dgvHistorial.DataSource = null;
                dgvHistorial.DataSource = ListaR.Registros;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al actualizar el DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
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

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

            ExportarAExcel();

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        #region metodoExcel
        private DataTable CrearDataTableConEncabezados()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Contacto", typeof(string));
            dt.Columns.Add("Edad", typeof(int));
            dt.Columns.Add("Genero", typeof(string));
            dt.Columns.Add("Tipo de Sangre", typeof(string));
            dt.Columns.Add("Enfermedad Anterior", typeof(string));
            dt.Columns.Add("Sintomas", typeof(string));
            dt.Columns.Add("Diagnostico", typeof(string));
            dt.Columns.Add("Medicamentos", typeof(string));
            dt.Columns.Add("Requerimiento de Sala", typeof(string));
            dt.Columns.Add("Tipo de Sala", typeof(string));

            foreach (var Registro in ListaR.Registros)
            {
                DataRow row = dt.NewRow();
                row["Id"] = Registro.Id;
                row["Nombre"] = Registro.Nombre;
                row["Contacto"] = Registro.Ncontacto;
                row["Edad"] = Registro.Edad;
                row["Genero"] = Registro.Genero;
                row["Tipo de Sangre"] = Registro.Tiposangre;
                row["Enfermedad Anterior"] = Registro.Enfermedadanterior;
                row["Sintomas"] = Registro.Sintomas;
                row["Diagnostico"] = Registro.Diagnostico;
                row["Medicamentos"] = Registro.Medicamentos;
                row["Requerimiento de Sala"] = Registro.RequerimientoDeSala;
                row["Tipo de Sala"] = Registro.TipoDeSala;

                dt.Rows.Add(row);
            }

            return dt;
        }

        private void ExportarAExcel()
        {
            try
            {
                // Configurar el contexto de la licencia para EPPlus
                ExcelPackage.LicenseContext = LicenseContext.Commercial;

                DataTable dt = CrearDataTableConEncabezados();

              
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Registros");

                    worksheet.Cells["A1"].LoadFromDataTable(dt, PrintHeaders: true);

                    // Usar SaveFileDialog para seleccionar la ubicación y nombre del archivo Excel
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                        saveFileDialog.Title = "Guardar archivo Excel";
                        saveFileDialog.FileName = "InformeRegistros.xlsx"; 

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // obtener la ruta seleccionada por el usuario
                            string filePath = saveFileDialog.FileName;

                            // guardar el archivo Excel en la ubicación seleccionada
                            File.WriteAllBytes(filePath, package.GetAsByteArray());

                           MessageBox.Show("El archivo Excel ha sido generado exitosamente en: " + filePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Error al generar el informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }
    }
}
            
        





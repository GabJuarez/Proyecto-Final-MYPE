﻿using Hospital_Management.Modelo_de_datos;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management.Vistas
{
    public partial class AgendarCita : Form
    {
        public AgendarCita()
        {
            InitializeComponent();
        }

        private void AgendarCita_Load(object sender, EventArgs e)
        {
            
            dgvCitas.MultiSelect = false;
            ConfigurarDataGridView();
            CargarCitasDesdeArchivo();
            btnGuardar.Enabled = false;
            mtxtFecha.ValidatingType = typeof(System.DateTime);
            Limpiar();

        }

        public List<Cita> citas = new List<Cita>();
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpPacientes controles = new OpPacientes();
            controles.Show();
        }

        private void Validar()
        {
       
            
            if (cmbHora.SelectedIndex != -1 &&  
                cmbDoctor.SelectedIndex != -1 &&  
                cmbConsultorio.SelectedIndex != -1 && 
                !string.IsNullOrEmpty(rtxtMotivo.Text) &&  
                !string.IsNullOrEmpty(rtxtComentarios.Text) &&  
                !string.IsNullOrEmpty(mtxtFecha.Text) && mtxtFecha.MaskFull)  
            {
                btnGuardar.Enabled = true;  
            }
            else
            {
                btnGuardar.Enabled = false;  }
        }

        private void Limpiar()
        {
            mtxtFecha.Clear();
            cmbDoctor.SelectedIndex = -1;
            cmbHora.SelectedIndex = -1;
            cmbConsultorio.SelectedIndex = -1;
            rtxtComentarios.Clear();
            rtxtMotivo.Clear();
            cmbConsultorio.Enabled = false;
            cmbDoctor.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            cmbConsultorio.Enabled = true;
            cmbDoctor.Enabled = true;

            string fecha = mtxtFecha.Text;
            string hora = cmbHora.Text;

            if (hora == "08:00 - 09:00")
            {
                cmbDoctor.Items.Clear();
                cmbDoctor.Items.Add("Gabriel");
                cmbDoctor.Items.Add("Silvio");
            }
            if (hora == "10:00 - 11:00")
            {
                cmbDoctor.Items.Clear();
                cmbDoctor.Items.Add("Alex");
                cmbDoctor.Items.Add("Slles");
            }
            if (hora == "01:00 - 02:00")
            {
                cmbDoctor.Items.Clear();
                cmbDoctor.Items.Add("Juan");
                cmbDoctor.Items.Add("Anthony");
            }
            if (hora == "03:00 - 04:00")
            {
                cmbDoctor.Items.Clear();
                cmbDoctor.Items.Add("Jenora");
                cmbDoctor.Items.Add("Regina");
            }
        }

        private void rtxtMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Ingrese solo letras o espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void rtxtComentarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Ingrese solo letras o espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void mtxtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void mtxtFecha_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Por favor, ingrese una fecha válida en el formato correcto.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtFecha.Focus();
            }
            else
            {
                DateTime fechaIngresada = (DateTime)e.ReturnValue;

                
                if (fechaIngresada < DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha no puede ser anterior al día actual.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtFecha.Focus();
                }
            }

            Validar(); 
        }

        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void cmbConsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void rtxtMotivo_TextChanged(object sender, EventArgs e)
        {
            Validar(); 
        }

        private void rtxtComentarios_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void mtxtFecha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Validar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtFecha.Text) ||
                cmbHora.SelectedItem == null ||
                cmbDoctor.SelectedItem == null ||
                cmbConsultorio.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cita nuevaCita = new Cita(
                    fecha: DateTime.ParseExact(mtxtFecha.Text, "dd/MM/yyyy", null),
                    hora: cmbHora.SelectedItem.ToString(),
                    doctor: cmbDoctor.SelectedItem.ToString(),
                    consultorio: cmbConsultorio.SelectedItem.ToString(),
                    motivo: rtxtMotivo.Text,
                    comentarios: rtxtComentarios.Text
                );

                ListaC.Citas.Add(nuevaCita);

                dgvCitas.Rows.Add(
                    nuevaCita.Fecha.ToString("dd/MM/yyyy"),
                    nuevaCita.Hora,
                    nuevaCita.Doctor,
                    nuevaCita.Consultorio,
                    nuevaCita.Motivo,
                    nuevaCita.Comentarios
                );

                GuardarCitasEnArchivo();

                MessageBox.Show("Cita guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            catch (FormatException)
            {
                MessageBox.Show("La fecha ingresada no tiene un formato válido. Use dd/MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ConfigurarDataGridView()
        {
            dgvCitas.Columns.Clear();
            dgvCitas.Columns.Add("Fecha", "Fecha");
            dgvCitas.Columns.Add("Hora", "Hora");
            dgvCitas.Columns.Add("Doctor", "Doctor");
            dgvCitas.Columns.Add("Consultorio", "Consultorio");
            dgvCitas.Columns.Add("Motivo", "Motivo");
            dgvCitas.Columns.Add("Comentarios", "Comentarios");
        }

        public void ActualizarDataGridView()
        {
            dgvCitas.Rows.Clear();

            foreach (var cita in ListaC.Citas)
            {
                dgvCitas.Rows.Add(
                    cita.Fecha.ToString("dd/MM/yyyy"),
                    cita.Hora,
                    cita.Doctor,
                    cita.Consultorio,
                    cita.Motivo,
                    cita.Comentarios
                );
            }
        }




        private void CargarCitasDesdeArchivo()
        {
            try
            {
                if (File.Exists("citas.dat"))
                {
                    using (FileStream fs = new FileStream("citas.dat", FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        ListaC.Citas = (List<Cita>)formatter.Deserialize(fs);
                    }

                    foreach (var cita in ListaC.Citas)
                    {
                        dgvCitas.Rows.Add(
                            cita.Fecha.ToString("dd/MM/yyyy"),
                            cita.Hora,
                            cita.Doctor,
                            cita.Consultorio,
                            cita.Motivo,
                            cita.Comentarios
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las citas. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                int selectedIndex = dgvCitas.SelectedRows[0].Index;

                
                Cita citaActualizada = ListaC.Citas[selectedIndex];
                citaActualizada.Fecha = DateTime.ParseExact(mtxtFecha.Text, "dd/MM/yyyy", null); 
                citaActualizada.Hora = cmbHora.SelectedItem.ToString();
                if (cmbDoctor.SelectedItem != null)
                {
                    citaActualizada.Doctor = cmbDoctor.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un doctor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }            
                citaActualizada.Consultorio = cmbConsultorio.SelectedItem.ToString();           
                citaActualizada.Motivo = rtxtMotivo.Text;                                       
                citaActualizada.Comentarios = rtxtComentarios.Text;                             

               
                DataGridViewRow row = dgvCitas.Rows[selectedIndex];
                row.Cells["Fecha"].Value = citaActualizada.Fecha.ToString("dd/MM/yyyy");
                row.Cells["Hora"].Value = citaActualizada.Hora;
                row.Cells["Doctor"].Value = citaActualizada.Doctor;
                row.Cells["Consultorio"].Value = citaActualizada.Consultorio;
                row.Cells["Motivo"].Value = citaActualizada.Motivo;
                row.Cells["Comentarios"].Value = citaActualizada.Comentarios;
                GuardarCitasEnArchivo();

              
                MessageBox.Show("Cita actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();

                
                btnGuardar.Enabled = true;  
                btnEditar.Enabled = false; 
            }
            catch (FormatException)
            {
                
                MessageBox.Show("La fecha ingresada no tiene un formato válido. Use dd/MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
              
                MessageBox.Show($"Ocurrió un error al actualizar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar la eliminación
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar esta cita?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                // Obtener el índice de la fila seleccionada
                int selectedIndex = dgvCitas.SelectedRows[0].Index;

                // Eliminar la cita de la lista
                citas.RemoveAt(selectedIndex);

                // Eliminar la fila del DataGridView
                dgvCitas.Rows.RemoveAt(selectedIndex);

                // Guardar los cambios en el archivo binario
                GuardarCitasEnArchivo();

                MessageBox.Show("Cita eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void GuardarCitasEnArchivo()
        {
            try
            {
                using (FileStream fs = new FileStream("citas.dat", FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, ListaC.Citas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar las citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgvCitas_SelectionChanged_1(object sender, EventArgs e)
        { 
            if (dgvCitas.SelectedRows.Count > 0)
            {
                // Obtiene la primera fila seleccionada
                DataGridViewRow row = dgvCitas.SelectedRows[0];

                // Asigna los valores de las celdas a los controles correspondientes
                mtxtFecha.Text = row.Cells["Fecha"].Value.ToString();         // Fecha
                cmbHora.SelectedItem = row.Cells["Hora"].Value.ToString();   // Hora
                cmbDoctor.SelectedItem = row.Cells["Doctor"].Value.ToString(); // Doctor
                cmbConsultorio.SelectedItem = row.Cells["Consultorio"].Value.ToString(); // Consultorio
                rtxtMotivo.Text = row.Cells["Motivo"].Value.ToString();      // Motivo
                rtxtComentarios.Text = row.Cells["Comentarios"].Value.ToString(); // Comentarios

                // Ajusta el estado de los botones según el contexto
                btnGuardar.Enabled = false; // Deshabilita el botón de guardar
                btnEditar.Enabled = true;  // Habilita el botón de editar
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            ReportDataSource dataSource = new ReportDataSource("dsCitas", ListaC.Citas);
            ReporteCitas reporte = new ReporteCitas();
            reporte.reportViewer1.LocalReport.DataSources.Clear();
            reporte.reportViewer1.LocalReport.DataSources.Add(dataSource);
            reporte.reportViewer1.LocalReport.ReportEmbeddedResource = "Hospital_Management.Reportes.rptCitas.rdlc";
            reporte.reportViewer1.RefreshReport();
            reporte.ShowDialog();
        }
    }
}






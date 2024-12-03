using Hospital_Management.Modelo_de_datos;
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
    public partial class EditarRegistroForm : Form
    {
        private Registro registroActual;

        public EditarRegistroForm(Registro registro)
        {
            InitializeComponent();
            registroActual = registro;
        }

        private void EditarRegistroForm_Load(object sender, EventArgs e)
        {
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial historial = new Historial();
            historial.Show();
        }

        // metodo para cargar los datos del registro en el formulario
        private void CargarDatosEnFormulario()
        {
            txtId.Text = registroActual.Id;
            txtNombresYApellidos.Text = registroActual.Nombre;
            txtDireccion.Text = registroActual.Direccion;
            txtNContacto.Text = registroActual.Ncontacto;
            txtEdad.Text = registroActual.Edad;
            cmbGenero.SelectedItem = registroActual.Genero;
            cmbTipoDeSangre.SelectedItem = registroActual.Tiposangre;
            txtEnfermedadAnteriorImportante.Text = registroActual.Enfermedadanterior;
            txtSintomas.Text = registroActual.Sintomas;
            txtDiagnostico.Text = registroActual.Diagnostico;
            txtMedicamentos.Text = registroActual.Medicamentos;
            cmbRequerimientoDeSala.SelectedItem = registroActual.RequerimientoDeSala;
            cmbTipoDeSala.SelectedItem = registroActual.TipoDeSala;
        }
        private Registro BuscarRegistroPorId(string id)
        {
            FileStream fs = null;
            BinaryReader reader = null;

            try
            {
                if (!File.Exists("registros.bin"))
                {
                    return null;
                }

                fs = new FileStream("registros.bin", FileMode.Open);
                reader = new BinaryReader(fs);

                while (fs.Position < fs.Length)
                {
                    string idExistente = reader.ReadString();
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
                    string requerimientoSala = reader.ReadString();
                    string tipoSala = reader.ReadString();

                    if (idExistente == id)
                    {
                        return new Registro(idExistente, nombre, direccion, contacto, edad, genero, tipoSangre,
                            enfermedadAnterior, sintomas, diagnostico, medicamentos, requerimientoSala, tipoSala);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (fs != null) fs.Close();
            }

            return null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingresa un ID para buscar.", "ID Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Registro registro = BuscarRegistroPorId(id);

            if (registro != null)
            {
                txtNombresYApellidos.Text = registro.Nombre;
                txtDireccion.Text = registro.Direccion;
                txtNContacto.Text = registro.Ncontacto;
                txtEdad.Text = registro.Edad;
                cmbGenero.SelectedItem = registro.Genero;
                cmbTipoDeSangre.SelectedItem = registro.Tiposangre;
                txtEnfermedadAnteriorImportante.Text = registro.Enfermedadanterior;
                txtSintomas.Text = registro.Sintomas;
                txtDiagnostico.Text = registro.Diagnostico;
                txtMedicamentos.Text = registro.Medicamentos;
                cmbRequerimientoDeSala.SelectedItem = registro.RequerimientoDeSala;
                cmbTipoDeSala.SelectedItem = registro.TipoDeSala;

                MessageBox.Show("Registro encontrado y datos cargados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No se encontró ningún registro con el ID '{id}'.", "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Buscar el registro en la lista
                var registro = ListaR.Registros.FirstOrDefault(r => r.Id == registroActual.Id);
                if (registro != null)
                {
                    // Actualizar los datos del registro
                    registro.Nombre = txtNombresYApellidos.Text;
                    registro.Direccion = txtDireccion.Text;
                    registro.Ncontacto = txtNContacto.Text;
                    registro.Edad = txtEdad.Text;
                    registro.Genero = cmbGenero.SelectedItem?.ToString();
                    registro.Tiposangre = cmbTipoDeSangre.SelectedItem?.ToString();
                    registro.Enfermedadanterior = txtEnfermedadAnteriorImportante.Text;
                    registro.Sintomas = txtSintomas.Text;
                    registro.Diagnostico = txtDiagnostico.Text;
                    registro.Medicamentos = txtMedicamentos.Text;
                    registro.RequerimientoDeSala = cmbRequerimientoDeSala.SelectedItem?.ToString();
                    registro.TipoDeSala = cmbTipoDeSala.SelectedItem?.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró el registro para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GuardarRegistrosEnArchivo();

                MessageBox.Show("Los cambios se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarRegistrosEnArchivo()
        {
            try
            {
                using (var fs = new FileStream("registros.bin", FileMode.Create))
                using (var writer = new BinaryWriter(fs))
                {
                    foreach (var reg in ListaR.Registros)
                    {
                        writer.Write(reg.Id);
                        writer.Write(reg.Nombre);
                        writer.Write(reg.Direccion);
                        writer.Write(reg.Ncontacto);
                        writer.Write(reg.Edad);
                        writer.Write(reg.Genero);
                        writer.Write(reg.Tiposangre);
                        writer.Write(reg.Enfermedadanterior);
                        writer.Write(reg.Sintomas);
                        writer.Write(reg.Diagnostico);
                        writer.Write(reg.Medicamentos);
                        writer.Write(reg.RequerimientoDeSala);
                        writer.Write(reg.TipoDeSala);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los registros en el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var registro = ListaR.Registros.FirstOrDefault(r => r.Id == registroActual.Id);

                if (registro != null)
                {
                    var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                        "Confirmación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        ListaR.Registros.Remove(registro);
                        GuardarRegistrosEnArchivo();
                        Limpiar();
                       

                        MessageBox.Show("El registro ha sido eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el registro para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten números", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtNombresYApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten letras y espacios.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e) { }
       
        private void txtNContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten números.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }

            // Limitar la longitud a 8 dígitos
            if (char.IsDigit(e.KeyChar) && txtNContacto.Text.Length >= 8)
            {
                MessageBox.Show("El número de teléfono ingresado debe tener 8 dígitos", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // Bloquear si excede la longitud
            }
        }

        private void txtNContacto_Leave(object sender, EventArgs e)
        {
            if (txtNContacto.Text.Length != 8)
            {
                MessageBox.Show("El número de contacto debe tener exactamente 8 dígitos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNContacto.Clear(); // Limpiar el campo si no es válido
                txtNContacto.Focus();
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten números.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }

            // verificar el valor después de insertar el carácter
            string textAfterKeyPress = txtEdad.Text.Insert(txtEdad.SelectionStart, e.KeyChar.ToString());

            if (int.TryParse(textAfterKeyPress, out int edad))
            {
                if (edad > 120 || edad <= 0)
                {
                    MessageBox.Show("La edad no es válida. Por favor, ingresa una edad válida.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEdad.Clear();
                    e.Handled = true; // Evitar que el carácter se procese
                }
            }
            else
            {
                txtEdad.Clear();
                e.Handled = true;
            }
        }

        private void txtSintomas_KeyPress(object sender, KeyPressEventArgs e) { }
      

        private void txtDiagnostico_KeyPress(object sender, KeyPressEventArgs e) { }
        

        private void txtMedicamentos_KeyPress(object sender, KeyPressEventArgs e) { }
        

        private void txtEnfermedadAnteriorImportante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten letras y espacios.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void cmbRequerimientoDeSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRequerimientoDeSala.SelectedItem?.ToString() == "No")
            {
                cmbTipoDeSala.SelectedItem = "Ninguna";
                cmbTipoDeSala.Enabled = false;
            }
            else
            {
                cmbTipoDeSala.Enabled = true;
                if (cmbRequerimientoDeSala.SelectedItem?.ToString() == "Sí" && cmbTipoDeSala.SelectedItem?.ToString() == "Ninguna")
                {
                    // Si la opción "Ninguna" está seleccionada, la deseleccionamos
                    cmbTipoDeSala.SelectedItem = null;
                }

            }
        }

        private void cmbTipoDeSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRequerimientoDeSala.SelectedIndex != -1)
            {
                cmbTipoDeSala.Enabled = true;
            }

            if (cmbTipoDeSala.SelectedItem != null && cmbRequerimientoDeSala.SelectedItem != null)
            {
                if (cmbTipoDeSala.SelectedItem.ToString() == "Ninguna" && cmbRequerimientoDeSala.SelectedItem.ToString() == "Sí")
                {
                    MessageBox.Show("La opción 'Ninguna' no se encuentra disponible cuando el paciente requiere sala", "Selección no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbTipoDeSala.SelectedIndex = -1;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtNombresYApellidos.Clear();
            txtDireccion.Clear();
            txtNContacto.Clear();
            txtEdad.Clear();
            txtEnfermedadAnteriorImportante.Clear();
            cmbGenero.SelectedIndex = -1;
            cmbTipoDeSangre.SelectedIndex = -1;
            txtSintomas.Clear();
            txtDiagnostico.Clear();
            txtMedicamentos.Clear();
            cmbRequerimientoDeSala.SelectedIndex = -1;
            cmbTipoDeSala.SelectedIndex = -1;
            txtNombresYApellidos.Focus();
        }

       
    }
}



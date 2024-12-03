using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management.Modelo_de_datos;
using Hospital_Management.Vistas;

namespace Hospital_Management.Vistas
{
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e) { }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controles controles = new Controles();
            controles.Show();
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e) { }

        private void txtNombresYApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten letras y espacios.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtNumeroContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten números.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }

            // Limitar la longitud a 8 dígitos
            if (char.IsDigit(e.KeyChar) && txtNumeroContacto.Text.Length >= 8)
            {
                MessageBox.Show("El número de teléfono ingresado debe tener 8 dígitos", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // Bloquear si excede la longitud
            }
        }


        private void txtNumeroContacto_Leave(object sender, EventArgs e)
        {
            if (txtNumeroContacto.Text.Length != 8)
            {
                MessageBox.Show("El número de contacto debe tener exactamente 8 dígitos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroContacto.Clear(); // Limpiar el campo si no es válido
                txtNumeroContacto.Focus();
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

        private void txtEnfermedadAnterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten letras y espacios.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtIdPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten números", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
            string textAfterKeyPress = txtIdPaciente.Text.Insert(txtIdPaciente.SelectionStart, e.KeyChar.ToString());

            if (int.TryParse(textAfterKeyPress, out int id))
            {
                if (id <= 0)
                {
                    MessageBox.Show("El ID no es válido. Por favor, ingresa un ID válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdPaciente.Clear();
                    e.Handled = true; // Evitar que el carácter se procese
                }
            }
            else
            {
                txtIdPaciente.Clear();
                e.Handled = true;
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            cmbTipoDeSala.Enabled = false;
        }

        private void Validar()
        {
            if (!string.IsNullOrEmpty(txtNombresYApellidos.Text) &&
                !string.IsNullOrEmpty(txtDireccion.Text) &&
                !string.IsNullOrEmpty(txtNumeroContacto.Text) &&
                !string.IsNullOrEmpty(txtEdad.Text) &&
                !string.IsNullOrEmpty(txtEnfermedadAnterior.Text) &&
                !string.IsNullOrEmpty(txtIdPaciente.Text) &&
                (cmbGenero.SelectedIndex != -1) &&
                (cmbTipoSangre.SelectedIndex != -1) &&
                !string.IsNullOrEmpty(txtSintomas.Text) &&
                !string.IsNullOrEmpty(txtDiagnostico.Text) &&
                !string.IsNullOrEmpty(txtMedicamentos.Text) &&
                (cmbRequerimientoDeSala.SelectedIndex != -1) &&
                (cmbTipoDeSala.SelectedIndex != -1))

            { btnGuardar.Enabled = true; }
        }

        private void txtNombresYApellidos_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtNumeroContacto_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void cmbTipoSangre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtEnfermedadAnterior_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtIdPaciente_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtSintomas_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtDiagnostico_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtMedicamentos_TextChanged(object sender, EventArgs e)
        {
            Validar();
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
                Validar();
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
            Validar();
        }

        private void Limpiar()
        {
            txtNombresYApellidos.Clear();
            txtDireccion.Clear();
            txtNumeroContacto.Clear();
            txtEdad.Clear();
            txtEnfermedadAnterior.Clear();
            txtIdPaciente.Clear();
            cmbGenero.SelectedIndex = -1;
            cmbTipoSangre.SelectedIndex = -1;
            txtSintomas.Clear();
            txtDiagnostico.Clear();
            txtMedicamentos.Clear();
            cmbRequerimientoDeSala.SelectedIndex = -1;
            cmbTipoDeSala.SelectedIndex = -1;
            txtNombresYApellidos.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Guardar();
            Limpiar();
        }

        private void Guardar()
        {
            FileStream fs = null;
            BinaryWriter writer = null;

            try
            {
                string id = txtIdPaciente.Text;

                if (EsIdRepetido(id))
                {
                    MessageBox.Show($"El ID '{id}' ya existe. Por favor, ingresa un ID único.", "ID Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = txtNombresYApellidos.Text;
                string direccion = txtDireccion.Text;
                string contacto = txtNumeroContacto.Text;
                string edad = txtEdad.Text;
                string genero = cmbGenero.SelectedItem.ToString();
                string tipoSangre = cmbTipoSangre.SelectedItem.ToString();
                string enfermedadAnterior = txtEnfermedadAnterior.Text;
                string sintomas = txtSintomas.Text;
                string diagnostico = txtDiagnostico.Text;
                string medicamentos = txtMedicamentos.Text;
                string requerimientoSala = cmbRequerimientoDeSala.SelectedItem.ToString();
                string tipoSala = cmbTipoDeSala.SelectedItem.ToString();

                Registro nuevoRegistro = new Registro(id, nombre, direccion, contacto, edad, genero, tipoSangre,
                    enfermedadAnterior, sintomas, diagnostico, medicamentos, requerimientoSala, tipoSala);

                // guardar el registro en el archivo
                fs = new FileStream("registros.bin", FileMode.Append);
                writer = new BinaryWriter(fs);

                writer.Write(nuevoRegistro.Id);
                writer.Write(nuevoRegistro.Nombre);
                writer.Write(nuevoRegistro.Direccion);
                writer.Write(nuevoRegistro.Ncontacto);
                writer.Write(nuevoRegistro.Edad);
                writer.Write(nuevoRegistro.Genero);
                writer.Write(nuevoRegistro.Tiposangre);
                writer.Write(nuevoRegistro.Enfermedadanterior);
                writer.Write(nuevoRegistro.Sintomas);
                writer.Write(nuevoRegistro.Diagnostico);
                writer.Write(nuevoRegistro.Medicamentos);
                writer.Write(nuevoRegistro.RequerimientoDeSala);
                writer.Write(nuevoRegistro.TipoDeSala);

                ListaR.Registros.Add(nuevoRegistro);

                MessageBox.Show("Registro guardado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (writer != null) writer.Close();
                if (fs != null) fs.Close();
            }
        }

        private bool EsIdRepetido(string id)
        {
            FileStream fs = null;
            BinaryReader reader = null;

            try
            {
                if (!File.Exists("registros.bin"))
                    return false;

                fs = new FileStream("registros.bin", FileMode.Open);
                reader = new BinaryReader(fs);

                while (fs.Position < fs.Length)
                {
                    string idExistente = reader.ReadString();

                    while (fs.Position < fs.Length)
                    {
                        reader.ReadString();
                    }

                    if (idExistente == id)
                        return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar IDs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (fs != null) fs.Close();
            }
            return false; 
        }

    }
}

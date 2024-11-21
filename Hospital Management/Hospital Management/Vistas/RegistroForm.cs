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
using Hospital_Management.Modelo_de_datos;

namespace Hospital_Management.Vistas
{
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private List<Registro> listaRegistros = new List<Registro>();

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
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten números.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
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
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
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
                (cmbTipoSangre.SelectedIndex != -1))

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
                string nombre = txtNombresYApellidos.Text;
                string direccion = txtDireccion.Text;
                string contacto = txtNumeroContacto.Text;
                string edad = txtEdad.Text;
                string genero = cmbGenero.SelectedItem.ToString();
                string tipoSangre = cmbTipoSangre.SelectedItem.ToString();
                string enfermedadAnterior = txtEnfermedadAnterior.Text;

                Registro registro = new Registro(id, nombre, direccion, contacto, edad, genero, tipoSangre, enfermedadAnterior);

                listaRegistros.Add(registro);

                fs = new FileStream("registros.bin", FileMode.Create);
                writer = new BinaryWriter(fs);

                writer.Write(listaRegistros.Count);

                foreach (var reg in listaRegistros)
                {
                    writer.Write(reg.Id);
                    writer.Write(reg.Nombre);
                    writer.Write(reg.Direccion);
                    writer.Write(reg.Ncontacto);
                    writer.Write(reg.Edad);
                    writer.Write(reg.Genero);
                    writer.Write(reg.Tiposangre);
                    writer.Write(reg.Enfermedadanterior);
                }

                MessageBox.Show("Registro agregado correctamente y guardado en el archivo!", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (writer != null) writer.Close();
                if (fs != null) fs.Close();
            }
        }

    }
}

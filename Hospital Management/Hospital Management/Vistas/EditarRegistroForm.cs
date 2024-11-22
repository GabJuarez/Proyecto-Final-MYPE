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
            Control control = new Control();
            control.Show();
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
            FileStream fs = null;
            BinaryWriter writer = null;
            List<Registro> registros = new List<Registro>();

            try
            {
                // Lee todos los registros existentes
                if (File.Exists("registros.bin"))
                {
                    using (fs = new FileStream("registros.bin", FileMode.Open))
                    using (BinaryReader reader = new BinaryReader(fs))
                    {
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

                            registros.Add(new Registro(
                                idExistente, nombre, direccion, contacto, edad, genero,
                                tipoSangre, enfermedadAnterior, sintomas, diagnostico,
                                medicamentos, requerimientoSala, tipoSala
                            ));
                        }
                    }
                }

                // Encuentra y actualiza el registro existente
                foreach (var reg in registros)
                {
                    if (reg.Id == registroActual.Id)
                    {
                        reg.Nombre = txtNombresYApellidos.Text;
                        reg.Direccion = txtDireccion.Text;
                        reg.Ncontacto = txtNContacto.Text;
                        reg.Edad = txtEdad.Text;
                        reg.Genero = cmbGenero.SelectedItem.ToString();
                        reg.Tiposangre = cmbTipoDeSangre.SelectedItem.ToString();
                        reg.Enfermedadanterior = txtEnfermedadAnteriorImportante.Text;
                        reg.Sintomas = txtSintomas.Text;
                        reg.Diagnostico = txtDiagnostico.Text;
                        reg.Medicamentos = txtMedicamentos.Text;
                        reg.RequerimientoDeSala = cmbRequerimientoDeSala.SelectedItem.ToString();
                        reg.TipoDeSala = cmbTipoDeSala.SelectedItem.ToString();
                        break;
                    }
                }

                // Escribe todos los registros de vuelta al archivo
                using (fs = new FileStream("registros.bin", FileMode.Create))
                using (writer = new BinaryWriter(fs))
                {
                    foreach (var reg in registros)
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

                MessageBox.Show("Los cambios se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}



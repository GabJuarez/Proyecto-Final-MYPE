using Hospital_Management.Modelo_de_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management.Vistas
{
    public partial class DiagnosticoForm : Form
    {
        
        public DiagnosticoForm()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controles controles = new Controles();
            controles.Show();

        }

        private void Diagnostico_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
        }

        private void txtPid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten números", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtSintomas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten letras y espacios.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtDiagnostico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten letras y espacios.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtMedicamentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
            e.KeyChar != '-' && e.KeyChar != '.' && e.KeyChar != '(' && e.KeyChar != ')')
            {
                MessageBox.Show("Se permiten letras, números, guiones, puntos y paréntesis.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
        private void Validar()
        {
            if (!string.IsNullOrEmpty(txtPid.Text) &&
                !string.IsNullOrEmpty(txtSintomas.Text) &&
                !string.IsNullOrEmpty(txtDiagnostico.Text) &&
                !string.IsNullOrEmpty(txtMedicamentos.Text) &&
                (cmbRequerimientoDeSala.SelectedIndex != -1) &&
                (cmbTipoDeSala.SelectedIndex != -1))

            { btnGuardar.Enabled = true; }
        }

        private void txtPid_TextChanged(object sender, EventArgs e)
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
            Validar();
        }

        private void cmbTipoDeSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void Limpiar()
        {
            txtPid.Clear();
            txtSintomas.Clear();
            txtDiagnostico.Clear();
            txtMedicamentos.Clear();
            cmbRequerimientoDeSala.SelectedIndex = -1;
            cmbTipoDeSala.SelectedIndex = -1;
            txtPid.Focus();

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {      
        }



    }
}

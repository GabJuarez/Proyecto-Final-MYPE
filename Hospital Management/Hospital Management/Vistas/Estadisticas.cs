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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            
            List<Registro> registros = CargarRegistros();

            
            var conteoTiposSangre = registros.GroupBy(r => r.Tiposangre)
                                              .Select(group => new { TipoSangre = group.Key, Conteo = group.Count() })
                                              .ToList();


            chrtTiposDeSangre.Series["Series1"].Points.Clear();
            foreach (var item in conteoTiposSangre)
            {
                chrtTiposDeSangre.Series["Series1"].Points.AddXY(item.TipoSangre, item.Conteo);
            }

            
            var conteoGeneros = registros.GroupBy(r => r.Genero)
                                         .Select(group => new { Genero = group.Key, Conteo = group.Count() })
                                         .ToList();


            chrtPacientesPorGenero.Series["Series1"].Points.Clear();
            foreach (var item in conteoGeneros)
            {
                chrtPacientesPorGenero.Series["Series1"].Points.AddXY(item.Genero, item.Conteo);
            }
        }

        private List<Registro> CargarRegistros()
        {
            List<Registro> registros = new List<Registro>();
            FileStream fs = null;
            BinaryReader reader = null;

            try
            {
                if (!File.Exists("registros.bin")) return registros;

                fs = new FileStream("registros.bin", FileMode.Open);
                reader = new BinaryReader(fs);

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
                    string requerimientoSala = reader.ReadString();
                    string tipoSala = reader.ReadString();

                    registros.Add(new Registro(id, nombre, direccion, contacto, edad, genero, tipoSangre,
                                               enfermedadAnterior, sintomas, diagnostico, medicamentos,
                                               requerimientoSala, tipoSala));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los registros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader?.Close();
                fs?.Close();
            }

            return registros;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controles controles = new Controles();
            controles.Show();

        }
    }
}

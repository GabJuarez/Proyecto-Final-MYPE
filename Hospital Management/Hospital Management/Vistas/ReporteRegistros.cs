using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management.Vistas
{
    public partial class ReporteRegistros : Form
    {
        public ReporteRegistros()
        {
            InitializeComponent();
        }

        private void ReporteRegistros_Load(object sender, EventArgs e)
        {

            this.ReportViewer2.RefreshReport();
        }
    }
}

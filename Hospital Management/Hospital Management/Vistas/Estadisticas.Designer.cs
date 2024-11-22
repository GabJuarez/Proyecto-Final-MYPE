namespace Hospital_Management.Vistas
{
    partial class Estadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chrtTiposDeSangre = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtPacientesPorGenero = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtPacientesQueNecesitanSala = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrtTiposDeSangre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPacientesPorGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPacientesQueNecesitanSala)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estadísticas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipos de Sangre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(787, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pacientes que Necesitan Sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distribución de Pacientes por Género";
            // 
            // chrtTiposDeSangre
            // 
            chartArea4.Name = "ChartArea1";
            this.chrtTiposDeSangre.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrtTiposDeSangre.Legends.Add(legend4);
            this.chrtTiposDeSangre.Location = new System.Drawing.Point(373, 460);
            this.chrtTiposDeSangre.Name = "chrtTiposDeSangre";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chrtTiposDeSangre.Series.Add(series4);
            this.chrtTiposDeSangre.Size = new System.Drawing.Size(501, 254);
            this.chrtTiposDeSangre.TabIndex = 4;
            this.chrtTiposDeSangre.Text = "chart1";
            // 
            // chrtPacientesPorGenero
            // 
            chartArea5.Name = "ChartArea1";
            this.chrtPacientesPorGenero.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chrtPacientesPorGenero.Legends.Add(legend5);
            this.chrtPacientesPorGenero.Location = new System.Drawing.Point(24, 124);
            this.chrtPacientesPorGenero.Name = "chrtPacientesPorGenero";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chrtPacientesPorGenero.Series.Add(series5);
            this.chrtPacientesPorGenero.Size = new System.Drawing.Size(501, 254);
            this.chrtPacientesPorGenero.TabIndex = 5;
            this.chrtPacientesPorGenero.Text = "chart2";
            // 
            // chrtPacientesQueNecesitanSala
            // 
            chartArea6.Name = "ChartArea1";
            this.chrtPacientesQueNecesitanSala.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chrtPacientesQueNecesitanSala.Legends.Add(legend6);
            this.chrtPacientesQueNecesitanSala.Location = new System.Drawing.Point(686, 124);
            this.chrtPacientesQueNecesitanSala.Name = "chrtPacientesQueNecesitanSala";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chrtPacientesQueNecesitanSala.Series.Add(series6);
            this.chrtPacientesQueNecesitanSala.Size = new System.Drawing.Size(501, 254);
            this.chrtPacientesQueNecesitanSala.TabIndex = 6;
            this.chrtPacientesQueNecesitanSala.Text = "chart3";
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1237, 737);
            this.Controls.Add(this.chrtPacientesQueNecesitanSala);
            this.Controls.Add(this.chrtPacientesPorGenero);
            this.Controls.Add(this.chrtTiposDeSangre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtTiposDeSangre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPacientesPorGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPacientesQueNecesitanSala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtTiposDeSangre;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtPacientesPorGenero;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtPacientesQueNecesitanSala;
    }
}
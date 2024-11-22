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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chrtTiposDeSangre = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtPacientesPorGenero = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtPacientesQueNecesitanSala = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnVolver = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(183, 37);
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
            chartArea1.Name = "ChartArea1";
            this.chrtTiposDeSangre.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtTiposDeSangre.Legends.Add(legend1);
            this.chrtTiposDeSangre.Location = new System.Drawing.Point(373, 460);
            this.chrtTiposDeSangre.Name = "chrtTiposDeSangre";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtTiposDeSangre.Series.Add(series1);
            this.chrtTiposDeSangre.Size = new System.Drawing.Size(501, 254);
            this.chrtTiposDeSangre.TabIndex = 4;
            this.chrtTiposDeSangre.Text = "chart1";
            // 
            // chrtPacientesPorGenero
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtPacientesPorGenero.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtPacientesPorGenero.Legends.Add(legend2);
            this.chrtPacientesPorGenero.Location = new System.Drawing.Point(24, 124);
            this.chrtPacientesPorGenero.Name = "chrtPacientesPorGenero";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrtPacientesPorGenero.Series.Add(series2);
            this.chrtPacientesPorGenero.Size = new System.Drawing.Size(501, 254);
            this.chrtPacientesPorGenero.TabIndex = 5;
            this.chrtPacientesPorGenero.Text = "chart2";
            // 
            // chrtPacientesQueNecesitanSala
            // 
            chartArea3.Name = "ChartArea1";
            this.chrtPacientesQueNecesitanSala.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrtPacientesQueNecesitanSala.Legends.Add(legend3);
            this.chrtPacientesQueNecesitanSala.Location = new System.Drawing.Point(686, 124);
            this.chrtPacientesQueNecesitanSala.Name = "chrtPacientesQueNecesitanSala";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chrtPacientesQueNecesitanSala.Series.Add(series3);
            this.chrtPacientesQueNecesitanSala.Size = new System.Drawing.Size(501, 254);
            this.chrtPacientesQueNecesitanSala.TabIndex = 6;
            this.chrtPacientesQueNecesitanSala.Text = "chart3";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.IndianRed;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(1083, 676);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 38);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1237, 737);
            this.Controls.Add(this.btnVolver);
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
        private System.Windows.Forms.Button btnVolver;
    }
}
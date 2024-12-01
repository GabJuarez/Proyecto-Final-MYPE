namespace Hospital_Management.Vistas
{
    partial class ReporteRegistros
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
            this.ReportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportViewer2
            // 
            this.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.ReportViewer2.Name = "ReportViewer2";
            this.ReportViewer2.ServerReport.BearerToken = null;
            this.ReportViewer2.Size = new System.Drawing.Size(1676, 890);
            this.ReportViewer2.TabIndex = 0;
            // 
            // ReporteRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1676, 890);
            this.Controls.Add(this.ReportViewer2);
            this.Name = "ReporteRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteRegistros";
            this.Load += new System.EventHandler(this.ReporteRegistros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer ReportViewer2;
    }
}
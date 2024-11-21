namespace Hospital_Management.Vistas
{
    partial class DiagnosticoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtMedicamentos = new System.Windows.Forms.TextBox();
            this.cmbRequerimientoDeSala = new System.Windows.Forms.ComboBox();
            this.cmbTipoDeSala = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Más Información Acerca del Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "PID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Síntomas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diagnóstico: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medicamentos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Requerimiento de Sala:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Sala:";
            // 
            // txtPid
            // 
            this.txtPid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPid.Location = new System.Drawing.Point(513, 142);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(100, 22);
            this.txtPid.TabIndex = 7;
            this.txtPid.TextChanged += new System.EventHandler(this.txtPid_TextChanged);
            this.txtPid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPid_KeyPress);
            // 
            // txtSintomas
            // 
            this.txtSintomas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSintomas.Location = new System.Drawing.Point(266, 355);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(210, 22);
            this.txtSintomas.TabIndex = 8;
            this.txtSintomas.TextChanged += new System.EventHandler(this.txtSintomas_TextChanged);
            this.txtSintomas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSintomas_KeyPress);
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagnostico.Location = new System.Drawing.Point(266, 402);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(210, 22);
            this.txtDiagnostico.TabIndex = 9;
            this.txtDiagnostico.TextChanged += new System.EventHandler(this.txtDiagnostico_TextChanged);
            this.txtDiagnostico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiagnostico_KeyPress);
            // 
            // txtMedicamentos
            // 
            this.txtMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedicamentos.Location = new System.Drawing.Point(266, 449);
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.Size = new System.Drawing.Size(210, 22);
            this.txtMedicamentos.TabIndex = 10;
            this.txtMedicamentos.TextChanged += new System.EventHandler(this.txtMedicamentos_TextChanged);
            this.txtMedicamentos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedicamentos_KeyPress);
            // 
            // cmbRequerimientoDeSala
            // 
            this.cmbRequerimientoDeSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequerimientoDeSala.FormattingEnabled = true;
            this.cmbRequerimientoDeSala.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cmbRequerimientoDeSala.Location = new System.Drawing.Point(739, 353);
            this.cmbRequerimientoDeSala.Name = "cmbRequerimientoDeSala";
            this.cmbRequerimientoDeSala.Size = new System.Drawing.Size(168, 24);
            this.cmbRequerimientoDeSala.TabIndex = 11;
            this.cmbRequerimientoDeSala.SelectedIndexChanged += new System.EventHandler(this.cmbRequerimientoDeSala_SelectedIndexChanged);
            // 
            // cmbTipoDeSala
            // 
            this.cmbTipoDeSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeSala.FormattingEnabled = true;
            this.cmbTipoDeSala.Items.AddRange(new object[] {
            "General",
            "Doble",
            "Cuidados Especiales"});
            this.cmbTipoDeSala.Location = new System.Drawing.Point(739, 400);
            this.cmbTipoDeSala.Name = "cmbTipoDeSala";
            this.cmbTipoDeSala.Size = new System.Drawing.Size(168, 24);
            this.cmbTipoDeSala.TabIndex = 12;
            this.cmbTipoDeSala.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDeSala_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(882, 62);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(595, 449);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(704, 449);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.IndianRed;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(795, 449);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // DiagnosticoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1081, 552);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbTipoDeSala);
            this.Controls.Add(this.cmbRequerimientoDeSala);
            this.Controls.Add(this.txtMedicamentos);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtSintomas);
            this.Controls.Add(this.txtPid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DiagnosticoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnostico";
            this.Load += new System.EventHandler(this.Diagnostico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtMedicamentos;
        private System.Windows.Forms.ComboBox cmbRequerimientoDeSala;
        private System.Windows.Forms.ComboBox cmbTipoDeSala;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}
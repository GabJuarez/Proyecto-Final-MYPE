namespace Hospital_Management.Vistas
{
    partial class AgendarCita
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
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtFecha = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.rtxtMotivo = new System.Windows.Forms.RichTextBox();
            this.rtxtComentarios = new System.Windows.Forms.RichTextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionamiento de Citas";
            // 
            // cmbHora
            // 
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "08:00 - 09:00",
            "10:00 - 11:00",
            "01:00 - 02:00",
            "03:00 - 04:00"});
            this.cmbHora.Location = new System.Drawing.Point(378, 107);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(121, 24);
            this.cmbHora.TabIndex = 0;
            this.cmbHora.SelectedIndexChanged += new System.EventHandler(this.cmbHora_SelectedIndexChanged);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(378, 158);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(121, 24);
            this.cmbDoctor.TabIndex = 1;
            this.cmbDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbDoctor_SelectedIndexChanged);
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Items.AddRange(new object[] {
            "c-201",
            "b-202",
            "b-108",
            "f-483"});
            this.cmbConsultorio.Location = new System.Drawing.Point(378, 213);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(121, 24);
            this.cmbConsultorio.TabIndex = 2;
            this.cmbConsultorio.SelectedIndexChanged += new System.EventHandler(this.cmbConsultorio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese la hora de la cita:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seleccione Algun Consultorio Disponible:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(810, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Motivo de la Consulta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(810, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Comentarios:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Seleccione Algun Doctor Disponible:";
            // 
            // mtxtFecha
            // 
            this.mtxtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtFecha.Location = new System.Drawing.Point(714, 113);
            this.mtxtFecha.Mask = "00/00/0000";
            this.mtxtFecha.Name = "mtxtFecha";
            this.mtxtFecha.Size = new System.Drawing.Size(69, 22);
            this.mtxtFecha.TabIndex = 3;
            this.mtxtFecha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtFecha_MaskInputRejected);
            this.mtxtFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtFecha_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ingrese la Fecha:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(521, 279);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Location = new System.Drawing.Point(601, 279);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.IndianRed;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Location = new System.Drawing.Point(996, 627);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // rtxtMotivo
            // 
            this.rtxtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtMotivo.Location = new System.Drawing.Point(972, 107);
            this.rtxtMotivo.Name = "rtxtMotivo";
            this.rtxtMotivo.Size = new System.Drawing.Size(183, 68);
            this.rtxtMotivo.TabIndex = 5;
            this.rtxtMotivo.Text = "";
            this.rtxtMotivo.TextChanged += new System.EventHandler(this.rtxtMotivo_TextChanged);
            this.rtxtMotivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtMotivo_KeyPress);
            // 
            // rtxtComentarios
            // 
            this.rtxtComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtComentarios.Location = new System.Drawing.Point(972, 191);
            this.rtxtComentarios.Name = "rtxtComentarios";
            this.rtxtComentarios.Size = new System.Drawing.Size(183, 72);
            this.rtxtComentarios.TabIndex = 6;
            this.rtxtComentarios.Text = "";
            this.rtxtComentarios.TextChanged += new System.EventHandler(this.rtxtComentarios_TextChanged);
            this.rtxtComentarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtComentarios_KeyPress);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVer.Location = new System.Drawing.Point(601, 158);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(182, 79);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Ver Disponibilidad";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(157, 406);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCitas.RowTemplate.Height = 24;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(758, 254);
            this.dgvCitas.TabIndex = 19;
            this.dgvCitas.SelectionChanged += new System.EventHandler(this.dgvCitas_SelectionChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(468, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mis Citas";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(996, 465);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar Cita";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(996, 511);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar Cita";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.Violet;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarReporte.Location = new System.Drawing.Point(996, 557);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(130, 23);
            this.btnGenerarReporte.TabIndex = 11;
            this.btnGenerarReporte.Text = "Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // AgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1219, 778);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.rtxtComentarios);
            this.Controls.Add(this.rtxtMotivo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtxtFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.label1);
            this.Name = "AgendarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendarCita";
            this.Load += new System.EventHandler(this.AgendarCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.RichTextBox rtxtMotivo;
        private System.Windows.Forms.RichTextBox rtxtComentarios;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}
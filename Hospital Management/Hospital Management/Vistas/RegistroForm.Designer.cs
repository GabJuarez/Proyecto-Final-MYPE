namespace Hospital_Management.Vistas
{
    partial class RegistroForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombresYApellidos = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNumeroContacto = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtEnfermedadAnterior = new System.Windows.Forms.TextBox();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbTipoSangre = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMedicamentos = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.cmbRequerimientoDeSala = new System.Windows.Forms.ComboBox();
            this.cmbTipoDeSala = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Registro de Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres y Apellidos:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de contacto: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Género:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Sangre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Id del Paciente: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Alguna Enfermedad Importante Sufrida Anteriormente:";
            // 
            // txtNombresYApellidos
            // 
            this.txtNombresYApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombresYApellidos.Location = new System.Drawing.Point(219, 189);
            this.txtNombresYApellidos.Name = "txtNombresYApellidos";
            this.txtNombresYApellidos.Size = new System.Drawing.Size(377, 22);
            this.txtNombresYApellidos.TabIndex = 9;
            this.txtNombresYApellidos.TextChanged += new System.EventHandler(this.txtNombresYApellidos_TextChanged);
            this.txtNombresYApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombresYApellidos_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(219, 231);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(377, 22);
            this.txtDireccion.TabIndex = 10;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtNumeroContacto
            // 
            this.txtNumeroContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroContacto.Location = new System.Drawing.Point(219, 272);
            this.txtNumeroContacto.Name = "txtNumeroContacto";
            this.txtNumeroContacto.Size = new System.Drawing.Size(377, 22);
            this.txtNumeroContacto.TabIndex = 11;
            this.txtNumeroContacto.TextChanged += new System.EventHandler(this.txtNumeroContacto_TextChanged);
            this.txtNumeroContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroContacto_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Location = new System.Drawing.Point(219, 313);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(377, 22);
            this.txtEdad.TabIndex = 12;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtEnfermedadAnterior
            // 
            this.txtEnfermedadAnterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnfermedadAnterior.Location = new System.Drawing.Point(250, 474);
            this.txtEnfermedadAnterior.Name = "txtEnfermedadAnterior";
            this.txtEnfermedadAnterior.Size = new System.Drawing.Size(746, 22);
            this.txtEnfermedadAnterior.TabIndex = 15;
            this.txtEnfermedadAnterior.TextChanged += new System.EventHandler(this.txtEnfermedadAnterior_TextChanged);
            this.txtEnfermedadAnterior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnfermedadAnterior_KeyPress);
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPaciente.Location = new System.Drawing.Point(219, 145);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(377, 22);
            this.txtIdPaciente.TabIndex = 16;
            this.txtIdPaciente.TextChanged += new System.EventHandler(this.txtIdPaciente_TextChanged);
            this.txtIdPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPaciente_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(504, 543);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(602, 542);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.IndianRed;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(683, 543);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(219, 360);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(377, 24);
            this.cmbGenero.TabIndex = 20;
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.cmbGenero_SelectedIndexChanged);
            // 
            // cmbTipoSangre
            // 
            this.cmbTipoSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSangre.FormattingEnabled = true;
            this.cmbTipoSangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmbTipoSangre.Location = new System.Drawing.Point(794, 143);
            this.cmbTipoSangre.Name = "cmbTipoSangre";
            this.cmbTipoSangre.Size = new System.Drawing.Size(365, 24);
            this.cmbTipoSangre.TabIndex = 21;
            this.cmbTipoSangre.SelectedIndexChanged += new System.EventHandler(this.cmbTipoSangre_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Síntomas:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(640, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Diagnóstico:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(640, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Medicamentos:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(640, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Requerimiento de Sala:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(640, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Tipo de Sala:";
            // 
            // txtMedicamentos
            // 
            this.txtMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedicamentos.Location = new System.Drawing.Point(794, 272);
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.Size = new System.Drawing.Size(365, 22);
            this.txtMedicamentos.TabIndex = 27;
            this.txtMedicamentos.TextChanged += new System.EventHandler(this.txtMedicamentos_TextChanged);
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagnostico.Location = new System.Drawing.Point(794, 231);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(365, 22);
            this.txtDiagnostico.TabIndex = 28;
            this.txtDiagnostico.TextChanged += new System.EventHandler(this.txtDiagnostico_TextChanged);
            // 
            // txtSintomas
            // 
            this.txtSintomas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSintomas.Location = new System.Drawing.Point(794, 189);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(365, 22);
            this.txtSintomas.TabIndex = 29;
            this.txtSintomas.TextChanged += new System.EventHandler(this.txtSintomas_TextChanged);
            // 
            // cmbRequerimientoDeSala
            // 
            this.cmbRequerimientoDeSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequerimientoDeSala.FormattingEnabled = true;
            this.cmbRequerimientoDeSala.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cmbRequerimientoDeSala.Location = new System.Drawing.Point(794, 316);
            this.cmbRequerimientoDeSala.Name = "cmbRequerimientoDeSala";
            this.cmbRequerimientoDeSala.Size = new System.Drawing.Size(365, 24);
            this.cmbRequerimientoDeSala.TabIndex = 30;
            this.cmbRequerimientoDeSala.SelectedIndexChanged += new System.EventHandler(this.cmbRequerimientoDeSala_SelectedIndexChanged);
            // 
            // cmbTipoDeSala
            // 
            this.cmbTipoDeSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeSala.FormattingEnabled = true;
            this.cmbTipoDeSala.Items.AddRange(new object[] {
            "General",
            "Doble",
            "Cuidados Especiales",
            "Ninguna"});
            this.cmbTipoDeSala.Location = new System.Drawing.Point(794, 365);
            this.cmbTipoDeSala.Name = "cmbTipoDeSala";
            this.cmbTipoDeSala.Size = new System.Drawing.Size(365, 24);
            this.cmbTipoDeSala.TabIndex = 31;
            this.cmbTipoDeSala.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDeSala_SelectedIndexChanged);
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1241, 647);
            this.Controls.Add(this.cmbTipoDeSala);
            this.Controls.Add(this.cmbRequerimientoDeSala);
            this.Controls.Add(this.txtSintomas);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtMedicamentos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbTipoSangre);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.txtEnfermedadAnterior);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNumeroContacto);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombresYApellidos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombresYApellidos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNumeroContacto;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtEnfermedadAnterior;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbTipoSangre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMedicamentos;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.ComboBox cmbRequerimientoDeSala;
        private System.Windows.Forms.ComboBox cmbTipoDeSala;
    }
}
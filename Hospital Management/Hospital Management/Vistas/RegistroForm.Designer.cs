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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Registro de Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres y Apellidos:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de contacto: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Género:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Sangre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Id del Paciente: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Alguna Enfermedad Importante Sufrida Anteriormente:";
            // 
            // txtNombresYApellidos
            // 
            this.txtNombresYApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombresYApellidos.Location = new System.Drawing.Point(286, 185);
            this.txtNombresYApellidos.Name = "txtNombresYApellidos";
            this.txtNombresYApellidos.Size = new System.Drawing.Size(574, 22);
            this.txtNombresYApellidos.TabIndex = 9;
            this.txtNombresYApellidos.TextChanged += new System.EventHandler(this.txtNombresYApellidos_TextChanged);
            this.txtNombresYApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombresYApellidos_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(286, 227);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(574, 22);
            this.txtDireccion.TabIndex = 10;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtNumeroContacto
            // 
            this.txtNumeroContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroContacto.Location = new System.Drawing.Point(286, 268);
            this.txtNumeroContacto.Name = "txtNumeroContacto";
            this.txtNumeroContacto.Size = new System.Drawing.Size(574, 22);
            this.txtNumeroContacto.TabIndex = 11;
            this.txtNumeroContacto.TextChanged += new System.EventHandler(this.txtNumeroContacto_TextChanged);
            this.txtNumeroContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroContacto_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Location = new System.Drawing.Point(286, 309);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(574, 22);
            this.txtEdad.TabIndex = 12;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtEnfermedadAnterior
            // 
            this.txtEnfermedadAnterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnfermedadAnterior.Location = new System.Drawing.Point(154, 482);
            this.txtEnfermedadAnterior.Name = "txtEnfermedadAnterior";
            this.txtEnfermedadAnterior.Size = new System.Drawing.Size(746, 22);
            this.txtEnfermedadAnterior.TabIndex = 15;
            this.txtEnfermedadAnterior.TextChanged += new System.EventHandler(this.txtEnfermedadAnterior_TextChanged);
            this.txtEnfermedadAnterior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnfermedadAnterior_KeyPress);
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPaciente.Location = new System.Drawing.Point(286, 141);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(574, 22);
            this.txtIdPaciente.TabIndex = 16;
            this.txtIdPaciente.TextChanged += new System.EventHandler(this.txtIdPaciente_TextChanged);
            this.txtIdPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPaciente_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(408, 551);
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
            this.btnLimpiar.Location = new System.Drawing.Point(506, 550);
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
            this.btnVolver.Location = new System.Drawing.Point(587, 551);
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
            this.cmbGenero.Location = new System.Drawing.Point(286, 356);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(574, 24);
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
            this.cmbTipoSangre.Location = new System.Drawing.Point(286, 396);
            this.cmbTipoSangre.Name = "cmbTipoSangre";
            this.cmbTipoSangre.Size = new System.Drawing.Size(574, 24);
            this.cmbTipoSangre.TabIndex = 21;
            this.cmbTipoSangre.SelectedIndexChanged += new System.EventHandler(this.cmbTipoSangre_SelectedIndexChanged);
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 652);
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
    }
}
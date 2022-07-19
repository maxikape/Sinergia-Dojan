
namespace SinergiaApp
{
    partial class FrmNuevoAlumno
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAsistencias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lbPago = new System.Windows.Forms.ListBox();
            this.lbEstado = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumeroAlumno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pbxAlumno = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbFichaMedica = new System.Windows.Forms.ListBox();
            this.lbCarnet = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(513, 391);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(60, 45);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(115, 79);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(115, 130);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 6;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            this.txtDni.Validated += new System.EventHandler(this.txtDni_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DNI";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(115, 182);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha De ingreso";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(115, 223);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estado";
            // 
            // txtAsistencias
            // 
            this.txtAsistencias.Location = new System.Drawing.Point(115, 391);
            this.txtAsistencias.Name = "txtAsistencias";
            this.txtAsistencias.Size = new System.Drawing.Size(100, 20);
            this.txtAsistencias.TabIndex = 16;
            this.txtAsistencias.TextChanged += new System.EventHandler(this.txtAsistencias_TextChanged);
            this.txtAsistencias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsistencias_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Asistencias";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(115, 265);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(194, 20);
            this.dtpFecha.TabIndex = 17;
            // 
            // lbPago
            // 
            this.lbPago.FormattingEnabled = true;
            this.lbPago.Items.AddRange(new object[] {
            "Impaga",
            "Paga"});
            this.lbPago.Location = new System.Drawing.Point(115, 345);
            this.lbPago.Name = "lbPago";
            this.lbPago.Size = new System.Drawing.Size(55, 30);
            this.lbPago.TabIndex = 19;
            // 
            // lbEstado
            // 
            this.lbEstado.FormattingEnabled = true;
            this.lbEstado.Items.AddRange(new object[] {
            "Inactivo",
            "Activo"});
            this.lbEstado.Location = new System.Drawing.Point(115, 309);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(55, 30);
            this.lbEstado.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Cuota";
            // 
            // txtNumeroAlumno
            // 
            this.txtNumeroAlumno.Location = new System.Drawing.Point(115, 422);
            this.txtNumeroAlumno.Name = "txtNumeroAlumno";
            this.txtNumeroAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroAlumno.TabIndex = 47;
            this.txtNumeroAlumno.TextChanged += new System.EventHandler(this.txtNumeroAlumno_TextChanged);
            this.txtNumeroAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroAlumno_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "N° de Alumno";
            // 
            // pbxAlumno
            // 
            this.pbxAlumno.Location = new System.Drawing.Point(348, 27);
            this.pbxAlumno.Name = "pbxAlumno";
            this.pbxAlumno.Size = new System.Drawing.Size(201, 186);
            this.pbxAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAlumno.TabIndex = 48;
            this.pbxAlumno.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(348, 230);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(201, 23);
            this.btnFoto.TabIndex = 49;
            this.btnFoto.TabStop = false;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Carnet";
            // 
            // lbFichaMedica
            // 
            this.lbFichaMedica.FormattingEnabled = true;
            this.lbFichaMedica.Items.AddRange(new object[] {
            "NO",
            "SI"});
            this.lbFichaMedica.Location = new System.Drawing.Point(298, 309);
            this.lbFichaMedica.Name = "lbFichaMedica";
            this.lbFichaMedica.Size = new System.Drawing.Size(55, 30);
            this.lbFichaMedica.TabIndex = 52;
            // 
            // lbCarnet
            // 
            this.lbCarnet.FormattingEnabled = true;
            this.lbCarnet.Items.AddRange(new object[] {
            "NO",
            "SI"});
            this.lbCarnet.Location = new System.Drawing.Point(298, 345);
            this.lbCarnet.Name = "lbCarnet";
            this.lbCarnet.Size = new System.Drawing.Size(55, 30);
            this.lbCarnet.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Ficha Medica";
            // 
            // FrmNuevoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(625, 451);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbFichaMedica);
            this.Controls.Add(this.lbCarnet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pbxAlumno);
            this.Controls.Add(this.txtNumeroAlumno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.lbPago);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtAsistencias);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmNuevoAlumno";
            this.Text = "FrmNuevoAlumno";
            this.Load += new System.EventHandler(this.FrmNuevoAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtDni;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtAsistencias;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.ListBox lbPago;
        public System.Windows.Forms.ListBox lbEstado;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtNumeroAlumno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbxAlumno;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ListBox lbFichaMedica;
        public System.Windows.Forms.ListBox lbCarnet;
        private System.Windows.Forms.Label label12;
    }
}
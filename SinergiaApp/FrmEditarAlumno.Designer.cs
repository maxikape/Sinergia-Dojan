
namespace SinergiaApp
{
    partial class FrmEditarAlumno
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
            this.txtAsistencias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.ListBox();
            this.lbPago = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumeroAlumno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbFichaMedica = new System.Windows.Forms.ListBox();
            this.lbCarnet = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAsistencias
            // 
            this.txtAsistencias.Location = new System.Drawing.Point(110, 376);
            this.txtAsistencias.Name = "txtAsistencias";
            this.txtAsistencias.Size = new System.Drawing.Size(70, 20);
            this.txtAsistencias.TabIndex = 35;
            this.txtAsistencias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsistencias_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Asistencias";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(110, 245);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 31;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(110, 204);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 28;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Direccion";
            // 
            // txtDni
            // 
            this.txtDni.CausesValidation = false;
            this.txtDni.Location = new System.Drawing.Point(110, 153);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 26;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(110, 102);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 24;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Apellido";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(462, 376);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 49);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(110, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 38;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Cuota";
            // 
            // lbEstado
            // 
            this.lbEstado.FormattingEnabled = true;
            this.lbEstado.Items.AddRange(new object[] {
            "Inactivo",
            "Activo"});
            this.lbEstado.Location = new System.Drawing.Point(110, 301);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(55, 30);
            this.lbEstado.TabIndex = 42;
            // 
            // lbPago
            // 
            this.lbPago.FormattingEnabled = true;
            this.lbPago.Items.AddRange(new object[] {
            "Impaga",
            "Paga"});
            this.lbPago.Location = new System.Drawing.Point(110, 337);
            this.lbPago.Name = "lbPago";
            this.lbPago.Size = new System.Drawing.Size(55, 30);
            this.lbPago.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Estado";
            // 
            // txtNumeroAlumno
            // 
            this.txtNumeroAlumno.Location = new System.Drawing.Point(110, 410);
            this.txtNumeroAlumno.Name = "txtNumeroAlumno";
            this.txtNumeroAlumno.Size = new System.Drawing.Size(70, 20);
            this.txtNumeroAlumno.TabIndex = 45;
            this.txtNumeroAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroAlumno_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "N° de Alumno";
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(298, 231);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(201, 23);
            this.btnFoto.TabIndex = 51;
            this.btnFoto.TabStop = false;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // pbxFoto
            // 
            this.pbxFoto.Location = new System.Drawing.Point(298, 28);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(201, 186);
            this.pbxFoto.TabIndex = 50;
            this.pbxFoto.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Carnet";
            // 
            // lbFichaMedica
            // 
            this.lbFichaMedica.FormattingEnabled = true;
            this.lbFichaMedica.Items.AddRange(new object[] {
            "NO",
            "SI"});
            this.lbFichaMedica.Location = new System.Drawing.Point(280, 301);
            this.lbFichaMedica.Name = "lbFichaMedica";
            this.lbFichaMedica.Size = new System.Drawing.Size(55, 30);
            this.lbFichaMedica.TabIndex = 56;
            // 
            // lbCarnet
            // 
            this.lbCarnet.FormattingEnabled = true;
            this.lbCarnet.Items.AddRange(new object[] {
            "NO",
            "SI"});
            this.lbCarnet.Location = new System.Drawing.Point(280, 337);
            this.lbCarnet.Name = "lbCarnet";
            this.lbCarnet.Size = new System.Drawing.Size(55, 30);
            this.lbCarnet.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(185, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Ficha Medica";
            // 
            // FrmEditarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbFichaMedica);
            this.Controls.Add(this.lbCarnet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.txtNumeroAlumno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.lbPago);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtAsistencias);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditarAlumno";
            this.Text = "FrmEditarAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtAsistencias;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtDni;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ListBox lbEstado;
        public System.Windows.Forms.ListBox lbPago;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtNumeroAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFoto;
        public System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ListBox lbFichaMedica;
        public System.Windows.Forms.ListBox lbCarnet;
        private System.Windows.Forms.Label label12;
    }
}
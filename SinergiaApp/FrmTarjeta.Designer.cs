
namespace SinergiaApp
{
    partial class FrmTarjeta
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
            this.pbFotoAlumno = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.Label();
            this.txtNumeroAlumno = new System.Windows.Forms.Label();
            this.txtAsistencias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFotoAlumno
            // 
            this.pbFotoAlumno.Location = new System.Drawing.Point(408, 12);
            this.pbFotoAlumno.Name = "pbFotoAlumno";
            this.pbFotoAlumno.Size = new System.Drawing.Size(122, 119);
            this.pbFotoAlumno.TabIndex = 0;
            this.pbFotoAlumno.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(125, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(44, 13);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.AutoSize = true;
            this.txtApellido.Location = new System.Drawing.Point(125, 89);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(44, 13);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Text = "Apellido";
            // 
            // txtNumeroAlumno
            // 
            this.txtNumeroAlumno.AutoSize = true;
            this.txtNumeroAlumno.Location = new System.Drawing.Point(125, 152);
            this.txtNumeroAlumno.Name = "txtNumeroAlumno";
            this.txtNumeroAlumno.Size = new System.Drawing.Size(57, 13);
            this.txtNumeroAlumno.TabIndex = 3;
            this.txtNumeroAlumno.Text = "N° Alumno";
            // 
            // txtAsistencias
            // 
            this.txtAsistencias.AutoSize = true;
            this.txtAsistencias.Location = new System.Drawing.Point(125, 196);
            this.txtAsistencias.Name = "txtAsistencias";
            this.txtAsistencias.Size = new System.Drawing.Size(60, 13);
            this.txtAsistencias.TabIndex = 4;
            this.txtAsistencias.Text = "Asistencias";
            // 
            // FrmTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 351);
            this.Controls.Add(this.txtAsistencias);
            this.Controls.Add(this.txtNumeroAlumno);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pbFotoAlumno);
            this.Name = "FrmTarjeta";
            this.Text = "FrmTarjeta";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFotoAlumno;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtApellido;
        private System.Windows.Forms.Label txtNumeroAlumno;
        private System.Windows.Forms.Label txtAsistencias;
    }
}
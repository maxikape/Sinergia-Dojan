using Grpc.Core;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SinergiaApp
{
    public partial class FrmNuevoAlumno : Form
    {
        public FrmNuevoAlumno()
        {
            InitializeComponent();
        }

        Validaciones validar = new Validaciones();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SinergiaDB oSinergiaDB = new SinergiaDB();


            if (pbxAlumno.Image != null)
            {

                string fname = txtDni.Text + ".jpg";
                string folder = "C:\\Fotos";
                string pathString = System.IO.Path.Combine(folder, fname);
                Image a = pbxAlumno.Image;
                a.Save(pathString);




                var pago = lbPago.SelectedIndex; ;
                var estado = lbEstado.SelectedIndex;
                var fichaMedica = lbFichaMedica.SelectedIndex;
                var carnet = lbCarnet.SelectedIndex;

                try
                {
                    oSinergiaDB.Add(txtApellido.Text, txtNombre.Text, txtDni.Text, txtDireccion.Text, txtTelefono.Text, Convert.ToString(dtpFecha.Value), estado, Convert.ToInt32(txtAsistencias.Text), pago, Convert.ToInt32(txtNumeroAlumno.Text),/* ms.GetBuffer()*/ fichaMedica, carnet, pathString);
                    this.Close();

                }

                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrio un error al guardar " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Elija una Imagen");
            }



        }

        private void FrmNuevoAlumno_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            lbCarnet.SelectedIndex = 0;
            lbEstado.SelectedIndex = 0;
            lbFichaMedica.SelectedIndex = 0;
            lbPago.SelectedIndex = 0;

        }

        private void ValidarCampos()
        {
            var vr = !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtDni.Text) &&
                !string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txtAsistencias.Text)
                && !string.IsNullOrEmpty(txtNumeroAlumno.Text);
            btnAgregar.Enabled = vr;

        }

        private void txtDni_Validated(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            //of es el objeto que va a recibir una imagen
            OpenFileDialog of = new OpenFileDialog();
            //dialog result es el resultado
            DialogResult dr = of.ShowDialog();

            //string fname = txtDni + "jpg";
            //string folder = "C\\Fotos";
            //string pathString = System.IO.Path.Combine(folder, fname);

            //if (dr == DialogResult.OK)
            //{
            //    //mustra la imagen en el pictoreBox
            //    pbxAlumno.Image = Image.FromFile(of.FileName);
            //}

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtAsistencias_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtNumeroAlumno_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtAsistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);

        }

        private void txtNumeroAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);

        }

        private void pbxAlumno_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            //dialog result es el resultado
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*) | *.jpg;*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }
    }
}

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;


namespace SinergiaApp
{
    public partial class FrmEditarAlumno : Form
    {
        //private int? Id;
        public FrmEditarAlumno(/*int? Id=null*/)
        {
            InitializeComponent();
            //this.Id = Id;
            //if (Id != null)
            //{
            //    cargar();
            //}
        }
        //Validaciones validar = new Validaciones();


        SinergiaDB oSinergiaDB = new SinergiaDB();

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            //string fname = txtDni.Text + ".jpg" ;
            //string folder = "C:\\Fotos";

            //string pathString = System.IO.Path.Combine(folder, fname);
           
            //Image a = pbxFoto.Image;
            ////pbxFoto.Image = null;
            ////File.Delete(pathString2);
            //a.Save(pathString);

            

            SinergiaDB oSinergiaDB = new SinergiaDB();
            var pago = lbPago.SelectedIndex; ;
            var estado = lbEstado.SelectedIndex;
            var fichaMedica = lbFichaMedica.SelectedIndex;
            var carnet = lbCarnet.SelectedIndex;
            
            

            oSinergiaDB.Edit(Convert.ToInt32(txtId.Text),txtApellido.Text, txtNombre.Text, txtDni.Text, txtDireccion.Text, txtTelefono.Text, Convert.ToInt32(txtNumeroAlumno.Text), estado, Convert.ToInt32(txtAsistencias.Text), pago,  fichaMedica, carnet/*, pathString*/);

            this.Close();


        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtAsistencias_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNumeroAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAsistencias frmnuevoa = new FrmAsistencias(Convert.ToInt32(txtId.Text));
            //frmnuevoa.ShowDialog();
        }

        private void FrmEditarAlumno_Load(object sender, EventArgs e)
        {

            pbxFoto.Image = Image.FromFile(lblFoto.Text);

        }

        private void pbxFoto_Click(object sender, EventArgs e)
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


        //private void ValidarCampos()
        //{
        //    var vr = !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtDni.Text) &&
        //        !string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txtAsistencias.Text)
        //        && !string.IsNullOrEmpty(txtNumeroAlumno.Text);
        //    btnEditar.Enabled = vr;

        //}

        //private void txtNombre_TextChanged(object sender, EventArgs e)
        //{
        //    ValidarCampos();
        //}

        //private void txtApellido_TextChanged(object sender, EventArgs e)
        //{
        //    ValidarCampos();
        //}

        //private void txtDni_TextChanged(object sender, EventArgs e)
        //{
        //    ValidarCampos();
        //}

        //private void txtDireccion_TextChanged(object sender, EventArgs e)
        //{
        //    ValidarCampos();
        //}

        //private void txtTelefono_TextChanged(object sender, EventArgs e)
        //{
        //    ValidarCampos();
        //}

        //private void txtAsistencias_TextChanged(object sender, EventArgs e)
        //{
        //    ValidarCampos();
        //}

        //private void txtNumeroAlumno_TextChanged(object sender, EventArgs e)
        //{
        //    ValidarCampos();
        //}



    }
}

using System;
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
        Validaciones validar = new Validaciones();


        private void btnEditar_Click(object sender, System.EventArgs e)
        {

            SinergiaDB oSinergiaDB = new SinergiaDB();
            var pago = lbPago.SelectedIndex; ;
            var estado = lbEstado.SelectedIndex;
            var fichaMedica = lbFichaMedica.SelectedIndex;
            var carnet = lbCarnet.SelectedIndex;

            oSinergiaDB.Edit(txtNombre.Text, txtApellido.Text, txtDni.Text, txtDireccion.Text, txtTelefono.Text, estado, Convert.ToInt32(txtAsistencias.Text), Convert.ToInt32(txtId.Text), pago, Convert.ToInt32(txtNumeroAlumno.Text), fichaMedica, carnet);

            this.Close();


        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {

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

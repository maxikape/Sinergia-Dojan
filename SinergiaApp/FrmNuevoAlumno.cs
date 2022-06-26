using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinergiaApp
{
    public partial class FrmNuevoAlumno : Form
    {
        public FrmNuevoAlumno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SinergiaDB oSinergiaDB = new SinergiaDB();


            var pago = lbPago.SelectedIndex; ;
            var estado = lbEstado.SelectedIndex;
            try
            {
                oSinergiaDB.Add(txtNombre.Text, txtApellido.Text, txtDni.Text, txtDireccion.Text, txtTelefono.Text, Convert.ToString(dtpFecha.Value), estado, Convert.ToInt32(txtAsistencias.Text), pago, Convert.ToInt32(txtNumeroAlumno.Text));
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al guardar " + ex.Message);
            }



        }

        private void FrmNuevoAlumno_Load(object sender, EventArgs e)
        {

        }

        private void txtDni_Validated(object sender, EventArgs e)
        {

        }
    }
}

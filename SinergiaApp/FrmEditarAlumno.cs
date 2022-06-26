using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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



        private void btnEditar_Click(object sender, System.EventArgs e)
        {
           
           SinergiaDB oSinergiaDB = new SinergiaDB();
            var pago = lbPago.SelectedIndex; ;
            var estado = lbEstado.SelectedIndex;

            oSinergiaDB.Edit(txtNombre.Text, txtApellido.Text, txtDni.Text, txtDireccion.Text, txtTelefono.Text, estado, Convert.ToInt32(txtAsistencias.Text), Convert.ToInt32(txtId.Text),pago, Convert.ToInt32(txtNumeroAlumno.Text));
            
            this.Close();


        }
    }
}

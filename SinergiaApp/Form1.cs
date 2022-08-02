using System;
using System.Windows.Forms;

namespace SinergiaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        SinergiaDB oSinergiaDB = new SinergiaDB();

        Validaciones validar = new Validaciones();

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmAdmin a = new FrmAdmin();
            a.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)

        {
            var a = oSinergiaDB.Existe(Convert.ToInt32(txtNumAlumno.Text));
            FrmFichaAlumno frm = new FrmFichaAlumno(Convert.ToInt32(txtNumAlumno.Text), a);

            frm.ShowDialog();
        }

        private void ValidarCampos()
        {
            var vr = !string.IsNullOrEmpty(txtNumAlumno.Text);
            btnConfirmar.Enabled = vr;

        }




        private void Form1_Load(object sender, EventArgs e)
        {

            btnConfirmar.Enabled = false;
            //wtfffffffffffffffffffffffffffffffffffffffffff
            var fecha = DateTime.Now.Date.Day;
            //int day = fecha.Day;
            if (fecha == 1)
            {
                oSinergiaDB.ReiniarPagos();
            }

        }

        //al presionar entre abrir el formulario del alumo



        private void txtNumAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            var s = string.IsNullOrEmpty(txtNumAlumno.Text);

            if (e.KeyChar == Convert.ToChar(Keys.Enter) && txtNumAlumno.Text == "")
            {


                MessageBox.Show("Precione la tecla enter e ingrese su numero de alumno");


            }


            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                //deberia buscar el alumno aca
                var a = oSinergiaDB.Existe(Convert.ToInt32(txtNumAlumno.Text));

                FrmFichaAlumno frm = new FrmFichaAlumno(Convert.ToInt32(txtNumAlumno.Text), a);


                frm.ShowDialog();


            }
        }

        private void txtNumAlumno_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

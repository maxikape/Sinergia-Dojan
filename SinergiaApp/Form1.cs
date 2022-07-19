using System;
using System.Windows.Forms;

namespace SinergiaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Substring(0, 2);
            //var fecha = Substring(0, 2);
            //if (fecha == "1/")
            //{
            //    this.Close();
            //}

        }

        Validaciones validar = new Validaciones();

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FrmAdmin a = new FrmAdmin();
            a.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmFichaAlumno frm = new FrmFichaAlumno(Convert.ToInt32(txtNumAlumno.Text));
            //Substring(0, 2);
            frm.ShowDialog();
        }

        private void ValidarCampos()
        {
            var vr = !string.IsNullOrEmpty(txtNumAlumno.Text);
            btnConfirmar.Enabled = vr;

        }


        //public string Substring(int startIndex, int length)
        //{
        //    string fechaActual = DateTime.Now.Date.ToString();

        //    // recupero el numero de alumno del textbox
        //    //int valor2 = Convert.ToInt32(txtNumAlumno.Text);
        //    SinergiaDB Osine = new SinergiaDB();

        //    //Osine.RecuperarAlumno(1);

        //    string fecha = fechaActual.Substring(startIndex, length);
        //    return fecha;
        //}


        private void Form1_Load(object sender, EventArgs e)
        {
            //var fecha = Substring(0, 2);
            //if (fecha == "1/")
            //{
            //    this.Close();
            //}
            btnConfirmar.Enabled = false;
            
        }

        //al presionar entre abrir el formulario del alumo



        private void txtNumAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            var s = string.IsNullOrEmpty(txtNumAlumno.Text);

            if (e.KeyChar == Convert.ToChar(Keys.Enter) && txtNumAlumno.Text == "")
            {


                MessageBox.Show("Precione la tecla enter e ingrese su numero de alumno");


            }


            else if (e.KeyChar == Convert.ToChar(Keys.Enter) )
            {


                FrmFichaAlumno frm = new FrmFichaAlumno(Convert.ToInt32(txtNumAlumno.Text));
                //Substring(0, 2);
                frm.ShowDialog();


            }
        }

        private void txtNumAlumno_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }


    }
}

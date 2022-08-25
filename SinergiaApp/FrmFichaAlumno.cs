using System;
using System.Drawing;
using System.Windows.Forms;

namespace SinergiaApp
{
    public partial class FrmFichaAlumno : Form
    {

        public FrmFichaAlumno(int codigo, bool existe)
        {
            InitializeComponent();

            //recupero solo el dia de la fecha actual
            var fechaPago = Substring(0, 2);
            //recupero fecha del dia completa para guardar el dia que asistio
            var FechaTb = DateTime.Now.Date;


            SinergiaDB OsinergiaDB = new SinergiaDB();

            if (existe == true)
            {
                MessageBox.Show("el alumno no existe");

            }
            else
            {
                Alumnos alumno = OsinergiaDB.RecuperarAlumno(codigo);
                lblNombre.Text = alumno.Nombre;
                lblApellido.Text = alumno.Apellido;
                lblDni.Text = alumno.Dni;
                
                pictureBox2.Image = Image.FromFile(alumno.Foto);

                var ficha = alumno.FichaMedica;
                var carnet = alumno.Carnet;

                var pago = alumno.Pago;
                //si debe cuota o no debe después del dia 10
                if (pago == 0 & (fechaPago == "11" || fechaPago == "12" || fechaPago == "13" || fechaPago == "14" || fechaPago == "15" || fechaPago == "16"
                    || fechaPago == "17" || fechaPago == "18" || fechaPago == "19" || fechaPago == "20" || fechaPago == "21" || fechaPago == "22"
                    || fechaPago == "23" || fechaPago == "24" || fechaPago == "25" || fechaPago == "26" || fechaPago == "27" || fechaPago == "28"
                    || fechaPago == "29" || fechaPago == "30" || fechaPago == "31"))
                {
                    lblPago.Text = "IMPAGA";
                    //cambio el color a rojo
                    lblPago.BackColor = System.Drawing.Color.Red;

                    var asisten = alumno.Asistencias + 1;
                    OsinergiaDB.SumarAsistencia(alumno.Id, asisten);
                    //sumo la fecha del dia asistido
                    OsinergiaDB.AgregarFecha(Convert.ToString(FechaTb), alumno.Id);
                    Alumnos alumno1 = OsinergiaDB.RecuperarAlumno(codigo);
                    lblAsistencias.Text = alumno1.Asistencias.ToString();

                    if (ficha == 1)
                    {
                        label7.Text = "SI";
                        //cambio el color a verde
                        label7.BackColor = System.Drawing.Color.Green;
                    }
                    else if (ficha == 0)
                    {
                        label7.Text = "No";
                        //cambio el color a rojo
                        label7.BackColor = System.Drawing.Color.Red;
                    }


                    if (carnet == 1)
                    {
                        label9.Text = "SI";
                        //cambio el color a verde
                        label9.BackColor = System.Drawing.Color.Green;
                    }
                    else if (carnet == 0)
                    {
                        label9.Text = "No";
                        //cambio el color a rojo
                        label9.BackColor = System.Drawing.Color.Red;
                    }

                }
                else
                {
                    lblPago.BackColor = System.Drawing.Color.Green;
                    lblPago.Text = "PAGA";
                    var asisten = alumno.Asistencias + 1;
                    //sumo asistencia al alumno
                    OsinergiaDB.SumarAsistencia(alumno.Id, asisten);
                    //sumo la fecha del dia asistido
                    OsinergiaDB.AgregarFecha(Convert.ToString(FechaTb), alumno.Id);
                    Alumnos alumno1 = OsinergiaDB.RecuperarAlumno(codigo);
                    lblAsistencias.Text = alumno1.Asistencias.ToString();
                    //?
                    string a = Convert.ToString(FechaTb);
                    //le paso la fecha y el id del alumno 


                    //OsinergiaDB.AgregarFecha(a,alumno.Id);
                    if (ficha == 1)
                    {
                        label7.Text = "SI";
                        //cambio el color a verde
                        
                        label7.BackColor = System.Drawing.Color.Green;
                    }
                    else if (ficha == 0)
                    {
                        label7.Text = "No";
                        //cambio el color a rojo
                        label7.BackColor = System.Drawing.Color.Red;
                    }


                    if (carnet == 1)
                    {
                        label9.Text = "SI";
                        //cambio el color a verde
                        label9.BackColor = System.Drawing.Color.Green;
                    }
                    else if (carnet == 0)
                    {
                        label9.Text = "No";
                        //cambio el color a rojo
                        label9.BackColor = System.Drawing.Color.Red;
                    }

                    //if (ficha == 1)
                    //{
                    //    label7.Text = "SI";
                    //    //cambio el color a verde
                    //    label7.ForeColor = System.Drawing.Color.Green;
                    //}
                    //else
                    //{
                    //    label7.Text = "No";
                    //    //cambio el color a rojo
                    //    label7.ForeColor = System.Drawing.Color.Red;
                    //}

                    //if (carnet == 1)
                    //{
                    //    label9.Text = "SI";
                    //    //cambio el color a verde
                    //    label9.ForeColor = System.Drawing.Color.Green;
                    //}
                    //else
                    //{
                    //    label9.Text = "No";
                    //    //cambio el color a rojo
                    //    label9.ForeColor = System.Drawing.Color.Red;
                    //}
                }
            }

        }


        //recupero la fecha acual
        public string Substring(int startIndex, int length)
        {
            string fechaActual = DateTime.Now.Date.ToString();
            //weboooooooooooo!
            string fecha = fechaActual.Substring(startIndex, length);
            return fecha;
        }

        private void FrmFichaAlumno_Load(object sender, EventArgs e)
        {

        }


        private void FrmFichaAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            this.Close();

        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }
}

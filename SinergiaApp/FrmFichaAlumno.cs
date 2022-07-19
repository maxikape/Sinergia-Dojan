using System;
using System.Windows.Forms;

namespace SinergiaApp
{
    public partial class FrmFichaAlumno : Form
    {

        public FrmFichaAlumno(int codigo)
        {
            InitializeComponent();

            //recupero solo el dia de la fecha actual
            var fechaPago = Substring(0, 2);



            SinergiaDB OsinergiaDB = new SinergiaDB();
            Alumnos alumno = OsinergiaDB.RecuperarAlumno(codigo);
            if (alumno == null)
            {
                MessageBox.Show("el alumno no extiste");
            }
            else
            {
                lblNombre.Text = alumno.Nombre;
                lblApellido.Text = alumno.Apellido;
                lblDni.Text = alumno.Dni;

                var pago = alumno.Pago;
                //si debe cuota o no debe después del dia 10
                if (pago == 0 & (fechaPago == "11" || fechaPago == "12" || fechaPago == "13" || fechaPago == "14" || fechaPago == "15" || fechaPago == "16"
                    || fechaPago == "17" || fechaPago == "18" || fechaPago == "19" || fechaPago == "20" || fechaPago == "21" || fechaPago == "22"
                    || fechaPago == "23" || fechaPago == "24" || fechaPago == "25" || fechaPago == "26" || fechaPago == "27" || fechaPago == "28"
                    || fechaPago == "29" || fechaPago == "30" || fechaPago == "31"))
                {
                    lblPago.Text = "Impaga";
                    var asisten = alumno.Asistencias + 1;
                    OsinergiaDB.SumarAsistencia(alumno.Id, asisten);
                    Alumnos alumno1 = OsinergiaDB.RecuperarAlumno(codigo);
                    lblAsistencias.Text = alumno1.Asistencias.ToString();

                }
                else
                {
                    lblPago.Text = "Paga";
                    var asisten = alumno.Asistencias + 1;
                    OsinergiaDB.SumarAsistencia(alumno.Id, asisten);
                    Alumnos alumno1 = OsinergiaDB.RecuperarAlumno(codigo);
                    lblAsistencias.Text = alumno1.Asistencias.ToString();

                }
            }

        }


        //recupero la fecha acual
        public string Substring(int startIndex, int length)
        {
            string fechaActual = DateTime.Now.Date.ToString();

            string fecha = fechaActual.Substring(startIndex, length);
            return fecha;
        }

        private void FrmFichaAlumno_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

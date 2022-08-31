using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SinergiaApp
{
    public partial class FrmAdmin : Form
    {
        SqlConnection connection = new SqlConnection("Data Source= DESKTOP-P9QCAB9;Initial Catalog= SinergiaDB;Integrated Security = True");


        public FrmAdmin()
        {
            InitializeComponent();
            //Refrescar();


        }

        SinergiaDB OsinergiaDB = new SinergiaDB();

       //Instancio el Form que abrire


        private void FrmAdmin_Load(object sender, EventArgs e)
        {

            MostrarAlumnos();

        }

        private void MostrarAlumnos()
        {

            dgvAlumnos.DataSource = OsinergiaDB.Get();
            connection.Close();


        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            FrmNuevoAlumno frmnuevoa = new FrmNuevoAlumno();

            frmnuevoa.ShowDialog();
            //Refrescar();

        }

        public void Refrescar()
        {

           
            dgvAlumnos.DataSource = OsinergiaDB.Get();

            //var fecha = Substring(0, 1);
            //if (fecha == "0/")
            //{
            //    fecha = "";
            //}

        }
        

        private void dgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //public void Edit(int Id, string Apellido, string Nombre, string Dni, string Direccion, string Telefono, int NumeroAlumno,  int Estado, int Asistencias, int Pago,int FichaMedica, int Carnet)


            FrmEditarAlumno frmE = new FrmEditarAlumno();
            frmE.txtId.Text = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
            frmE.txtApellido.Text = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
            frmE.txtNombre.Text = dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
            frmE.txtDni.Text = dgvAlumnos.CurrentRow.Cells[3].Value.ToString();
            frmE.txtDireccion.Text = dgvAlumnos.CurrentRow.Cells[4].Value.ToString();
            frmE.txtTelefono.Text = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();
            frmE.txtNumeroAlumno.Text = dgvAlumnos.CurrentRow.Cells[6].Value.ToString();

            frmE.lbEstado.SelectedIndex = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[8].Value);


            frmE.txtAsistencias.Text = dgvAlumnos.CurrentRow.Cells[9].Value.ToString();
            frmE.lbPago.SelectedIndex = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[10].Value);


            frmE.lbFichaMedica.SelectedIndex = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[11].Value);
            frmE.lbCarnet.SelectedIndex = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[12].Value);

            frmE.lblFoto.Text = Convert.ToString(dgvAlumnos.CurrentRow.Cells[13].Value.ToString());





            frmE.ShowDialog();


        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }


        //private void textBox1_KeyUp(object sender, KeyEventArgs e)
        //{

        //    connection.Open();


        //    SqlCommand comando = connection.CreateCommand();

        //    comando.CommandType = CommandType.Text;
        //    comando.CommandText = "Select * from Alumnos WHERE Apellido like('" + textBox1.Text + "%')"; ;
        //    comando.ExecuteNonQuery();

        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(comando);
        //    da.Fill(dt);

        //    dgvAlumnos.DataSource = dt;

        //    connection.Close();


        //}

        public string Substring(int startIndex, int length)
        {
            string fechaActual = DateTime.Now.Date.ToString();

            string fecha = fechaActual.Substring(startIndex, length);
            return fecha;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {



            connection.Open();


            SqlCommand comando = connection.CreateCommand();

            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Alumnos WHERE Apellido like('" + textBox1.Text + "%')"; ;
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);

            dgvAlumnos.DataSource = dt;
            
            connection.Close();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SinergiaDB OsinergiaDB = new SinergiaDB();

            OsinergiaDB.ReiniarPagos();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

            MostrarAlumnos();

        }

        private void MostrarAlumnos()
        {

            SinergiaDB OsinergiaDB = new SinergiaDB();
            dgvAlumnos.DataSource = OsinergiaDB.Get();


        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            FrmNuevoAlumno frmnuevoa = new FrmNuevoAlumno();
            frmnuevoa.ShowDialog();
            Refrescar();

        }

        public void Refrescar()
        {

            SinergiaDB OsinergiaDB = new SinergiaDB();
            dgvAlumnos.DataSource = OsinergiaDB.Get();

            //var fecha = Substring(0, 1);
            //if (fecha == "0/")
            //{
            //    fecha = "";
            //}

        }

        private void dgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            FrmEditarAlumno frmE = new FrmEditarAlumno(); //Instancio el Form que abrire

            frmE.txtId.Text = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
            frmE.txtNombre.Text = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
            frmE.txtApellido.Text = dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
            frmE.txtDni.Text = dgvAlumnos.CurrentRow.Cells[3].Value.ToString();
            frmE.txtDireccion.Text = dgvAlumnos.CurrentRow.Cells[4].Value.ToString();
            frmE.txtTelefono.Text = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();
            //frmE.dtpFecha.Value = dgvAlumnos.CurrentRow.Cells[5];
            //seleciono en el listBox de acuerdo a la BD
            frmE.lbEstado.SelectedIndex = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[7].Value);
            frmE.txtAsistencias.Text = dgvAlumnos.CurrentRow.Cells[8].Value.ToString();
            frmE.lbPago.SelectedIndex = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[9].Value);

            frmE.ShowDialog();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }


        private void textBox1_KeyUp(object sender, KeyEventArgs e)
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

        public string Substring(int startIndex, int length)
        {
            string fechaActual = DateTime.Now.Date.ToString();

            string fecha = fechaActual.Substring(startIndex, length);
            return fecha;
        }

    }
}

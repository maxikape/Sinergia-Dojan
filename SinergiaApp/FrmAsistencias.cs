using System;
using System.Windows.Forms;

namespace SinergiaApp
{
    public partial class FrmAsistencias : Form
    {
        int s = 0;
        public FrmAsistencias(int id)
        {
            InitializeComponent();
            s = id;
        }





        private void MostrarFechas()
        {

            SinergiaDB OsinergiaDB = new SinergiaDB();
            //???????????
            dgvAsistencias.DataSource = OsinergiaDB.MostrarFechas(s);


        }

        private void FrmAsistencias_Load(object sender, EventArgs e)
        {
            MostrarFechas();
        }
    }
}

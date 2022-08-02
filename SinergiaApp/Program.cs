using System;
using System.Windows.Forms;

namespace SinergiaApp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 




        //******************************************************************************************************
        //******************************************************************
        //***************************************

        //#pragma warning disable CS1520 // El método debe tener un tipo de valor devuelto
        //        static Substring(int startIndex, int length)
        //#pragma warning restore CS1520 // El método debe tener un tipo de valor devuelto
        //        {
        //            string fechaActual = DateTime.Now.Date.ToString();

        //            string fecha = fechaActual.Substring(startIndex, length);
        //            return fecha;
        //        }

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}

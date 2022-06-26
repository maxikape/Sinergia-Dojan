using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinergiaApp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

         static Substring(int startIndex, int length)
        {
            string fechaActual = DateTime.Now.Date.ToString();

             string fecha = fechaActual.Substring(startIndex, length);
            return fecha ;
        }

        [STAThread]
        static void Main()
        {
       
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}

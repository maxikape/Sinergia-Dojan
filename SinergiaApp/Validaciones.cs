using System;
using System.Windows.Forms;

namespace SinergiaApp
{
    public class Validaciones
    {
        public void SoloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;

                }

                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;

                }

                else
                {
                    e.Handled = true;
                }

            }
            catch (Exception)
            {

                throw;
            }


        }


        public void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;

                }

                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;

                }

                else
                {
                    e.Handled = true;
                }

            }
            catch (Exception)
            {

                throw;
            }


        }



    }
}

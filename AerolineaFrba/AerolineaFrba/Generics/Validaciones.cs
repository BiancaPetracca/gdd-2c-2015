using AerolineaFrba.SuperControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AerolineaFrba
{
    public class Validaciones : Form
    {
 

        /******** VALIDACIONES PARA CAMPOS NO NULOS ********/
        public String validate(ISuperControls control)
        {
            var controlName = "";
            if (! control.valid())
            {
                controlName = ((Control)control).AccessibleDescription + "\n";
            }
            return controlName;
        }


        public Boolean anyEmptyCells(DataGridView dg, String columnName, String msg)
        {
            Boolean val = false;
            string cell;

            try
            {
                foreach (DataGridViewRow rw in dg.Rows)
                {
                    cell = rw.Cells[dg.Columns[columnName].Index].Value as string;
                    if (string.IsNullOrEmpty(cell))
                    {
                        val = true;
                        throw new Exception(msg);
                    }
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            return val;
        }


        // try catchea una excepcion proviniente de campos vacios
        public Boolean validateNotNullForAll(Control.ControlCollection controls)
        {
            var isValid = false;
            try { isValid = validar(controls); }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            return isValid;
        }

        public Boolean validar(Control.ControlCollection controls)
        {

            bool val = false;
          var msg = "";
            foreach (Control control in controls)
            {
                val = ((ISuperControls)control).valid();
               msg += validate((ISuperControls)control);
            }
        if (msg != String.Empty) 
            {
                throw new Exception("Complete los campos vacios: \n" + msg);

            }
        return val;
        }

        public Boolean noRows(DataGridView dg, String msg)
        {
            bool val = false;
            try { if (dg.Rows.Count == 0) { val = true;  throw new Exception(msg); } }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            return val;
        }


        /******** VALIDACIONES PARA EL TIPO DE LOS CARACTERES ********/


        /* no permiten que el usuario pueda ingresar caracteres que no van directamente, me ahorro la validacion */
        public void allowNumericOnly(KeyPressEventArgs e) {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public void allowAlphaOnly(KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public void allowAlphanumericOnly(KeyPressEventArgs e) {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }






    }
}

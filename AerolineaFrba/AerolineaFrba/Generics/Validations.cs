using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.SuperControls;

namespace AerolineaFrba.Generics
{
    public static class Validations
    {
        /******** VALIDACIONES PARA CAMPOS NO NULOS ********/
        public static String validate(this ISuperControls control)
        {
            var controlName = "";
            if (!control.valid())
            {
                controlName = ((Control)control).AccessibleDescription + "\n";
            }
            return controlName;
        }


        public static Boolean anyEmptyCells(this DataGridView dg, String columnName, String msg)
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
        public static Boolean validateNotNullForAll(this Form aForm, Control.ControlCollection controls)
        {
            var isValid = false;
            try { isValid = aForm.validar(controls); }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            return isValid;
        }

        public static Boolean validar(this Form aForm, Control.ControlCollection controls)
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

        public static Boolean noRows(this DataGridView dg, String msg)
        {
            bool val = false;
            try { if (dg.Rows.Count == 0) { val = true; throw new Exception(msg); } }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            return val;
        }


        public static Boolean domainValidations(this Form aForm, params Func<Boolean>[] criteria)
        {
            var msg = "";
            var isvalid = true;
            foreach (Func<Boolean> criterium in criteria)
            {
                if (!criterium())
                {
                    msg += criterium.ToString();
                }
            }
            if (criteria.Any(x => !x()))
            {
                isvalid = false;
                throw new Exception(msg);
            }
            return isvalid;

        }


        /******** VALIDACIONES PARA EL TIPO DE LOS CARACTERES ********/


        /* no permiten que el usuario pueda ingresar caracteres que no van directamente, me ahorro la validacion */
        public static void allowNumericOnly(this Form aForm, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public static void allowAlphaOnly(this Form aForm, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public static void allowAlphanumericOnly(this Form aForm, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }



    }
}

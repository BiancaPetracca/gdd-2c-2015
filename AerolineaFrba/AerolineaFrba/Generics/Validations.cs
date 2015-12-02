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

        // saber si hay celdas vacias en una dg
        public static Boolean anyEmptyCells(this DataGridView dg)
        {
           if (dg.Rows.Count == 0) { return true; }

           foreach (DataGridViewRow rw in dg.Rows)
           {
               for (int i = 0; i < dg.Columns.Count; i++)
               {
                   if (rw.Cells[i].Value == null)
                   {
                       return true;
                   }
               }
           }
           return false;

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

        // validar que los controles no esten vacios
        private static Boolean validar(this Form aForm, Control.ControlCollection controls)
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

        // metodo para verificar si no hay filas en una data grid
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


        // metodo para hacer validaciones de dominio, pasandole funciones(criterios) y un mensaje que debe emitir si no se cumple
        private static Boolean domainValidations(this Form aForm, params Tuple<Func<Boolean>, String>[] criteria)
        {
            var msg = "";
            Boolean isvalid = true;

            foreach (var criterium in criteria)
            {

                if (!criterium.Item1())
                {
                    msg += criterium.Item2 + "\n";
                }
            }
            //  if (criteria.Any(x => !x.Item1()))
            if (msg != "")
            {
                isvalid = false;
                throw new Exception(msg);
            }
            return isvalid;

        }

        // metodo que catchea todas las excepciones de las validaciones y emite un mensaje con eso
        public static Boolean validateDomain(this Form aForm, params Tuple<Func<Boolean>, String>[] criteria)
        {
            var isValid = false;
            try { isValid = aForm.domainValidations(criteria); }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            return isValid;
        }

        // metodo auxiliar para crear la tupla
        public static Tuple<Func<Boolean>, String> criteriumMessage(Func<Boolean> criterium, String message)
        {
            return Tuple.Create(criterium, message);
        }


        /******** VALIDACIONES PARA EL TIPO DE LOS CARACTERES ********/


        /* no permiten que el usuario pueda ingresar caracteres que no van directamente */
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

        public static void allowLessThanLength(this Form aForm, SuperNumericUpDown num, KeyPressEventArgs e)
        {

            e.Handled = (num.Value.ToString().Length >= 4);
        }

        public static void columnAsTextBox(DataGridView dg, List<int> cols, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (cols.Contains(dg.CurrentCell.ColumnIndex)) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }

            }
        }
        private static void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static Boolean anySelectedCells(this DataGridView dg) {
            if (dg.Rows.Count == 0) { return false; }
            return (dg.SelectedCells.Count != 0 || dg.SelectedRows.Count != 0);
        }
    }


}

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
 
// ESTOS VALIDATE QUIERO QUE SEAN POLIMORFICOS PARA CONTROLS ASI NOS AHORRAMOS HACER validate(asdasd) + PARA TODO


        /******** VALIDACIONES PARA CAMPOS NO NULOS ********/
        public String validate(ISuperControls control)
        {
            var controlName = "";
            if (! control.valid())
            {
                controlName = ((Control)control).Name + "\n";
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
        public void validateAll(Control.ControlCollection controls)
        {
            try { validar(controls); }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        public void validar(Control.ControlCollection controls)
        {
            List<ISuperControls> sc = new List<ISuperControls>();
            foreach (Control ctr in controls) {
                sc.Add((ISuperControls)ctr);
            }

            bool val = false;
          var msg = "";
            foreach (ISuperControls control in sc)
            {
                val = control.valid();
               msg += validate(control);
            }
        if (msg != String.Empty) 
            {
                throw new Exception("Complete los campos vacios: \n" + msg);

            } 
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

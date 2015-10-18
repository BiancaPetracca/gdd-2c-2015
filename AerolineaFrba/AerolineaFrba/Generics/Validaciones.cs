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
       /* public void mostrarExcepcion()
        {

          //  try { validarTodosCampos(); }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }


        }*/


        // encapsula un metodo que toma como parametro un string y devuelve void
        public delegate void Del(string message);

        // crear el metodo para el delegado
        public static void DelegateMethod(string message)
        {
            MessageBox.Show(message);

        }



        public String validate(ComboBox comboBox)
        {
            var combo = "";
            if (comboBox.SelectedIndex == -1) {
                combo = comboBox.Name + "\n";
            }
            return combo;
        }

        public String validate(TextBox textBox)
        {
            var text = "";
            if (textBox.Text == String.Empty)
            {
                text = textBox.Name + "\n";
            }
            return text;
        }

        public String validate(CheckedListBox listaChecks) { 
         var checks = "";
         if (listaChecks.CheckedItems.Count == 0) {
             checks = listaChecks.Name + "\n";
         }
         return checks;
        
        }





        public void show(Exception e)
        {
            MessageBox.Show(e.Message);
        }

        /* ejemplo de invocacion 
         DelegateMethod handler = DelegateMethod;
            handler("hola");
         */


    }
}

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

// ESTOS VALIDATE QUIERO QUE SEAN POLIMORFICOS PARA CONTROLS ASI NOS AHORRAMOS HACER validate(asdasd) + PARA TODO

        public String validate(ComboBox comboBox)
        {
            var combo = "";
            if (comboBox.SelectedIndex == -1)
            {
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

        public String validate(CheckedListBox listaChecks)
        {
            var checks = "";
            if (listaChecks.CheckedItems.Count == 0)
            {
                checks = listaChecks.Name + "\n";
            }
            return checks;

        }


        public String validate(NumericUpDown numeric)
        {
            var num = "";
            if (numeric.Value == 0)
            {
                num = numeric.Name + "\n";
            }
            return num;
        }


        public void show(Exception e)
        {
            MessageBox.Show(e.Message);
        }


        // tira una excepcion si alguno de los campos está vacío
        public void validateEmptyFields(String msg)
        {
            if (msg == String.Empty)
            {
                throw new Exception("Faltan campos: \n" + msg);
            }
        }


        // try catchea una excepcion proviniente de campos vacios
        public void validateAll(String msg)
        {

            try { validateEmptyFields(msg); }
            catch (Exception excepcion)
            {
                show(excepcion);
            }


        }
    }
}

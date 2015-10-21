
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace AerolineaFrba
{
   public class TemplateForm : Validaciones
    {

       // Método genérico para abrir un form dentro del form padre (ej: en el menú principal)
        public void openIntoParent(Form form, Form parentForm)
        {
            if (parentForm.ActiveMdiChild != null) { parentForm.ActiveMdiChild.Close(); }
            form.MdiParent = parentForm;
            form.Dock = DockStyle.Fill;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

       public void openInNewWindow(Form form){
           form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
           form.Show();
       }



    }
}

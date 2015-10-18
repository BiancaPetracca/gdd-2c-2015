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
            if (ActiveMdiChild != null) { ActiveMdiChild.Close(); }
            form.MdiParent = parentForm;
            form.Dock = DockStyle.Fill;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}

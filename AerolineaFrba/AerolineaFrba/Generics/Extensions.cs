using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.SuperControls;

namespace AerolineaFrba.Generics
{
    public static class Extensions
    {

        public static void whenColumnOpen(this DataGridView dg, DataGridViewCellEventArgs e, String column)
        {

            if (e.ColumnIndex == dg.Columns[column].Index)
            {
                //
            }

        }

        public static void openIntoParent(this Form aForm, Form form, Form parentForm)
        {
            if (parentForm.ActiveMdiChild != null) { parentForm.ActiveMdiChild.Close(); }
            form.MdiParent = parentForm;
            form.Dock = DockStyle.Fill;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        public static void openInNewWindow(this Form aForm, Form form)
        {
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            form.Show();
        }
    }
}

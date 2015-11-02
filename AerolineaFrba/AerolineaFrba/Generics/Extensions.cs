using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.SuperControls;
using System.Reflection;

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


        /* metodo que convierte una lista de algun objeto en strings de un campo "fieldToConvert" de ese objeto*/
        public static List<String> listToStr<T>(List<T> list, String fieldToConvert)
        {
            List<String> convertedToStr = new List<String>();
            foreach (T elem in list)
            {
                String val = elem.GetType().GetProperty(fieldToConvert).GetValue(elem, null).ToString();
                convertedToStr.Add(val);
            }
            return convertedToStr;
        }

            
        }

    }


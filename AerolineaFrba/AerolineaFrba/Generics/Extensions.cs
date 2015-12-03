using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.SuperControls;
using System.Reflection;
using System.Data;

namespace AerolineaFrba.Generics
{
    public static class Extensions
    {


        // abre dentro de la form, la form indicada
        public static void openIntoParent(this Form aForm, Form form, Form parentForm)
        {
            if (parentForm.ActiveMdiChild != null) { parentForm.ActiveMdiChild.Close(); }
            form.MdiParent = parentForm;
            form.Dock = DockStyle.Fill;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }


        public static void openIntoParentBlocking(this Form aForm, Form form, Form parentForm)
        {

            if (parentForm.ActiveMdiChild != null) { parentForm.ActiveMdiChild.Close(); }
            form.MdiParent = parentForm;
            form.Dock = DockStyle.Fill;
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();

        }
        // abre en una nueva ventana la form indicada
        public static void openInNewWindow(this Form aForm, Form form)
        {
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            form.ShowDialog();
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


        // metodo para limpiar todo lo que tienen los controles o inicializarlos de nuevo 
        public static void cleanAll(Control.ControlCollection controls)
        {
            foreach (Control ctr in controls)
            {
                ((ISuperControls)ctr).clean();
            }

        }

        public static Object cellValue(this DataGridView dg, String column) {
            return dg.CurrentRow.Cells[column].Value;
        }


        public static void clean(this DataGridView dg){
            for (int i = 0; i < dg.Rows.Count; i++ )
            {
                dg.Rows.RemoveAt(i);
            }
        } 
        // activar todos los controles 
        public static void enableAll(this Form aForm, Boolean value, params Control[] controls){
            foreach (Control control in controls) {
                control.Enabled = value;
 }
    }
        // limpiar una grid que esta bindeada a una data table
        public static void clearBindedDT(this DataGridView dg) {

            DataTable DT = (DataTable)dg.DataSource;
            if (DT != null)
                DT.Clear();
        }

        // saber si hay alguna fila de la datagridview que este seleccionada, y le agrego algo descriptivo
        public static Boolean anySelected(this DataGridView dg, String addon) {
            if (dg.CurrentRow == null) {
                MessageBox.Show("Debe seleccionar al menos " + addon);
            
            }
            return dg.CurrentRow != null;
        }

        public static Boolean anySelected(this DataGridView dg)
        {            return dg.CurrentRow != null;
        }
  
    }

}


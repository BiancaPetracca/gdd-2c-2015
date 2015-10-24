using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Devolucion
{
    public partial class Devolver : TemplateForm
    {
        public Devolver()
        {
            InitializeComponent();
        }


        private void Agregar_Click(object sender, EventArgs e)
        {
            if (validateNotNullForAll(this.CompraDevolver.Controls))
            this.Devoluciones.Rows.Add(this.Fecha.Value, this.PNR.Text, this.Codigo.Text, this.MotivoDevolucion.Text);
        }

        private void RealizarDevolucion_Click(object sender, EventArgs e)
        {
            try { if (this.Devoluciones.Rows.Count == 0) { throw new Exception("No ha agregado nada para realizar su devolución"); } }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
            // LLAMAR A PROCEDURE QUE GUARDE ESO
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.Devoluciones.Rows.Clear();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

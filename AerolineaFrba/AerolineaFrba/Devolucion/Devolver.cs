using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Generics;
using AerolineaFrba.SuperControls;

namespace AerolineaFrba.Devolucion
{
    public partial class Devolver : Form
    {
        public Devolver()
        {
            InitializeComponent();
        }


        private void Agregar_Click(object sender, EventArgs e)
        {
            if (this.pasajes.valid())
            {
                if (validarSinRepetido(this.pasajes))
                {
                    this.Devoluciones.Rows.Add(this.codigoCompra.value, this.pasajes.value, this.MotivoDevolucion.value);
                    this.codigoCompra.Enabled = false;
                }
            }
        }

        private void RealizarDevolucion_Click(object sender, EventArgs e)
        {
           Decimal devolucion = DAO.DAOCompra.crearDevolucion(Convert.ToDecimal(codigoCompra.value));
            foreach (DataGridViewRow row in Devoluciones.Rows) {
               DAO.DAOCompra.devolverItems(devolucion, Convert.ToDecimal(row.Cells["col_item"].Value), Convert.ToString(row.Cells["col_motivo"].Value));
            
            }
            MessageBox.Show("Devolucion realizada, código de devolucion: " + devolucion.ToString());
            this.codigoCompra.Enabled = true;
            this.Devoluciones.clean();


        }
        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.Devoluciones.Rows.Clear();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void superTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
        }

        private void verCompras_Click(object sender, EventArgs e)
        {
           
            if (!DAO.DAOCliente.existeCliente(tipo_doc.value, dni.value)){
            MessageBox.Show("No existe cliente con dicho dni");
                return;
            }
            this.codigoCompra.clean();
            this.codigoCompra.AddAll(DAO.DAOCompra.listarCompras(dni.value));
        }

        private void codigoCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            Decimal cod = Convert.ToDecimal(this.codigoCompra.value);
            this.pasajes.clean();
            this.pasajes.AddAll(DAO.DAOCompra.listarPasajes(cod));
            this.encomiendas.clean();
            this.encomiendas.AddAll(DAO.DAOCompra.listarEncomiendas(cod));
        }

        private void agregarEncomienda_Click(object sender, EventArgs e)
        {
            if (this.encomiendas.valid())
            {
                if (validarSinRepetido(this.encomiendas))
                {
                    this.Devoluciones.Rows.Add(this.codigoCompra.value, this.encomiendas.value, this.MotivoDevolucion.value);
                    this.codigoCompra.Enabled = false;
                }
            }


        }

        private Boolean validarSinRepetido(SuperComboBox cb) {
            if (!this.codigoCompra.valid()) { return false; ; }
            foreach (DataGridViewRow row in this.Devoluciones.Rows)
            {
                if (Convert.ToString(row.Cells["col_item"].Value) == cb.value)
                {

                    MessageBox.Show("Ya esta ingresado ese pasaje");
                    return false;

                }
                
            }
            return true;
        }
    }
}

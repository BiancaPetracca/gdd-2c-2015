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

namespace AerolineaFrba.Canje_Millas
{
    public partial class Canje_Millas : Form
    {
        public Canje_Millas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RealizarCanje_Click(object sender, EventArgs e)
        {
            this.validateNotNullForAll(this.DatosCanjeador.Controls);

            try { if (this.ProductosCanjear.Rows.Count == 0) { throw new Exception("Elija algún producto para canjear"); } }
            catch (Exception excepcion) {
                MessageBox.Show(excepcion.Message);
            }

            // LLAMAR AL PROCEDURE QUE GUARDE TODO LO QUE ESTA EN LA GRID 
            
         
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Agregar_Click(object sender, EventArgs e)
        {
           
            this.ProductosCanjear.Rows.Add(this.NombreProducto.SelectedValue, this.CantidadProducto.Value);
        }

        private void NombreProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cuando elijo un producto seteo el maximo de la cantidad al maximo stock que hay. cada vez que agrego reload 
            this.CantidadProducto.Value = 0;
            this.CantidadProducto.Maximum = DAO.DAOProductos.obtenerCantidadProducto(this.NombreProducto.value);
        }

        private void Canje_Millas_Load(object sender, EventArgs e)
        {
            this.NombreProducto.AddAll(DAO.DAOProductos.listarProductos());
        }

        private void FechaCanje_ValueChanged(object sender, EventArgs e)
        {
        }

        private void verificar_Click(object sender, EventArgs e)
        {
            if (DAO.DAOUsuario.elClienteExiste(this.DNI.value) == -1) {
                MessageBox.Show("El cliente no existe, verifique que ingresó correctamente el dni.");
                return;
            }
        }


    }
}

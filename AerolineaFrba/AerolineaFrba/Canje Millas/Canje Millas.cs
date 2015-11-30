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
                return;
            }

            DAO.DAOMillas.canjearProductos(ProductosCanjear, tipoDNI.value, DNI.value);
            MessageBox.Show("Productos canjeados con éxito");
            reload();
            
         
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            reload();
        }


        private void Agregar_Click(object sender, EventArgs e)
        {
            if (productosDisponibles.SelectedRows.Count == 0 || productosDisponibles.SelectedCells.Count == 0) {
                MessageBox.Show("Seleccione un producto");
                return;
            }
           if (((currentStock() > 0) && (Convert.ToDecimal(sumaParcialCanjes.value) + currentMillas() <= Convert.ToDecimal(millasQueTiene.value)))){
            aumentarYRestar(currentProducto(productosDisponibles, "col_producto"));
            sumaParcialCanjes.Text = Convert.ToString(Convert.ToDecimal(sumaParcialCanjes.value) + currentMillas());
            return;
        }
           MessageBox.Show("No dispone de la cantidad suficiente de millas");
        }

        private void FechaCanje_ValueChanged(object sender, EventArgs e)
        {
        }

        private void verificar_Click(object sender, EventArgs e)
        {
            if (!this.validateNotNullForAll(this.DatosCanjeador.Controls)){
            return; 
            }
            if (!DAO.DAOCliente.existeCliente(tipoDNI.value, DNI.value)) {
                MessageBox.Show("El cliente no existe, verifique que ingresó correctamente el dni.");
                return;
            }
            millasQueTiene.Text =  Convert.ToString(DAO.DAOCliente.obtenerMillasCliente(tipoDNI.value, DNI.value));
            tipoDNI.Enabled = false;
            DNI.ReadOnly = true;
            Agregar.Enabled = true;
            Cancelar.Enabled = true;
            RealizarCanjes.Enabled = true;
           
        }

        private String currentProducto(DataGridView dg, String col) { 
          int row =  dg.CurrentRow.Index;
          return Convert.ToString(dg.Rows[row].Cells[col].Value);
        }

        private Decimal currentStock()
        {
            return Convert.ToDecimal(productosDisponibles.Rows[productosDisponibles.CurrentRow.Index].Cells["col_stock"].Value);
        }

        private Decimal currentMillas()
        {
            return Convert.ToDecimal(productosDisponibles.Rows[productosDisponibles.CurrentRow.Index].Cells["col_millas"].Value);
        }

        private Boolean contains(String producto){
        foreach (DataGridViewRow row in ProductosCanjear.Rows){
        if (row.Cells["col_producto_canjear"].Value.ToString().Equals(producto)){
        return true;
        }}
        return false;
        }

        private void aumentarYRestar(String producto) {

            productosDisponibles.Rows[indexProducto(productosDisponibles, "col_producto", producto)].Cells["col_stock"].Value =
                    Convert.ToDecimal(productosDisponibles.Rows[indexProducto(productosDisponibles,"col_producto", producto)].Cells["col_stock"].Value) - 1;
            if (contains(producto))
            {
                ProductosCanjear.Rows[indexProducto(ProductosCanjear, "col_producto_canjear", producto)].Cells["col_cantidad"].Value =
                    Convert.ToDecimal(ProductosCanjear.Rows[indexProducto(ProductosCanjear, "col_producto_canjear", producto)].Cells["col_cantidad"].Value) + 1;
                return;
                    
            }

            ProductosCanjear.Rows.Add(currentProducto(productosDisponibles, "col_producto"), 1);
        
        }

        private int indexProducto(DataGridView dg, String col, String producto) {
            foreach (DataGridViewRow row in dg.Rows) { 
            if (row.Cells[col].Value.ToString().Equals(producto)){
                return row.Index;
            }
        
            }
            return -1;
        }

        private void DNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
        }

        private void Canje_Millas_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload() {

            tipoDNI.Enabled = true;
            DNI.ReadOnly = false;
            tipoDNI.SelectedIndex = -1;
            DNI.clean();
            millasQueTiene.Text = "";
            ProductosCanjear.clean();
            sumaParcialCanjes.Text = "0";
            DAO.DAOProductos.getProductos(productosDisponibles);
            Agregar.Enabled = false;
            Cancelar.Enabled = false;
            RealizarCanjes.Enabled = false;
        }

    }
}

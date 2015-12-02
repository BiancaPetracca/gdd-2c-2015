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
using AerolineaFrba.DAO;
using AerolineaFrba.SuperControls;

namespace AerolineaFrba.Compra
{
    public partial class Efectuar_Compra : Form
    {
        public Efectuar_Compra()
        {
            InitializeComponent();
        }
        public Model.Compra compra { get; set; }
        public Model.Cliente cliente { get; set; }
        public Efectuar_Compra(Model.Compra compra)
        {
            InitializeComponent();
            this.compra = compra;
        }
        

        private void Efectuar_Compra_Load(object sender, EventArgs e)
        {

            datosPersonales.Rows.Add();

            if (Config.Terminal == 1)
            {
                this.MedioPago.SelectedItem = "Tarjeta";
                this.MedioPago.Enabled = false;
            }
        }

        private void MedioPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MedioPago.SelectedIndex != -1 && MedioPago.value == "Efectivo")
            {
                enableAll(false);
            }
            else { enableAll(true);
            }
  }


        private void datosPersonales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (datosPersonales.CurrentRow != null || datosPersonales.CurrentCell != null)
            {
                if (datosPersonales.cellValue("col_dni") != null && datosPersonales.cellValue("col_tipo_doc") != null)
                {
                    String dni = datosPersonales.cellValue("col_dni").ToString();
                    String tipoDNI = datosPersonales.cellValue("col_tipo_doc").ToString();
                    if (e.ColumnIndex == 1 && DAO.DAOCliente.existeCliente(tipoDNI, dni))

                        DAO.DAOCliente.completarDatos(tipoDNI, dni, datosPersonales);
                }
                if (datosPersonales.CurrentRow.Cells["col_fecha_nac"] != null && e.ColumnIndex == datosPersonales.CurrentRow.Cells["col_fecha_nac"].ColumnIndex)
                {
                    DateTime date;


                    if (!DateTime.TryParse(Convert.ToString(datosPersonales.CurrentRow.Cells["col_fecha_nac"].Value), out date))
                    {
                        MessageBox.Show("no es un formato valido");
                        return;
                    }
                    datosPersonales.CurrentRow.Cells["col_fecha_nac"].Value = date.ToShortDateString();



                }
            }

            else { return; }

        }
      
    


        private void enableAll(Boolean val)
        {
            foreach (Control ctr in datosTarjeta.Controls)
            {
                ctr.Enabled = val;
            }
         
            datosTarjeta.Enabled = val;
        }

        private void TipoTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cuotas.Maximum = DAO.DAOCompra.cuotasMaximasTarjeta(TipoTarjeta.value);
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (datosPersonales.anyEmptyCells()) { MessageBox.Show("Inserte sus datos"); return; }
       cliente = getCurrentCliente();
       cliente.Codigo = DAO.DAOCliente.updateCliente(cliente);
      
            Decimal TarjetaID;
            if (MedioPago.value == "Efectivo")
            {
                DAO.DAOCompra.efectuarCompra(cliente, compra.codigo, 0, 1);
                this.openInNewWindow(new Exito_Efectivo(compra.codigo, this));
                return;
            }
         
            TarjetaID = DAO.DAOCliente.clienteTieneTarjeta(cliente, TipoTarjeta.value, NumeroTarjeta.value, CodigoSeguridad.value,
                FechaExpiracion.value);
            if(TarjetaID != -1)
            {
                
                DAO.DAOCompra.efectuarCompra(cliente, compra.codigo, DAO.DAOCompra.getTipoPago(TipoTarjeta.value), Cuotas.value);
                this.openInNewWindow(new Exito_Tarjeta(compra.codigo, this));
                return;
            }
            if (MessageBox.Show("Los datos de la tarjeta no coinciden. Desea registrar esta tarjeta a su nombre?", "Confirmar tarjeta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TarjetaID = DAO.DAOCliente.nuevaTarjeta(cliente, TipoTarjeta.value, NumeroTarjeta.value, CodigoSeguridad.value, FechaExpiracion.value);
             
                DAO.DAOCompra.efectuarCompra(cliente, compra.codigo, DAO.DAOCompra.getTipoPago(TipoTarjeta.value), Cuotas.value);
                this.openInNewWindow(new Exito_Tarjeta(compra.codigo, this));
                return;
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            DAO.DAOCompra.cancelarCompra(compra.codigo);
            MessageBox.Show("Compra cancelada!");
            this.Close();
        }

        private Model.Cliente getCurrentCliente() {
            return new Model.Cliente(cellValue("col_tipo_doc"), Convert.ToDecimal(cellValue("col_DNI")), cellValue("col_nombre"), cellValue("col_apellido"),
                cellValue("col_direccion"), cellValue("col_mail"), Convert.ToDecimal(cellValue("col_telefono")),Convert.ToDateTime(cellValue("col_fecha_nac")));
   }

        private String cellValue(String col) {

           return Convert.ToString(datosPersonales.Rows[0].Cells[col].Value);
        }

        private void CambiarTarjeta_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NumeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
        }

        private void CodigoSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowNumericOnly(e);
        }

    }
}
// si el cliente es nuevo, se registra esa nueva tarjeta. si el cliente es viejo se fija que coincida con la que puso sino la cambia
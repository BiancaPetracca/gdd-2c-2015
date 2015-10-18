using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AerolineaFrba.Abm_Ruta
{
    public partial class Alta : Validaciones
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try { validarCampos(); }
            catch (Exception excepcion)
            {
                show(excepcion);
            }
        }

        private void validarCampos()
        {
                var invalidos = validate(this.Codigo) + validate(this.Servicio) +
                validate(this.Origen) +
                validate(this.Destino);

            if(invalidos != String.Empty){
                throw new Exception(invalidos);
            }
    
      
           /* if (this.Origen.SelectedIndex == -1 || this.Destino.SelectedIndex == -1)
            {
                ciudad = "Elija una ciudad \n";
            }
            if (this.PrecioPasaje.Value == 0 || this.PrecioKG.Value == 0) {
                precio = "Asigne un precio \n";
            }
           */
            
        }
    }
}

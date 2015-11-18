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

namespace AerolineaFrba.Abm_Rol
{
    public partial class RolListado : Form
    {
        public RolListado()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
           this.openInNewWindow(new Alta(this));
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void RolListado_Load(object sender, EventArgs e)
        {
            this.reload();
        }

        private void modificar_Click(object sender, EventArgs e){


            this.openInNewWindow(new Abm_Rol.Modificacion(this, getCurrentRol()));

        }
    private Model.Rol getCurrentRol(){
        return new Model.Rol((String)Extensions.cellValue(this.ListadoRoles, "col_rol"), Convert.ToBoolean(Extensions.cellValue(this.ListadoRoles, "col_habilitado")));
    }

    public void reload() {
        DAO.DAORol.getAllRoles(this.ListadoRoles);
    }
     }
}

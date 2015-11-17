using AerolineaFrba.Generics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class Modificacion : Form
    {
        public Model.Rol rol { get; set;}
        public Abm_Rol.RolListado launcher { get; set; }

        public Modificacion()
        {
            InitializeComponent();
        }

        public Modificacion(Abm_Rol.RolListado launcher, Model.Rol rol)
        {
            InitializeComponent();
            this.launcher = launcher;
            this.rol = rol;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
                DAO.DAORol.agregarFuncionalidad(rol, FuncionalidadSeleccion.SelectedItem.ToString());
                this.reload();
            
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            launcher.reload();
            this.Close();
        }


        private void Modificacion_Load(object sender, EventArgs e)
        {
            this.reload();
        }

        public void reload()
        {
            this.Nombre.Text = rol.nombre;
            this.Estado.Checked = rol.habilitado;
            this.FuncionalidadSeleccion.Items.Clear();
            this.FuncionalidadSeleccion.AddAll(DAO.DAORol.getFuncionalidadesQueNoTiene(rol));
            DAO.DAORol.getFuncionalidadesRol(rol, this.FuncionalidadesRol);
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            DAO.DAORol.eliminarFuncionalidad(rol, (String)Extensions.cellValue(this.FuncionalidadesRol, "col_funcionalidades"));
            this.reload();
        }

        private void Estado_CheckedChanged(object sender, EventArgs e)
        {
            rol.habilitado = this.Estado.Checked;
            DAO.DAORol.cambiarEstadoRol(rol);
        }

        private void cambiarNombre_Click(object sender, EventArgs e)
        {
            if (DAO.DAORol.yaExisteRol(this.Nombre.Text) == 1) { MessageBox.Show("El nombre del rol ya existe, elija otro"); return; }
            DAO.DAORol.modificarNombreRol(rol, this.Nombre.Text);
            rol.nombre = this.Nombre.Text;
        }


    }
}

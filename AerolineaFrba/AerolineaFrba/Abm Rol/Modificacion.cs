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
            if (FuncionalidadSeleccion.valid())
            {
                DAO.DAORol.agregarFuncionalidad(rol, FuncionalidadSeleccion.SelectedItem.ToString());
                this.reload();
                reloadMenu();
                

            }
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
            if (FuncionalidadesRol.SelectedRows.Count != 0 || FuncionalidadesRol.SelectedCells.Count != 0)
            {
                Decimal idFuncionalidad = Convert.ToDecimal(Extensions.cellValue(FuncionalidadesRol, "col_id"));
                if (idFuncionalidad == 1 && rol.id == launcher.rol) { MessageBox.Show("No puede eliminar la funcionalidad de ABM de rol porque se encuentra en ella, y en su propio rol"); return; }

                DAO.DAORol.eliminarFuncionalidad(rol, (String)Extensions.cellValue(this.FuncionalidadesRol, "col_funcionalidades"));
                this.reload();
                reloadMenu();
                return;
            }
            MessageBox.Show("Seleccione una funcionalidad");

        }

        private void reloadMenu() {
            MainMenu menu = (MainMenu)launcher.MdiParent;
            menu.funcionalidades = DAO.DAORol.getIdFuncionalidades(launcher.rol);
            menu.reload();
        }
        private void Estado_CheckedChanged(object sender, EventArgs e)
        {
            Decimal idFuncionalidad = Convert.ToDecimal(Extensions.cellValue(FuncionalidadesRol, "col_id"));
            if (idFuncionalidad == 1 && rol.id == launcher.rol) { MessageBox.Show("No puede inhabilitarse a sí mismo!"); return; }

            rol.habilitado = this.Estado.Checked;
            DAO.DAORol.cambiarEstadoRol(rol);
        }

        private void cambiarNombre_Click(object sender, EventArgs e)
        {
            if (DAO.DAORol.yaExisteRol(this.Nombre.Text) == 1) { MessageBox.Show("El nombre del rol ya existe, elija otro"); return; }
            DAO.DAORol.modificarNombreRol(rol, this.Nombre.Text);
            rol.nombre = this.Nombre.Text;
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
        }


    }
}

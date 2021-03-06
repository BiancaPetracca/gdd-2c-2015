﻿using System;
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
        public RolListado(Decimal rol)
        {
           
            InitializeComponent();
            this.rol = rol;
        }

        public Decimal rol { get; set; }

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
            if (ListadoRoles.Rows.Count > 0)
            {
                this.openInNewWindow(new Abm_Rol.Modificacion(this, getCurrentRol()));
            }
        }
    public Model.Rol getCurrentRol(){
        return new Model.Rol(Convert.ToDecimal(Extensions.cellValue(ListadoRoles, "col_id")),
            Convert.ToString(Extensions.cellValue(this.ListadoRoles, "col_rol")),
            Convert.ToBoolean(Extensions.cellValue(this.ListadoRoles, "col_habilitado")));
    }

    public void reload() {
        DAO.DAORol.getAllRoles(ListadoRoles);
    }
     }
}

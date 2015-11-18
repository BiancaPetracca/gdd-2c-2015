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
using AerolineaFrba.DAO;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Ruta : Form
    {
        public Ruta()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.openInNewWindow(new Alta(this));
        }


        private void Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {

        }



        private void Ruta_Load(object sender, EventArgs e)
        {
            DAO.DAORuta.getRutas(this.lista);
        }

        public void reload() {
            DAO.DAORuta.getRutas(this.lista);
        }

        private void darDeBaja_Click(object sender, EventArgs e)
        {
            DAO.DAORuta.darDeBaja(this.getCurrentRuta());
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            Model.Ruta ruta = this.getCurrentRuta();
            ruta.Codigo = Convert.ToUInt16(Extensions.cellValue(this.lista, "col_codigo"));
            
            // abro una form de modificacion y mando a este form para que pueda hacer un reload luego cuando modifica
            this.openInNewWindow(new Modificacion(ruta, this));

        }

        private Model.Ruta getCurrentRuta()
        {
            return new Model.Ruta((String)Extensions.cellValue(this.lista, "col_origen"),
             (String)Extensions.cellValue(this.lista, "col_destino"),
             (Boolean)Extensions.cellValue(this.lista, "col_habilitada"),
             (String)Extensions.cellValue(this.lista, "col_servicio"),
             Convert.ToDecimal(Extensions.cellValue(this.lista, "col_pb_kg")),
             Convert.ToDecimal(Extensions.cellValue(this.lista, "col_pb_pasaje")));
            

        }
    }
}
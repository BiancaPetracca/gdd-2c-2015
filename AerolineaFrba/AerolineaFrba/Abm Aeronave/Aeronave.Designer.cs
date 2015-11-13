﻿using AerolineaFrba.SuperControls;
namespace AerolineaFrba.Abm_Aeronave
{
    partial class Aeronave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.VerButacas = new AerolineaFrba.SuperControls.SuperButton();
            this.Modificar = new AerolineaFrba.SuperControls.SuperButton();
            this.Cerrar = new AerolineaFrba.SuperControls.SuperButton();
            this.filtros = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.HabilitadasFiltro = new AerolineaFrba.SuperControls.SuperCheckBox();
            this.label1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.ServicioFiltro = new AerolineaFrba.SuperControls.SuperComboBox();
            this.limpiar = new AerolineaFrba.SuperControls.SuperButton();
            this.buscar = new AerolineaFrba.SuperControls.SuperButton();
            this.Borrar = new AerolineaFrba.SuperControls.SuperButton();
            this.Agregar = new AerolineaFrba.SuperControls.SuperButton();
            this.lista = new System.Windows.Forms.DataGridView();
            this.scroll_ = new System.Windows.Forms.ScrollableControl();
            this.col_matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_butacas_pasillo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_butacas_vent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_kgs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vidautil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_fechabaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fechareinicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox.SuspendLayout();
            this.filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.lista.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.AutoSize = true;
            this.groupBox.Controls.Add(this.VerButacas);
            this.groupBox.Controls.Add(this.Modificar);
            this.groupBox.Controls.Add(this.Cerrar);
            this.groupBox.Controls.Add(this.filtros);
            this.groupBox.Controls.Add(this.Borrar);
            this.groupBox.Controls.Add(this.Agregar);
            this.groupBox.Controls.Add(this.lista);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1099, 468);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Aeronaves";
            // 
            // VerButacas
            // 
            this.VerButacas.Location = new System.Drawing.Point(650, 408);
            this.VerButacas.Name = "VerButacas";
            this.VerButacas.Size = new System.Drawing.Size(75, 23);
            this.VerButacas.TabIndex = 8;
            this.VerButacas.Text = "Ver butacas";
            this.VerButacas.UseVisualStyleBackColor = true;
            this.VerButacas.Click += new System.EventHandler(this.VerButacas_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(916, 408);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 7;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(1003, 408);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 6;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // filtros
            // 
            this.filtros.Controls.Add(this.HabilitadasFiltro);
            this.filtros.Controls.Add(this.label1);
            this.filtros.Controls.Add(this.ServicioFiltro);
            this.filtros.Controls.Add(this.limpiar);
            this.filtros.Controls.Add(this.buscar);
            this.filtros.Location = new System.Drawing.Point(16, 19);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(1062, 78);
            this.filtros.TabIndex = 5;
            this.filtros.TabStop = false;
            this.filtros.Text = "Filtros";
            // 
            // HabilitadasFiltro
            // 
            this.HabilitadasFiltro.AccessibleDescription = "Habilitado o no ";
            this.HabilitadasFiltro.AutoSize = true;
            this.HabilitadasFiltro.Location = new System.Drawing.Point(59, 31);
            this.HabilitadasFiltro.Name = "HabilitadasFiltro";
            this.HabilitadasFiltro.Size = new System.Drawing.Size(100, 17);
            this.HabilitadasFiltro.TabIndex = 13;
            this.HabilitadasFiltro.Text = "Sólo habilitadas";
            this.HabilitadasFiltro.UseVisualStyleBackColor = true;
            this.HabilitadasFiltro.CheckedChanged += new System.EventHandler(this.HabilitadasFiltro_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(279, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Servicio";
            // 
            // ServicioFiltro
            // 
            this.ServicioFiltro.AccessibleDescription = "Tipo de servicio";
            this.ServicioFiltro.Items.AddRange(new object[] {
            "Ejecutivo",
            "Turista",
            "Primera Clase"});
            this.ServicioFiltro.Location = new System.Drawing.Point(358, 27);
            this.ServicioFiltro.Name = "ServicioFiltro";
            this.ServicioFiltro.Size = new System.Drawing.Size(219, 21);
            this.ServicioFiltro.TabIndex = 5;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(768, 26);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 6;
            this.limpiar.Text = "Limpiar";
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(662, 26);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 7;
            this.buscar.Text = "Buscar";
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(826, 408);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 1;
            this.Borrar.Text = "Dar de baja";
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(736, 408);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 2;
            this.Agregar.Text = "Agregar";
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // lista
            // 
            this.lista.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            this.lista.AllowUserToResizeRows = false;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_matricula,
            this.col_fabricante,
            this.col_butacas_pasillo,
            this.col_butacas_vent,
            this.col_kgs,
            this.col_vidautil,
            this.col_estado,
            this.col_fechabaja,
            this.col_fechareinicio,
            this.col_servicio});
            this.lista.Controls.Add(this.scroll_);
            this.lista.Location = new System.Drawing.Point(16, 112);
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.Size = new System.Drawing.Size(1062, 276);
            this.lista.TabIndex = 5;
            this.lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_CellContentClick);
            // 
            // scroll_
            // 
            this.scroll_.Location = new System.Drawing.Point(0, 0);
            this.scroll_.Name = "scroll_";
            this.scroll_.Size = new System.Drawing.Size(0, 0);
            this.scroll_.TabIndex = 2;
            // 
            // col_matricula
            // 
            this.col_matricula.HeaderText = "Matrícula";
            this.col_matricula.Name = "col_matricula";
            this.col_matricula.ReadOnly = true;
            // 
            // col_fabricante
            // 
            this.col_fabricante.HeaderText = "Fabricante";
            this.col_fabricante.Name = "col_fabricante";
            this.col_fabricante.ReadOnly = true;
            // 
            // col_butacas_pasillo
            // 
            this.col_butacas_pasillo.HeaderText = "Butacas Pasillo";
            this.col_butacas_pasillo.Name = "col_butacas_pasillo";
            this.col_butacas_pasillo.ReadOnly = true;
            // 
            // col_butacas_vent
            // 
            this.col_butacas_vent.HeaderText = "Butacas Ventanilla";
            this.col_butacas_vent.Name = "col_butacas_vent";
            this.col_butacas_vent.ReadOnly = true;
            // 
            // col_kgs
            // 
            this.col_kgs.HeaderText = "Kgs. Encomienda";
            this.col_kgs.Name = "col_kgs";
            this.col_kgs.ReadOnly = true;
            // 
            // col_vidautil
            // 
            this.col_vidautil.HeaderText = "Vida Útil";
            this.col_vidautil.Name = "col_vidautil";
            this.col_vidautil.ReadOnly = true;
            // 
            // col_estado
            // 
            this.col_estado.DataPropertyName = "aero_estado";
            this.col_estado.HeaderText = "Habilitada";
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;
            this.col_estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_fechabaja
            // 
            this.col_fechabaja.HeaderText = "Fecha de baja";
            this.col_fechabaja.Name = "col_fechabaja";
            this.col_fechabaja.ReadOnly = true;
            // 
            // col_fechareinicio
            // 
            this.col_fechareinicio.DataPropertyName = "aero_fecha_reinicio_servicio";
            this.col_fechareinicio.HeaderText = "Fecha reinicio";
            this.col_fechareinicio.Name = "col_fechareinicio";
            this.col_fechareinicio.ReadOnly = true;
            // 
            // col_servicio
            // 
            this.col_servicio.DataPropertyName = "aero_servicio";
            this.col_servicio.HeaderText = "Servicio";
            this.col_servicio.Name = "col_servicio";
            this.col_servicio.ReadOnly = true;
            // 
            // Aeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1123, 502);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aeronave";
            this.Text = "Aeronave";
            this.Load += new System.EventHandler(this.Aeronave_Load);
            this.groupBox.ResumeLayout(false);
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.lista.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridCell listado;
        private SuperGroupBox groupBox;
        private SuperComboBox ServicioFiltro; 
        private SuperGroupBox filtros;

        private SuperButton limpiar;
        private SuperButton buscar;
 

        private SuperButton Agregar;
        private SuperButton Borrar;

        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.ScrollableControl scroll_;
        private SuperLabel label1;
        private SuperButton Cerrar;

        private SuperButton VerButacas;
        private SuperButton Modificar;
        private SuperCheckBox HabilitadasFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_butacas_pasillo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_butacas_vent;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vidautil;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fechabaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fechareinicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_servicio;

    }
}
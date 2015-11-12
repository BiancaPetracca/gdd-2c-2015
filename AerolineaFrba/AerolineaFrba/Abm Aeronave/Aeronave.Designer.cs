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
            this.Agregar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.VerButacas = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.filtros = new System.Windows.Forms.GroupBox();
            this.HabilitadasFiltro = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServicioFiltro = new System.Windows.Forms.ComboBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.DataGridView();
            this.scroll_ = new System.Windows.Forms.ScrollableControl();
            this.col_matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_butacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(604, 394);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 2;
            this.Agregar.Text = "Agregar";
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(694, 394);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 1;
            this.Borrar.Text = "Dar de baja";
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
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
            this.groupBox.Size = new System.Drawing.Size(976, 436);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Aeronaves";
            // 
            // VerButacas
            // 
            this.VerButacas.Location = new System.Drawing.Point(518, 394);
            this.VerButacas.Name = "VerButacas";
            this.VerButacas.Size = new System.Drawing.Size(75, 23);
            this.VerButacas.TabIndex = 8;
            this.VerButacas.Text = "Ver butacas";
            this.VerButacas.UseVisualStyleBackColor = true;
            this.VerButacas.Click += new System.EventHandler(this.VerButacas_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(784, 394);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 7;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(871, 394);
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
            this.filtros.Size = new System.Drawing.Size(930, 76);
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
            this.limpiar.Location = new System.Drawing.Point(768, 28);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 6;
            this.limpiar.Text = "Limpiar";
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(662, 31);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 7;
            this.buscar.Text = "Buscar";
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
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
            this.col_butacas,
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
            this.lista.Size = new System.Drawing.Size(930, 262);
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
            // col_butacas
            // 
            this.col_butacas.HeaderText = "Butacas";
            this.col_butacas.Name = "col_butacas";
            this.col_butacas.ReadOnly = true;
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
            this.ClientSize = new System.Drawing.Size(1000, 500);
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
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox ServicioFiltro; 
        private System.Windows.Forms.GroupBox filtros;

        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button buscar;
 

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Borrar;

        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.ScrollableControl scroll_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cerrar;

        private System.Windows.Forms.Button VerButacas;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.CheckBox HabilitadasFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_butacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vidautil;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fechabaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fechareinicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_servicio;

    }
}
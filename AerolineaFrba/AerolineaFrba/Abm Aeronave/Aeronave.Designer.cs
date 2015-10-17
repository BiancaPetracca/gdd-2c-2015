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
            this.components = new System.ComponentModel.Container();
            this.agregar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.verButacas = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.filtros = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtro2 = new System.Windows.Forms.Label();
            this.seleccionar2 = new System.Windows.Forms.TextBox();
            this.buscador = new System.Windows.Forms.TextBox();
            this.buscadorExacto = new System.Windows.Forms.TextBox();
            this.combo = new System.Windows.Forms.ComboBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.seleccionar = new System.Windows.Forms.Button();
            this.filtro1 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scroll_ = new System.Windows.Forms.ScrollableControl();
            this.gD2C2015DataSet = new AerolineaFrba.GD2C2015DataSet();
            this.maestraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maestraTableAdapter = new AerolineaFrba.GD2C2015DataSetTableAdapters.MaestraTableAdapter();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox.SuspendLayout();
            this.filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(604, 394);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Agregar";
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(694, 394);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(75, 23);
            this.borrar.TabIndex = 1;
            this.borrar.Text = "Dar de baja";
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // groupBox
            // 
            this.groupBox.AutoSize = true;
            this.groupBox.Controls.Add(this.verButacas);
            this.groupBox.Controls.Add(this.Modificar);
            this.groupBox.Controls.Add(this.button1);
            this.groupBox.Controls.Add(this.filtros);
            this.groupBox.Controls.Add(this.borrar);
            this.groupBox.Controls.Add(this.agregar);
            this.groupBox.Controls.Add(this.lista);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(976, 436);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Aeronaves";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // verButacas
            // 
            this.verButacas.Location = new System.Drawing.Point(518, 394);
            this.verButacas.Name = "verButacas";
            this.verButacas.Size = new System.Drawing.Size(75, 23);
            this.verButacas.TabIndex = 8;
            this.verButacas.Text = "Ver butacas";
            this.verButacas.UseVisualStyleBackColor = true;
            this.verButacas.Click += new System.EventHandler(this.verButacas_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(784, 394);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 7;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cerrar";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filtros
            // 
            this.filtros.Controls.Add(this.label1);
            this.filtros.Controls.Add(this.filtro2);
            this.filtros.Controls.Add(this.seleccionar2);
            this.filtros.Controls.Add(this.buscador);
            this.filtros.Controls.Add(this.buscadorExacto);
            this.filtros.Controls.Add(this.combo);
            this.filtros.Controls.Add(this.limpiar);
            this.filtros.Controls.Add(this.buscar);
            this.filtros.Controls.Add(this.seleccionar);
            this.filtros.Controls.Add(this.filtro1);
            this.filtros.Location = new System.Drawing.Point(16, 19);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(930, 116);
            this.filtros.TabIndex = 5;
            this.filtros.TabStop = false;
            this.filtros.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(377, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Servicio";
            // 
            // filtro2
            // 
            this.filtro2.Location = new System.Drawing.Point(57, 31);
            this.filtro2.Name = "filtro2";
            this.filtro2.Size = new System.Drawing.Size(100, 23);
            this.filtro2.TabIndex = 11;
            this.filtro2.Text = "Nombre exacto";
            // 
            // seleccionar2
            // 
            this.seleccionar2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.seleccionar2.Location = new System.Drawing.Point(456, 70);
            this.seleccionar2.Name = "seleccionar2";
            this.seleccionar2.ReadOnly = true;
            this.seleccionar2.Size = new System.Drawing.Size(121, 20);
            this.seleccionar2.TabIndex = 9;
            // 
            // buscador
            // 
            this.buscador.Location = new System.Drawing.Point(163, 70);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(161, 20);
            this.buscador.TabIndex = 0;
            // 
            // buscadorExacto
            // 
            this.buscadorExacto.Location = new System.Drawing.Point(163, 28);
            this.buscadorExacto.MaxLength = 255;
            this.buscadorExacto.Name = "buscadorExacto";
            this.buscadorExacto.Size = new System.Drawing.Size(161, 20);
            this.buscadorExacto.TabIndex = 1;
            this.buscadorExacto.TextChanged += new System.EventHandler(this.buscadorExacto_TextChanged);
            // 
            // combo
            // 
            this.combo.Location = new System.Drawing.Point(456, 27);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(219, 21);
            this.combo.TabIndex = 5;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(768, 28);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 6;
            this.limpiar.Text = "Limpiar";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(768, 68);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 7;
            this.buscar.Text = "Buscar";
            // 
            // seleccionar
            // 
            this.seleccionar.Location = new System.Drawing.Point(600, 68);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(75, 23);
            this.seleccionar.TabIndex = 8;
            this.seleccionar.Text = "Seleccionar";
            // 
            // filtro1
            // 
            this.filtro1.Location = new System.Drawing.Point(57, 73);
            this.filtro1.Name = "filtro1";
            this.filtro1.Size = new System.Drawing.Size(100, 23);
            this.filtro1.TabIndex = 10;
            this.filtro1.Text = "Por clave";
            // 
            // lista
            // 
            this.lista.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            this.lista.AllowUserToResizeRows = false;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column6,
            this.Servicio});
            this.lista.Controls.Add(this.scroll_);
            this.lista.Location = new System.Drawing.Point(16, 153);
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.Size = new System.Drawing.Size(930, 221);
            this.lista.TabIndex = 5;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Matrícula";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fabricante";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Butacas";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Kgs. Encomienda";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Vida Útil";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estado";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Fecha de baja";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha reinicio";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // scroll_
            // 
            this.scroll_.Location = new System.Drawing.Point(0, 0);
            this.scroll_.Name = "scroll_";
            this.scroll_.Size = new System.Drawing.Size(0, 0);
            this.scroll_.TabIndex = 2;
            // 
            // gD2C2015DataSet
            // 
            this.gD2C2015DataSet.DataSetName = "GD2C2015DataSet";
            this.gD2C2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maestraBindingSource
            // 
            this.maestraBindingSource.DataMember = "Maestra";
            this.maestraBindingSource.DataSource = this.gD2C2015DataSet;
            // 
            // maestraTableAdapter
            // 
            this.maestraTableAdapter.ClearBeforeFill = true;
            // 
            // Servicio
            // 
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
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
            this.groupBox.ResumeLayout(false);
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridCell listado;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox buscador;
        private System.Windows.Forms.TextBox buscadorExacto;
        private System.Windows.Forms.ComboBox combo; 
        private System.Windows.Forms.GroupBox filtros;

        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button buscar;

        private System.Windows.Forms.Button seleccionar;
        private System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1;

        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button borrar;

        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.TextBox seleccionar2;
        private System.Windows.Forms.Label filtro1;
        private System.Windows.Forms.Label filtro2;
        private System.Windows.Forms.ScrollableControl scroll_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource maestraBindingSource;
        private GD2C2015DataSetTableAdapters.MaestraTableAdapter maestraTableAdapter;
        private System.Windows.Forms.Button verButacas;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;

    }
}
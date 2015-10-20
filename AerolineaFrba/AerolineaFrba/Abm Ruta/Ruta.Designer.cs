namespace AerolineaFrba.Abm_Ruta
{
    partial class Ruta
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Cerrar = new System.Windows.Forms.Button();
            this.filtros = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtro2 = new System.Windows.Forms.Label();
            this.seleccionar2 = new System.Windows.Forms.TextBox();
            this.buscador = new System.Windows.Forms.TextBox();
            this.buscadorExacto = new System.Windows.Forms.TextBox();
            this.combo = new System.Windows.Forms.ComboBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.Button();
            this.filtro1 = new System.Windows.Forms.Label();
            this.Borrar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox.SuspendLayout();
            this.filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.Cerrar);
            this.groupBox.Controls.Add(this.filtros);
            this.groupBox.Controls.Add(this.Borrar);
            this.groupBox.Controls.Add(this.Agregar);
            this.groupBox.Controls.Add(this.Modificar);
            this.groupBox.Controls.Add(this.lista);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(942, 428);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Rutas";
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(826, 388);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 6;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // filtros
            // 
            this.filtros.Controls.Add(this.label1);
            this.filtros.Controls.Add(this.filtro2);
            this.filtros.Controls.Add(this.seleccionar2);
            this.filtros.Controls.Add(this.buscador);
            this.filtros.Controls.Add(this.buscadorExacto);
            this.filtros.Controls.Add(this.combo);
            this.filtros.Controls.Add(this.Limpiar);
            this.filtros.Controls.Add(this.Buscar);
            this.filtros.Controls.Add(this.Seleccionar);
            this.filtros.Controls.Add(this.filtro1);
            this.filtros.Location = new System.Drawing.Point(16, 19);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(885, 166);
            this.filtros.TabIndex = 5;
            this.filtros.TabStop = false;
            this.filtros.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(473, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Opciones";
            // 
            // filtro2
            // 
            this.filtro2.Location = new System.Drawing.Point(6, 37);
            this.filtro2.Name = "filtro2";
            this.filtro2.Size = new System.Drawing.Size(100, 23);
            this.filtro2.TabIndex = 11;
            this.filtro2.Text = "Nombre exacto";
            // 
            // seleccionar2
            // 
            this.seleccionar2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.seleccionar2.Location = new System.Drawing.Point(552, 76);
            this.seleccionar2.Name = "seleccionar2";
            this.seleccionar2.ReadOnly = true;
            this.seleccionar2.Size = new System.Drawing.Size(121, 20);
            this.seleccionar2.TabIndex = 9;
            // 
            // buscador
            // 
            this.buscador.Location = new System.Drawing.Point(112, 83);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(161, 20);
            this.buscador.TabIndex = 0;
            // 
            // buscadorExacto
            // 
            this.buscadorExacto.Location = new System.Drawing.Point(112, 34);
            this.buscadorExacto.Name = "buscadorExacto";
            this.buscadorExacto.Size = new System.Drawing.Size(161, 20);
            this.buscadorExacto.TabIndex = 1;
            // 
            // combo
            // 
            this.combo.Location = new System.Drawing.Point(552, 27);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(219, 21);
            this.combo.TabIndex = 5;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(598, 118);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 6;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(696, 118);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 7;
            this.Buscar.Text = "Buscar";
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Seleccionar
            // 
            this.Seleccionar.Location = new System.Drawing.Point(696, 74);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.Seleccionar.TabIndex = 8;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // filtro1
            // 
            this.filtro1.Location = new System.Drawing.Point(6, 86);
            this.filtro1.Name = "filtro1";
            this.filtro1.Size = new System.Drawing.Size(100, 23);
            this.filtro1.TabIndex = 10;
            this.filtro1.Text = "Por clave";
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(546, 388);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 1;
            this.Borrar.Text = "Borrar";
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(636, 388);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 2;
            this.Agregar.Text = "Agregar";
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(732, 388);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 3;
            this.Modificar.Text = "Modificar";
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // lista
            // 
            this.lista.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.lista.Location = new System.Drawing.Point(16, 205);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(885, 167);
            this.lista.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Servicio";
            this.Column2.Items.AddRange(new object[] {
            "Turista",
            "Ejecutivo",
            "Primera Clase"});
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ciudad Origen";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ciudad Destino";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio Base por KG";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Precio Base por Pasaje";
            this.Column6.Name = "Column6";
            // 
            // Ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 452);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ruta";
            this.Text = "Ruta";
            this.groupBox.ResumeLayout(false);
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox filtros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label filtro2;
        private System.Windows.Forms.TextBox seleccionar2;
        private System.Windows.Forms.TextBox buscador;
        private System.Windows.Forms.TextBox buscadorExacto;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Seleccionar;
        private System.Windows.Forms.Label filtro1;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button Cerrar;
    }
}
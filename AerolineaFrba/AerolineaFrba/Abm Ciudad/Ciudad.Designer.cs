namespace AerolineaFrba.Abm_Ciudad
{
    partial class Ciudad
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
            this.filtro2 = new System.Windows.Forms.Label();
            this.buscador = new System.Windows.Forms.TextBox();
            this.buscadorExacto = new System.Windows.Forms.TextBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.filtro1 = new System.Windows.Forms.Label();
            this.borrar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox.SuspendLayout();
            this.filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.Cerrar);
            this.groupBox.Controls.Add(this.filtros);
            this.groupBox.Controls.Add(this.borrar);
            this.groupBox.Controls.Add(this.agregar);
            this.groupBox.Controls.Add(this.lista);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(976, 436);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ciudades";
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(794, 391);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 6;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);

            // 
            // filtros
            // 
            this.filtros.Controls.Add(this.filtro2);
            this.filtros.Controls.Add(this.buscador);
            this.filtros.Controls.Add(this.buscadorExacto);
            this.filtros.Controls.Add(this.limpiar);
            this.filtros.Controls.Add(this.buscar);
            this.filtros.Controls.Add(this.filtro1);
            this.filtros.Location = new System.Drawing.Point(16, 19);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(853, 128);
            this.filtros.TabIndex = 5;
            this.filtros.TabStop = false;
            this.filtros.Text = "Filtros";
            // 
            // filtro2
            // 
            this.filtro2.Location = new System.Drawing.Point(6, 37);
            this.filtro2.Name = "filtro2";
            this.filtro2.Size = new System.Drawing.Size(100, 23);
            this.filtro2.TabIndex = 11;
            this.filtro2.Text = "Nombre exacto";
            // 
            // buscador
            // 
            this.buscador.Location = new System.Drawing.Point(510, 31);
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
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(625, 80);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 6;
            this.limpiar.Text = "Limpiar";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(746, 80);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 7;
            this.buscar.Text = "Buscar";
            // 
            // filtro1
            // 
            this.filtro1.Location = new System.Drawing.Point(404, 34);
            this.filtro1.Name = "filtro1";
            this.filtro1.Size = new System.Drawing.Size(100, 23);
            this.filtro1.TabIndex = 10;
            this.filtro1.Text = "Por clave";
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(604, 391);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(75, 23);
            this.borrar.TabIndex = 1;
            this.borrar.Text = "Borrar";
            this.borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(700, 391);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Agregar";
            this.agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // lista
            // 
            this.lista.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Nombre,
            this.Column1});
            this.lista.Location = new System.Drawing.Point(16, 166);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(853, 208);
            this.lista.TabIndex = 5;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Código";
            this.Column2.Name = "Column2";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.FillWeight = 200F;
            this.Nombre.HeaderText = "Ciudad";
            this.Nombre.Name = "Nombre";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Modificar";
            this.Column1.Name = "Column1";
            // 
            // Ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ciudad";
            this.Text = "Ciudades";
            this.groupBox.ResumeLayout(false);
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox filtros;
        private System.Windows.Forms.Label filtro2;
        private System.Windows.Forms.TextBox buscador;
        private System.Windows.Forms.TextBox buscadorExacto;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Label filtro1;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}
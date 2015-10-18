namespace AerolineaFrba.ABM_Templates
{
    partial class Listado_temp
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
            this.agregar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scroll_ = new System.Windows.Forms.ScrollableControl();
            this.groupBox.SuspendLayout();
            this.filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.lista.SuspendLayout();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(492, 393);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Agregar";
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(402, 393);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(75, 23);
            this.borrar.TabIndex = 1;
            this.borrar.Text = "Borrar";
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(588, 393);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 3;
            this.modificar.Text = "Modificar";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.filtros);
            this.groupBox.Controls.Add(this.borrar);
            this.groupBox.Controls.Add(this.agregar);
            this.groupBox.Controls.Add(this.modificar);
            this.groupBox.Controls.Add(this.lista);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(682, 436);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "nombre_abm";
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
            this.filtros.Size = new System.Drawing.Size(660, 170);
            this.filtros.TabIndex = 5;
            this.filtros.TabStop = false;
            this.filtros.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(326, 37);
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
            this.filtro2.Click += new System.EventHandler(this.filtro2_Click);
            // 
            // seleccionar2
            // 
            this.seleccionar2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.seleccionar2.Location = new System.Drawing.Point(405, 82);
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
            this.combo.Location = new System.Drawing.Point(405, 33);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(219, 21);
            this.combo.TabIndex = 5;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(451, 124);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 6;
            this.limpiar.Text = "Limpiar";
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(549, 124);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 7;
            this.buscar.Text = "Buscar";
            // 
            // seleccionar
            // 
            this.seleccionar.Location = new System.Drawing.Point(549, 80);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(75, 23);
            this.seleccionar.TabIndex = 8;
            this.seleccionar.Text = "Seleccionar";
            // 
            // filtro1
            // 
            this.filtro1.Location = new System.Drawing.Point(6, 86);
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
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.lista.Controls.Add(this.scroll_);
            this.lista.Location = new System.Drawing.Point(16, 205);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(660, 172);
            this.lista.TabIndex = 5;
            this.lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // scroll_
            // 
            this.scroll_.Location = new System.Drawing.Point(0, 0);
            this.scroll_.Name = "scroll_";
            this.scroll_.Size = new System.Drawing.Size(0, 0);
            this.scroll_.TabIndex = 2;
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 460);
            this.Controls.Add(this.groupBox);
            this.Name = "Listado";
            this.Text = "Listado";
            this.groupBox.ResumeLayout(false);
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.lista.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button modificar;
       
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox seleccionar2;
        private System.Windows.Forms.Label filtro1;
        private System.Windows.Forms.Label filtro2;
        private System.Windows.Forms.ScrollableControl scroll_;
        private System.Windows.Forms.Label label1;

    }
}
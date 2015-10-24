namespace AerolineaFrba.Abm_Rol
{
    partial class Modificacion
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
            this.Estado = new AerolineaFrba.SuperControls.SuperCheckBox();
            this.Nombre = new AerolineaFrba.SuperControls.SuperTextBox();
            this.FuncionalidadesRol = new System.Windows.Forms.DataGridView();
            this.Funcionalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Aceptar = new AerolineaFrba.SuperControls.SuperButton();
            this.Cerrar = new AerolineaFrba.SuperControls.SuperButton();
            this.FuncionalidadSeleccion = new AerolineaFrba.SuperControls.SuperComboBox();
            this.superLabel3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Agregar = new AerolineaFrba.SuperControls.SuperButton();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesRol)).BeginInit();
            this.SuspendLayout();
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(132, 65);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(73, 17);
            this.Estado.TabIndex = 0;
            this.Estado.Text = "Habilitado";
            this.Estado.UseVisualStyleBackColor = true;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(132, 33);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 1;
            // 
            // FuncionalidadesRol
            // 
            this.FuncionalidadesRol.AllowUserToAddRows = false;
            this.FuncionalidadesRol.AllowUserToDeleteRows = false;
            this.FuncionalidadesRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FuncionalidadesRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionalidadesRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Funcionalidades,
            this.Eliminar});
            this.FuncionalidadesRol.Location = new System.Drawing.Point(50, 158);
            this.FuncionalidadesRol.Name = "FuncionalidadesRol";
            this.FuncionalidadesRol.Size = new System.Drawing.Size(390, 276);
            this.FuncionalidadesRol.TabIndex = 2;
            this.FuncionalidadesRol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FuncionalidadesRol_CellContentClick);
            // 
            // Funcionalidades
            // 
            this.Funcionalidades.HeaderText = "Funcionalidades";
            this.Funcionalidades.Name = "Funcionalidades";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(47, 33);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(44, 13);
            this.superLabel1.TabIndex = 3;
            this.superLabel1.Text = "Nombre";
            // 
            // superLabel2
            // 
            this.superLabel2.AutoSize = true;
            this.superLabel2.Location = new System.Drawing.Point(47, 65);
            this.superLabel2.Name = "superLabel2";
            this.superLabel2.Size = new System.Drawing.Size(40, 13);
            this.superLabel2.TabIndex = 4;
            this.superLabel2.Text = "Estado";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(273, 452);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 6;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(365, 452);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 7;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // FuncionalidadSeleccion
            // 
            this.FuncionalidadSeleccion.FormattingEnabled = true;
            this.FuncionalidadSeleccion.Location = new System.Drawing.Point(132, 106);
            this.FuncionalidadSeleccion.Name = "FuncionalidadSeleccion";
            this.FuncionalidadSeleccion.Size = new System.Drawing.Size(121, 21);
            this.FuncionalidadSeleccion.TabIndex = 8;
            // 
            // superLabel3
            // 
            this.superLabel3.AutoSize = true;
            this.superLabel3.Location = new System.Drawing.Point(47, 109);
            this.superLabel3.Name = "superLabel3";
            this.superLabel3.Size = new System.Drawing.Size(73, 13);
            this.superLabel3.TabIndex = 9;
            this.superLabel3.Text = "Funcionalidad";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(273, 104);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 10;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 492);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.superLabel3);
            this.Controls.Add(this.FuncionalidadSeleccion);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.superLabel2);
            this.Controls.Add(this.superLabel1);
            this.Controls.Add(this.FuncionalidadesRol);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Estado);
            this.Name = "Modificacion";
            this.Text = "Modificacion";
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperControls.SuperCheckBox Estado;
        private SuperControls.SuperTextBox Nombre;
        private System.Windows.Forms.DataGridView FuncionalidadesRol;
        private SuperControls.SuperLabel superLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidades;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private SuperControls.SuperLabel superLabel2;
        private SuperControls.SuperButton Aceptar;
        private SuperControls.SuperButton Cerrar;
        private SuperControls.SuperComboBox FuncionalidadSeleccion;
        private SuperControls.SuperLabel superLabel3;
        private SuperControls.SuperButton Agregar;

    }
}
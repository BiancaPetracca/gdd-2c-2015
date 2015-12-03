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
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_funcionalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Cerrar = new AerolineaFrba.SuperControls.SuperButton();
            this.FuncionalidadSeleccion = new AerolineaFrba.SuperControls.SuperComboBox();
            this.superLabel3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Agregar = new AerolineaFrba.SuperControls.SuperButton();
            this.eliminar = new AerolineaFrba.SuperControls.SuperButton();
            this.cambiarNombre = new AerolineaFrba.SuperControls.SuperButton();
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
            this.Estado.CheckedChanged += new System.EventHandler(this.Estado_CheckedChanged);
            // 
            // Nombre
            // 
            this.Nombre.AccessibleDescription = "Nombre del rol";
            this.Nombre.Location = new System.Drawing.Point(132, 33);
            this.Nombre.MaxLength = 25;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(191, 20);
            this.Nombre.TabIndex = 1;
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // FuncionalidadesRol
            // 
            this.FuncionalidadesRol.AccessibleDescription = "Funcionalidades";
            this.FuncionalidadesRol.AllowUserToAddRows = false;
            this.FuncionalidadesRol.AllowUserToDeleteRows = false;
            this.FuncionalidadesRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FuncionalidadesRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionalidadesRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_funcionalidades});
            this.FuncionalidadesRol.Location = new System.Drawing.Point(50, 158);
            this.FuncionalidadesRol.Name = "FuncionalidadesRol";
            this.FuncionalidadesRol.Size = new System.Drawing.Size(390, 251);
            this.FuncionalidadesRol.TabIndex = 2;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            // 
            // col_funcionalidades
            // 
            this.col_funcionalidades.HeaderText = "Funcionalidades";
            this.col_funcionalidades.Name = "col_funcionalidades";
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
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(365, 425);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 7;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // FuncionalidadSeleccion
            // 
            this.FuncionalidadSeleccion.AccessibleDescription = "Funcionalidad ";
            this.FuncionalidadSeleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FuncionalidadSeleccion.FormattingEnabled = true;
            this.FuncionalidadSeleccion.Location = new System.Drawing.Point(132, 106);
            this.FuncionalidadSeleccion.Name = "FuncionalidadSeleccion";
            this.FuncionalidadSeleccion.Size = new System.Drawing.Size(191, 21);
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
            this.Agregar.Location = new System.Drawing.Point(365, 106);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 10;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(274, 425);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 11;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // cambiarNombre
            // 
            this.cambiarNombre.Location = new System.Drawing.Point(365, 33);
            this.cambiarNombre.Name = "cambiarNombre";
            this.cambiarNombre.Size = new System.Drawing.Size(75, 23);
            this.cambiarNombre.TabIndex = 12;
            this.cambiarNombre.Text = "Cambiar";
            this.cambiarNombre.UseVisualStyleBackColor = true;
            this.cambiarNombre.Click += new System.EventHandler(this.cambiarNombre_Click);
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 469);
            this.Controls.Add(this.cambiarNombre);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.superLabel3);
            this.Controls.Add(this.FuncionalidadSeleccion);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.superLabel2);
            this.Controls.Add(this.superLabel1);
            this.Controls.Add(this.FuncionalidadesRol);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Estado);
            this.Name = "Modificacion";
            this.Text = "Modificacion";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperControls.SuperCheckBox Estado;
        private SuperControls.SuperTextBox Nombre;
        private System.Windows.Forms.DataGridView FuncionalidadesRol;
        private SuperControls.SuperLabel superLabel1;
        private SuperControls.SuperLabel superLabel2;
        private SuperControls.SuperButton Cerrar;
        private SuperControls.SuperComboBox FuncionalidadSeleccion;
        private SuperControls.SuperLabel superLabel3;
        private SuperControls.SuperButton Agregar;
        private SuperControls.SuperButton eliminar;
        private SuperControls.SuperButton cambiarNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_funcionalidades;

    }
}
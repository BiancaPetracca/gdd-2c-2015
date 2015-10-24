namespace AerolineaFrba.Abm_Rol
{
    partial class Alta
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
            this.Cerrar = new AerolineaFrba.SuperControls.SuperButton();
            this.Aceptar = new AerolineaFrba.SuperControls.SuperButton();
            this.superLabel2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Nombre = new AerolineaFrba.SuperControls.SuperTextBox();
            this.Estado = new AerolineaFrba.SuperControls.SuperCheckBox();
            this.Funcionalidad = new AerolineaFrba.SuperControls.SuperComboBox();
            this.superLabel3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Agregar = new AerolineaFrba.SuperControls.SuperButton();
            this.FuncionalidadesRol = new System.Windows.Forms.DataGridView();
            this.Funcionalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesRol)).BeginInit();
            this.SuspendLayout();
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(345, 417);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 15;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(253, 417);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 14;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // superLabel2
            // 
            this.superLabel2.AutoSize = true;
            this.superLabel2.Location = new System.Drawing.Point(41, 71);
            this.superLabel2.Name = "superLabel2";
            this.superLabel2.Size = new System.Drawing.Size(40, 13);
            this.superLabel2.TabIndex = 12;
            this.superLabel2.Text = "Estado";
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(41, 39);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(44, 13);
            this.superLabel1.TabIndex = 11;
            this.superLabel1.Text = "Nombre";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(131, 39);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 9;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(131, 71);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(73, 17);
            this.Estado.TabIndex = 8;
            this.Estado.Text = "Habilitado";
            this.Estado.UseVisualStyleBackColor = true;
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.FormattingEnabled = true;
            this.Funcionalidad.Location = new System.Drawing.Point(131, 102);
            this.Funcionalidad.Name = "Funcionalidad";
            this.Funcionalidad.Size = new System.Drawing.Size(121, 21);
            this.Funcionalidad.TabIndex = 16;
            // 
            // superLabel3
            // 
            this.superLabel3.AutoSize = true;
            this.superLabel3.Location = new System.Drawing.Point(41, 105);
            this.superLabel3.Name = "superLabel3";
            this.superLabel3.Size = new System.Drawing.Size(84, 13);
            this.superLabel3.TabIndex = 17;
            this.superLabel3.Text = "Funcionalidades";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(268, 100);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 18;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
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
            this.FuncionalidadesRol.Location = new System.Drawing.Point(44, 148);
            this.FuncionalidadesRol.Name = "FuncionalidadesRol";
            this.FuncionalidadesRol.Size = new System.Drawing.Size(376, 246);
            this.FuncionalidadesRol.TabIndex = 19;
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
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 457);
            this.Controls.Add(this.FuncionalidadesRol);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.superLabel3);
            this.Controls.Add(this.Funcionalidad);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.superLabel2);
            this.Controls.Add(this.superLabel1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Estado);
            this.Name = "Alta";
            this.Text = "Alta";
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperControls.SuperButton Cerrar;
        private SuperControls.SuperButton Aceptar;
        private SuperControls.SuperLabel superLabel2;
        private SuperControls.SuperLabel superLabel1;
        private SuperControls.SuperTextBox Nombre;
        private SuperControls.SuperCheckBox Estado;
        private SuperControls.SuperComboBox Funcionalidad;
        private SuperControls.SuperLabel superLabel3;
        private SuperControls.SuperButton Agregar;
        private System.Windows.Forms.DataGridView FuncionalidadesRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminar;
    }
}
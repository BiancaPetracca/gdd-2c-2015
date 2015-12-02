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
            this.guardar = new AerolineaFrba.SuperControls.SuperButton();
            this.superLabel2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Nombre = new AerolineaFrba.SuperControls.SuperTextBox();
            this.Estado = new AerolineaFrba.SuperControls.SuperCheckBox();
            this.Funcionalidad = new AerolineaFrba.SuperControls.SuperComboBox();
            this.superLabel3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Agregar = new AerolineaFrba.SuperControls.SuperButton();
            this.FuncionalidadesRol = new System.Windows.Forms.DataGridView();
            this.col_funcionalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quitar = new AerolineaFrba.SuperControls.SuperButton();
            this.datosRol = new AerolineaFrba.SuperControls.SuperGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesRol)).BeginInit();
            this.datosRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(394, 421);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 15;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(302, 421);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 14;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // superLabel2
            // 
            this.superLabel2.AutoSize = true;
            this.superLabel2.Location = new System.Drawing.Point(19, 62);
            this.superLabel2.Name = "superLabel2";
            this.superLabel2.Size = new System.Drawing.Size(40, 13);
            this.superLabel2.TabIndex = 12;
            this.superLabel2.Text = "Estado";
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(19, 26);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(44, 13);
            this.superLabel1.TabIndex = 11;
            this.superLabel1.Text = "Nombre";
            // 
            // Nombre
            // 
            this.Nombre.AccessibleDescription = "Nombre del rol";
            this.Nombre.Location = new System.Drawing.Point(136, 26);
            this.Nombre.MaxLength = 25;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(159, 20);
            this.Nombre.TabIndex = 9;
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // Estado
            // 
            this.Estado.AccessibleDescription = "Habilitado o no";
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(136, 61);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(73, 17);
            this.Estado.TabIndex = 8;
            this.Estado.Text = "Habilitado";
            this.Estado.UseVisualStyleBackColor = true;
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Funcionalidad.FormattingEnabled = true;
            this.Funcionalidad.Location = new System.Drawing.Point(180, 108);
            this.Funcionalidad.Name = "Funcionalidad";
            this.Funcionalidad.Size = new System.Drawing.Size(159, 21);
            this.Funcionalidad.TabIndex = 16;
            // 
            // superLabel3
            // 
            this.superLabel3.AutoSize = true;
            this.superLabel3.Location = new System.Drawing.Point(63, 108);
            this.superLabel3.Name = "superLabel3";
            this.superLabel3.Size = new System.Drawing.Size(84, 13);
            this.superLabel3.TabIndex = 17;
            this.superLabel3.Text = "Funcionalidades";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(377, 106);
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
            this.col_funcionalidades});
            this.FuncionalidadesRol.Location = new System.Drawing.Point(44, 169);
            this.FuncionalidadesRol.Name = "FuncionalidadesRol";
            this.FuncionalidadesRol.Size = new System.Drawing.Size(425, 246);
            this.FuncionalidadesRol.TabIndex = 19;
            this.FuncionalidadesRol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FuncionalidadesRol_CellContentClick);
            // 
            // col_funcionalidades
            // 
            this.col_funcionalidades.HeaderText = "Funcionalidades";
            this.col_funcionalidades.Name = "col_funcionalidades";
            this.col_funcionalidades.ReadOnly = true;
            // 
            // quitar
            // 
            this.quitar.Location = new System.Drawing.Point(210, 421);
            this.quitar.Name = "quitar";
            this.quitar.Size = new System.Drawing.Size(75, 23);
            this.quitar.TabIndex = 20;
            this.quitar.Text = "Quitar";
            this.quitar.UseVisualStyleBackColor = true;
            this.quitar.Click += new System.EventHandler(this.quitar_Click);
            // 
            // datosRol
            // 
            this.datosRol.Controls.Add(this.superLabel1);
            this.datosRol.Controls.Add(this.Estado);
            this.datosRol.Controls.Add(this.Nombre);
            this.datosRol.Controls.Add(this.superLabel2);
            this.datosRol.Location = new System.Drawing.Point(44, 12);
            this.datosRol.Name = "datosRol";
            this.datosRol.Size = new System.Drawing.Size(425, 84);
            this.datosRol.TabIndex = 21;
            this.datosRol.TabStop = false;
            this.datosRol.Text = "Datos del rol";
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 456);
            this.Controls.Add(this.superLabel3);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Funcionalidad);
            this.Controls.Add(this.datosRol);
            this.Controls.Add(this.quitar);
            this.Controls.Add(this.FuncionalidadesRol);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.guardar);
            this.Name = "Alta";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.Alta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesRol)).EndInit();
            this.datosRol.ResumeLayout(false);
            this.datosRol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperControls.SuperButton Cerrar;
        private SuperControls.SuperButton guardar;
        private SuperControls.SuperLabel superLabel2;
        private SuperControls.SuperLabel superLabel1;
        private SuperControls.SuperTextBox Nombre;
        private SuperControls.SuperCheckBox Estado;
        private SuperControls.SuperComboBox Funcionalidad;
        private SuperControls.SuperLabel superLabel3;
        private SuperControls.SuperButton Agregar;
        private System.Windows.Forms.DataGridView FuncionalidadesRol;
        private SuperControls.SuperButton quitar;
        private SuperControls.SuperGroupBox datosRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_funcionalidades;
    }
}
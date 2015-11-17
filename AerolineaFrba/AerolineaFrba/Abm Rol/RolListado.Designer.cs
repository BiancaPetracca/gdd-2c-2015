namespace AerolineaFrba.Abm_Rol
{
    partial class RolListado
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
            this.groupBox_SeleccionarRol = new System.Windows.Forms.GroupBox();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.ListadoRoles = new System.Windows.Forms.DataGridView();
            this.agregar = new System.Windows.Forms.Button();
            this.col_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificar = new AerolineaFrba.SuperControls.SuperButton();
            this.groupBox_SeleccionarRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_SeleccionarRol
            // 
            this.groupBox_SeleccionarRol.Controls.Add(this.modificar);
            this.groupBox_SeleccionarRol.Controls.Add(this.ListadoRoles);
            this.groupBox_SeleccionarRol.Controls.Add(this.agregar);
            this.groupBox_SeleccionarRol.Controls.Add(this.button_Cerrar);
            this.groupBox_SeleccionarRol.Location = new System.Drawing.Point(69, 12);
            this.groupBox_SeleccionarRol.Name = "groupBox_SeleccionarRol";
            this.groupBox_SeleccionarRol.Size = new System.Drawing.Size(874, 396);
            this.groupBox_SeleccionarRol.TabIndex = 21;
            this.groupBox_SeleccionarRol.TabStop = false;
            this.groupBox_SeleccionarRol.Text = "Roles";
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(768, 348);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 1;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // ListadoRoles
            // 
            this.ListadoRoles.AllowUserToAddRows = false;
            this.ListadoRoles.AllowUserToDeleteRows = false;
            this.ListadoRoles.AllowUserToResizeColumns = false;
            this.ListadoRoles.AllowUserToResizeRows = false;
            this.ListadoRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ListadoRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_rol,
            this.col_habilitado});
            this.ListadoRoles.Location = new System.Drawing.Point(115, 36);
            this.ListadoRoles.Name = "ListadoRoles";
            this.ListadoRoles.Size = new System.Drawing.Size(346, 335);
            this.ListadoRoles.TabIndex = 0;
          
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(677, 348);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 22;
            this.agregar.Text = "Agregar";
            this.agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // col_rol
            // 
            this.col_rol.HeaderText = "Rol";
            this.col_rol.Name = "col_rol";
            this.col_rol.ReadOnly = true;
            // 
            // col_habilitado
            // 
            this.col_habilitado.HeaderText = "Habilitado";
            this.col_habilitado.Name = "col_habilitado";
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(576, 348);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 23;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // RolListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 467);
            this.Controls.Add(this.groupBox_SeleccionarRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RolListado";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion";
            this.Load += new System.EventHandler(this.RolListado_Load);
            this.groupBox_SeleccionarRol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SeleccionarRol;
        private System.Windows.Forms.DataGridView ListadoRoles;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Button agregar;
        private SuperControls.SuperButton modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_habilitado;

    }

    }

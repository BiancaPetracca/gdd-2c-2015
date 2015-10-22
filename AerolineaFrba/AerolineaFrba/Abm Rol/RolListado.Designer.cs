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
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox_SeleccionarRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_SeleccionarRol
            // 
            this.groupBox_SeleccionarRol.Controls.Add(this.button_Cerrar);
            this.groupBox_SeleccionarRol.Controls.Add(this.ListadoRoles);
            this.groupBox_SeleccionarRol.Controls.Add(this.agregar);
            this.groupBox_SeleccionarRol.Location = new System.Drawing.Point(21, 12);
            this.groupBox_SeleccionarRol.Name = "groupBox_SeleccionarRol";
            this.groupBox_SeleccionarRol.Size = new System.Drawing.Size(967, 429);
            this.groupBox_SeleccionarRol.TabIndex = 21;
            this.groupBox_SeleccionarRol.TabStop = false;
            this.groupBox_SeleccionarRol.Text = "Roles";
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(843, 380);
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
            this.Indice,
            this.Rol,
            this.Modificar});
            this.ListadoRoles.Location = new System.Drawing.Point(91, 53);
            this.ListadoRoles.Name = "ListadoRoles";
            this.ListadoRoles.Size = new System.Drawing.Size(827, 307);
            this.ListadoRoles.TabIndex = 0;
            this.ListadoRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SeleccionRol_CellContentClick);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(741, 380);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 22;
            this.agregar.Text = "Agregar";
            this.agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Indice
            // 
            this.Indice.HeaderText = "Índice";
            this.Indice.Name = "Indice";
            this.Indice.Visible = false;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // Modificar
            // 
            this.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Modificar.FillWeight = 30F;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Text = "Modificar";
            this.Modificar.ToolTipText = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            this.Modificar.Width = 181;
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
            this.groupBox_SeleccionarRol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SeleccionarRol;
        private System.Windows.Forms.DataGridView ListadoRoles;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;

    }

    }

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.DatosDelRol = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Habilitado = new System.Windows.Forms.CheckBox();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Funcionalidades = new System.Windows.Forms.ComboBox();
            this.AgregarFunc = new System.Windows.Forms.Button();
            this.label_Funcionalidad = new System.Windows.Forms.Label();
            this.dataGridView_ListaFuncionalidades = new System.Windows.Forms.DataGridView();
            this.FUN_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DatosDelRol.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(739, 431);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 5;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(658, 431);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(820, 431);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 6;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // DatosDelRol
            // 
            this.DatosDelRol.Controls.Add(this.label1);
            this.DatosDelRol.Controls.Add(this.Habilitado);
            this.DatosDelRol.Controls.Add(this.label_Nombre);
            this.DatosDelRol.Controls.Add(this.Nombre);
            this.DatosDelRol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DatosDelRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DatosDelRol.Location = new System.Drawing.Point(25, 26);
            this.DatosDelRol.Name = "DatosDelRol";
            this.DatosDelRol.Size = new System.Drawing.Size(419, 60);
            this.DatosDelRol.TabIndex = 19;
            this.DatosDelRol.TabStop = false;
            this.DatosDelRol.Text = "Datos del Rol";
            this.DatosDelRol.Enter += new System.EventHandler(this.DatosDelRol_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(284, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estado";
            // 
            // Habilitado
            // 
            this.Habilitado.AutoSize = true;
            this.Habilitado.Checked = true;
            this.Habilitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Habilitado.Location = new System.Drawing.Point(330, 27);
            this.Habilitado.Name = "Habilitado";
            this.Habilitado.Size = new System.Drawing.Size(73, 17);
            this.Habilitado.TabIndex = 10;
            this.Habilitado.Text = "Habilitado";
            this.Habilitado.UseVisualStyleBackColor = true;
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nombre.Location = new System.Drawing.Point(6, 28);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 1;
            this.label_Nombre.Text = "Nombre";
            // 
            // Nombre
            // 
            this.Nombre.AccessibleDescription = "Nombre del rol";
            this.Nombre.Location = new System.Drawing.Point(56, 25);
            this.Nombre.MaxLength = 15;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(218, 20);
            this.Nombre.TabIndex = 0;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Funcionalidades);
            this.groupBox1.Controls.Add(this.AgregarFunc);
            this.groupBox1.Controls.Add(this.label_Funcionalidad);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(461, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 60);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Funcionalidad";
            // 
            // Funcionalidades
            // 
            this.Funcionalidades.AccessibleDescription = "Funcionalidad";
            this.Funcionalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Funcionalidades.FormattingEnabled = true;
            this.Funcionalidades.Location = new System.Drawing.Point(97, 28);
            this.Funcionalidades.Name = "Funcionalidades";
            this.Funcionalidades.Size = new System.Drawing.Size(232, 21);
            this.Funcionalidades.TabIndex = 1;
            // 
            // AgregarFunc
            // 
            this.AgregarFunc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AgregarFunc.Location = new System.Drawing.Point(362, 28);
            this.AgregarFunc.Name = "AgregarFunc";
            this.AgregarFunc.Size = new System.Drawing.Size(75, 23);
            this.AgregarFunc.TabIndex = 2;
            this.AgregarFunc.Text = "Agregar";
            this.AgregarFunc.UseVisualStyleBackColor = true;
            this.AgregarFunc.Click += new System.EventHandler(this.AgregarFunc_Click);
            // 
            // label_Funcionalidad
            // 
            this.label_Funcionalidad.AutoSize = true;
            this.label_Funcionalidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Funcionalidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Funcionalidad.Location = new System.Drawing.Point(18, 28);
            this.label_Funcionalidad.Name = "label_Funcionalidad";
            this.label_Funcionalidad.Size = new System.Drawing.Size(73, 13);
            this.label_Funcionalidad.TabIndex = 4;
            this.label_Funcionalidad.Text = "Funcionalidad";
            // 
            // dataGridView_ListaFuncionalidades
            // 
            this.dataGridView_ListaFuncionalidades.AccessibleDescription = "Lista de funcionalidades del rol";
            this.dataGridView_ListaFuncionalidades.AllowUserToAddRows = false;
            this.dataGridView_ListaFuncionalidades.AllowUserToDeleteRows = false;
            this.dataGridView_ListaFuncionalidades.AllowUserToResizeColumns = false;
            this.dataGridView_ListaFuncionalidades.AllowUserToResizeRows = false;
            this.dataGridView_ListaFuncionalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListaFuncionalidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_ListaFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListaFuncionalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FUN_ID,
            this.Funcionalidad,
            this.Eliminar});
            this.dataGridView_ListaFuncionalidades.Location = new System.Drawing.Point(25, 101);
            this.dataGridView_ListaFuncionalidades.Name = "dataGridView_ListaFuncionalidades";
            this.dataGridView_ListaFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_ListaFuncionalidades.Size = new System.Drawing.Size(889, 301);
            this.dataGridView_ListaFuncionalidades.TabIndex = 3;
            this.dataGridView_ListaFuncionalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ListaFuncionalidades_CellContentClick);
            // 
            // FUN_ID
            // 
            this.FUN_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.FUN_ID.DefaultCellStyle = dataGridViewCellStyle4;
            this.FUN_ID.HeaderText = "Índice";
            this.FUN_ID.Name = "FUN_ID";
            this.FUN_ID.ReadOnly = true;
            this.FUN_ID.Visible = false;
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Funcionalidad.DefaultCellStyle = dataGridViewCellStyle5;
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            this.Funcionalidad.ReadOnly = true;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Pink;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle6;
            this.Eliminar.FillWeight = 30F;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.Text = "Eliminar Fila";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(940, 470);
            this.Controls.Add(this.DatosDelRol);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.dataGridView_ListaFuncionalidades);
            this.Controls.Add(this.Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modificacion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion";
            this.DatosDelRol.ResumeLayout(false);
            this.DatosDelRol.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaFuncionalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.GroupBox DatosDelRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Habilitado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Funcionalidades;
        private System.Windows.Forms.Button AgregarFunc;
        private System.Windows.Forms.Label label_Funcionalidad;
        private System.Windows.Forms.DataGridView dataGridView_ListaFuncionalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUN_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox Nombre;
    }

    }

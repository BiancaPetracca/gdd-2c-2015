﻿namespace AerolineaFrba.Abm_Rol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.paner_Alta = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Funcionalidad = new System.Windows.Forms.ComboBox();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.label_Funcionalidad = new System.Windows.Forms.Label();
            this.dataGridView_ListaFuncionalidades = new System.Windows.Forms.DataGridView();
            this.FUN_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.paner_Alta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(739, 431);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 5;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(658, 431);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 4;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(820, 431);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 6;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // paner_Alta
            // 
            this.paner_Alta.Controls.Add(this.label1);
            this.paner_Alta.Controls.Add(this.checkBox1);
            this.paner_Alta.Controls.Add(this.groupBox1);
            this.paner_Alta.Controls.Add(this.dataGridView_ListaFuncionalidades);
            this.paner_Alta.Controls.Add(this.label_Nombre);
            this.paner_Alta.Controls.Add(this.textBox_Nombre);
            this.paner_Alta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Alta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paner_Alta.Location = new System.Drawing.Point(25, 26);
            this.paner_Alta.Name = "paner_Alta";
            this.paner_Alta.Size = new System.Drawing.Size(889, 399);
            this.paner_Alta.TabIndex = 19;
            this.paner_Alta.TabStop = false;
            this.paner_Alta.Text = "Datos del Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estado";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(99, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Habilitado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Funcionalidad);
            this.groupBox1.Controls.Add(this.button_Agregar);
            this.groupBox1.Controls.Add(this.label_Funcionalidad);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(415, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 60);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Funcionalidad";
            // 
            // comboBox_Funcionalidad
            // 
            this.comboBox_Funcionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Funcionalidad.FormattingEnabled = true;
            this.comboBox_Funcionalidad.Location = new System.Drawing.Point(97, 28);
            this.comboBox_Funcionalidad.Name = "comboBox_Funcionalidad";
            this.comboBox_Funcionalidad.Size = new System.Drawing.Size(232, 21);
            this.comboBox_Funcionalidad.TabIndex = 1;
            // 
            // button_Agregar
            // 
            this.button_Agregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Agregar.Location = new System.Drawing.Point(362, 28);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(75, 23);
            this.button_Agregar.TabIndex = 2;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // label_Funcionalidad
            // 
            this.label_Funcionalidad.AutoSize = true;
            this.label_Funcionalidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Funcionalidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Funcionalidad.Location = new System.Drawing.Point(18, 31);
            this.label_Funcionalidad.Name = "label_Funcionalidad";
            this.label_Funcionalidad.Size = new System.Drawing.Size(73, 13);
            this.label_Funcionalidad.TabIndex = 4;
            this.label_Funcionalidad.Text = "Funcionalidad";
            // 
            // dataGridView_ListaFuncionalidades
            // 
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
            this.dataGridView_ListaFuncionalidades.Location = new System.Drawing.Point(52, 85);
            this.dataGridView_ListaFuncionalidades.Name = "dataGridView_ListaFuncionalidades";
            this.dataGridView_ListaFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_ListaFuncionalidades.Size = new System.Drawing.Size(816, 301);
            this.dataGridView_ListaFuncionalidades.TabIndex = 3;
            // 
            // FUN_ID
            // 
            this.FUN_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.FUN_ID.DefaultCellStyle = dataGridViewCellStyle13;
            this.FUN_ID.HeaderText = "Índice";
            this.FUN_ID.Name = "FUN_ID";
            this.FUN_ID.ReadOnly = true;
            this.FUN_ID.Visible = false;
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            this.Funcionalidad.DefaultCellStyle = dataGridViewCellStyle14;
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            this.Funcionalidad.ReadOnly = true;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Pink;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle15;
            this.Eliminar.FillWeight = 30F;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.Text = "Eliminar Fila";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nombre.Location = new System.Drawing.Point(49, 30);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 1;
            this.label_Nombre.Text = "Nombre";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(99, 27);
            this.textBox_Nombre.MaxLength = 15;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            this.textBox_Nombre.TextChanged += new System.EventHandler(this.textBox_Nombre_TextChanged);
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(940, 470);
            this.Controls.Add(this.paner_Alta);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modificacion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            this.paner_Alta.ResumeLayout(false);
            this.paner_Alta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaFuncionalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.GroupBox paner_Alta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Funcionalidad;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.Label label_Funcionalidad;
        private System.Windows.Forms.DataGridView dataGridView_ListaFuncionalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUN_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox textBox_Nombre;
    }

    }
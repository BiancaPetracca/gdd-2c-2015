﻿using AerolineaFrba.SuperControls;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DatosDelRol = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.label1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.checkBox1 = new AerolineaFrba.SuperControls.SuperCheckBox();
            this.label_Nombre = new AerolineaFrba.SuperControls.SuperLabel();
            this.textBox_Nombre = new AerolineaFrba.SuperControls.SuperTextBox();
            this.groupBox1 = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.comboBox_Funcionalidad = new AerolineaFrba.SuperControls.SuperComboBox();
            this.button_Agregar = new AerolineaFrba.SuperControls.SuperButton();
            this.label_Funcionalidad = new AerolineaFrba.SuperControls.SuperLabel();
            this.dataGridView_ListaFuncionalidades = new System.Windows.Forms.DataGridView();
            this.FUN_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_Limpiar = new AerolineaFrba.SuperControls.SuperButton();
            this.button_Guardar = new AerolineaFrba.SuperControls.SuperButton();
            this.button_Cerrar = new AerolineaFrba.SuperControls.SuperButton();
            this.DatosDelRol.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosDelRol
            // 
            this.DatosDelRol.Controls.Add(this.label1);
            this.DatosDelRol.Controls.Add(this.checkBox1);
            this.DatosDelRol.Controls.Add(this.label_Nombre);
            this.DatosDelRol.Controls.Add(this.textBox_Nombre);
            this.DatosDelRol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DatosDelRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DatosDelRol.Location = new System.Drawing.Point(12, 12);
            this.DatosDelRol.Name = "DatosDelRol";
            this.DatosDelRol.Size = new System.Drawing.Size(486, 60);
            this.DatosDelRol.TabIndex = 18;
            this.DatosDelRol.TabStop = false;
            this.DatosDelRol.Text = "Datos del Rol";
            this.DatosDelRol.Enter += new System.EventHandler(this.paner_Alta_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(348, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estado";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(398, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Habilitado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nombre.Location = new System.Drawing.Point(21, 28);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 1;
            this.label_Nombre.Text = "Nombre";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.AccessibleDescription = "Nombre del rol";
            this.textBox_Nombre.Location = new System.Drawing.Point(71, 25);
            this.textBox_Nombre.MaxLength = 15;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            this.textBox_Nombre.TextChanged += new System.EventHandler(this.textBox_Nombre_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Funcionalidad);
            this.groupBox1.Controls.Add(this.button_Agregar);
            this.groupBox1.Controls.Add(this.label_Funcionalidad);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(504, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 60);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Funcionalidad";
            // 
            // comboBox_Funcionalidad
            // 
            this.comboBox_Funcionalidad.AccessibleDescription = "Funcionalidad";
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
            this.dataGridView_ListaFuncionalidades.Location = new System.Drawing.Point(12, 87);
            this.dataGridView_ListaFuncionalidades.Name = "dataGridView_ListaFuncionalidades";
            this.dataGridView_ListaFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_ListaFuncionalidades.Size = new System.Drawing.Size(945, 301);
            this.dataGridView_ListaFuncionalidades.TabIndex = 3;
            this.dataGridView_ListaFuncionalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ListaFuncionalidades_CellContentClick);
            // 
            // FUN_ID
            // 
            this.FUN_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.FUN_ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.FUN_ID.HeaderText = "Índice";
            this.FUN_ID.Name = "FUN_ID";
            this.FUN_ID.ReadOnly = true;
            this.FUN_ID.Visible = false;
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Funcionalidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            this.Funcionalidad.ReadOnly = true;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Pink;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Eliminar.FillWeight = 30F;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.Text = "Eliminar Fila";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(819, 426);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 5;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(726, 426);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 4;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(911, 426);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 6;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(998, 461);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.dataGridView_ListaFuncionalidades);
            this.Controls.Add(this.DatosDelRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta";
            this.DatosDelRol.ResumeLayout(false);
            this.DatosDelRol.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaFuncionalidades)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private SuperGroupBox DatosDelRol;
        private SuperGroupBox groupBox1;
        private SuperButton button_Agregar;
        private SuperLabel label_Funcionalidad;
        private System.Windows.Forms.DataGridView dataGridView_ListaFuncionalidades;
        private SuperLabel label_Nombre;
        private SuperTextBox textBox_Nombre;
        private SuperButton button_Limpiar;
        private SuperButton button_Guardar;
        private SuperButton button_Cerrar;
        private SuperComboBox comboBox_Funcionalidad;
        private SuperLabel label1;
        private SuperCheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUN_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}

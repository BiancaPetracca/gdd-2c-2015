﻿namespace AerolineaFrba.Abm_Rol
{
    partial class Listado
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
            this.dataGridView_SeleccionRol = new System.Windows.Forms.DataGridView();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox_SeleccionarRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SeleccionRol)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_SeleccionarRol
            // 
            this.groupBox_SeleccionarRol.Controls.Add(this.dataGridView_SeleccionRol);
            this.groupBox_SeleccionarRol.Location = new System.Drawing.Point(21, 12);
            this.groupBox_SeleccionarRol.Name = "groupBox_SeleccionarRol";
            this.groupBox_SeleccionarRol.Size = new System.Drawing.Size(659, 399);
            this.groupBox_SeleccionarRol.TabIndex = 21;
            this.groupBox_SeleccionarRol.TabStop = false;
            this.groupBox_SeleccionarRol.Text = "Roles";
            this.groupBox_SeleccionarRol.Enter += new System.EventHandler(this.groupBox_SeleccionarRol_Enter);
            // 
            // dataGridView_SeleccionRol
            // 
            this.dataGridView_SeleccionRol.AllowUserToAddRows = false;
            this.dataGridView_SeleccionRol.AllowUserToDeleteRows = false;
            this.dataGridView_SeleccionRol.AllowUserToResizeColumns = false;
            this.dataGridView_SeleccionRol.AllowUserToResizeRows = false;
            this.dataGridView_SeleccionRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SeleccionRol.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_SeleccionRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SeleccionRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indice,
            this.Rol,
            this.Modificar});
            this.dataGridView_SeleccionRol.Location = new System.Drawing.Point(21, 154);
            this.dataGridView_SeleccionRol.Name = "dataGridView_SeleccionRol";
            this.dataGridView_SeleccionRol.Size = new System.Drawing.Size(620, 214);
            this.dataGridView_SeleccionRol.TabIndex = 0;
            this.dataGridView_SeleccionRol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SeleccionRol_CellContentClick);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(605, 429);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 1;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(503, 429);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 22;
            this.agregar.Text = "Agregar";
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
            this.Modificar.FillWeight = 30F;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "Seleccionar";
            this.Modificar.UseColumnTextForButtonValue = true;
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(721, 474);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.groupBox_SeleccionarRol);
            this.Controls.Add(this.agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Listado";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion";
            this.groupBox_SeleccionarRol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SeleccionRol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SeleccionarRol;
        private System.Windows.Forms.DataGridView dataGridView_SeleccionRol;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;

    }

    }

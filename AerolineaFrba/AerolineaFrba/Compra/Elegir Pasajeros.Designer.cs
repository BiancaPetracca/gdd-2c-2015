using AerolineaFrba.SuperControls;
using System;
namespace AerolineaFrba.Compra
{
    partial class Elegir_Pasajeros
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
            this.grid_pasajeros = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quitar = new AerolineaFrba.SuperControls.SuperButton();
            this.elegirButaca = new AerolineaFrba.SuperControls.SuperButton();
            this.Cancelar = new AerolineaFrba.SuperControls.SuperButton();
            this.Siguiente = new AerolineaFrba.SuperControls.SuperButton();
            this.KgsRestantes = new AerolineaFrba.SuperControls.SuperLabel();
            this.cellDateTimePicker = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.col_tipo_doc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_butaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_encomienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pasajeros)).BeginInit();
            this.grid_pasajeros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_pasajeros
            // 
            this.grid_pasajeros.AllowUserToAddRows = false;
            this.grid_pasajeros.AllowUserToDeleteRows = false;
            this.grid_pasajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_pasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_tipo_doc,
            this.col_dni,
            this.col_nombre,
            this.col_apellido,
            this.col_direccion,
            this.col_telefono,
            this.col_mail,
            this.col_fecha_nac,
            this.col_butaca,
            this.col_tipo,
            this.col_encomienda});
            this.grid_pasajeros.Controls.Add(this.cellDateTimePicker);
            this.grid_pasajeros.Location = new System.Drawing.Point(19, 65);
            this.grid_pasajeros.Name = "grid_pasajeros";
            this.grid_pasajeros.Size = new System.Drawing.Size(1147, 287);
            this.grid_pasajeros.TabIndex = 0;
            this.grid_pasajeros.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.pasajeros_CellBeginEdit);
            this.grid_pasajeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pasajeros_CellContentClick);
            this.grid_pasajeros.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosPasajes_CellValueChanged);
            this.grid_pasajeros.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.pasajeros_EditingControlShowing);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KgsRestantes);
            this.groupBox1.Controls.Add(this.grid_pasajeros);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1190, 383);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elegir Pasajeros / Datos Encomienda";
            // 
            // quitar
            // 
            this.quitar.Location = new System.Drawing.Point(773, 422);
            this.quitar.Name = "quitar";
            this.quitar.Size = new System.Drawing.Size(75, 23);
            this.quitar.TabIndex = 5;
            this.quitar.Text = "Quitar butaca";
            this.quitar.UseVisualStyleBackColor = true;
            this.quitar.Click += new System.EventHandler(this.quitar_Click);
            // 
            // elegirButaca
            // 
            this.elegirButaca.Location = new System.Drawing.Point(872, 422);
            this.elegirButaca.Name = "elegirButaca";
            this.elegirButaca.Size = new System.Drawing.Size(91, 23);
            this.elegirButaca.TabIndex = 4;
            this.elegirButaca.Text = "Elegir butaca";
            this.elegirButaca.UseVisualStyleBackColor = true;
            this.elegirButaca.Click += new System.EventHandler(this.elegirButaca_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(993, 422);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(1103, 422);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(75, 23);
            this.Siguiente.TabIndex = 2;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // KgsRestantes
            // 
            this.KgsRestantes.AutoSize = true;
            this.KgsRestantes.Location = new System.Drawing.Point(54, 36);
            this.KgsRestantes.Name = "KgsRestantes";
            this.KgsRestantes.Size = new System.Drawing.Size(318, 13);
            this.KgsRestantes.TabIndex = 1;
            this.KgsRestantes.Text = "RECUERDE: El límite de kgs para las encomiendas en total es de";
            // 
            // cellDateTimePicker
            // 
            this.cellDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.cellDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cellDateTimePicker.Location = new System.Drawing.Point(0, 0);
            this.cellDateTimePicker.Name = "cellDateTimePicker";
            this.cellDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.cellDateTimePicker.TabIndex = 2;
            this.cellDateTimePicker.Visible = false;
            this.cellDateTimePicker.ValueChanged += new System.EventHandler(this.cellDateTimePickerValueChanged);
            // 
            // col_tipo_doc
            // 
            this.col_tipo_doc.HeaderText = "Tipo";
            this.col_tipo_doc.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LI"});
            this.col_tipo_doc.Name = "col_tipo_doc";
            // 
            // col_dni
            // 
            this.col_dni.HeaderText = "DNI";
            this.col_dni.Name = "col_dni";
            // 
            // col_nombre
            // 
            this.col_nombre.DataPropertyName = "cli_nombre";
            this.col_nombre.HeaderText = "Nombre";
            this.col_nombre.Name = "col_nombre";
            // 
            // col_apellido
            // 
            this.col_apellido.DataPropertyName = "cli_apellido";
            this.col_apellido.HeaderText = "Apellido";
            this.col_apellido.Name = "col_apellido";
            // 
            // col_direccion
            // 
            this.col_direccion.DataPropertyName = "cli_direccion";
            this.col_direccion.HeaderText = "Dirección";
            this.col_direccion.Name = "col_direccion";
            // 
            // col_telefono
            // 
            this.col_telefono.DataPropertyName = "cli_telefono";
            this.col_telefono.HeaderText = "Teléfono";
            this.col_telefono.Name = "col_telefono";
            // 
            // col_mail
            // 
            this.col_mail.DataPropertyName = "cli_mail";
            this.col_mail.HeaderText = "Mail";
            this.col_mail.Name = "col_mail";
            // 
            // col_fecha_nac
            // 
            this.col_fecha_nac.DataPropertyName = "cli_fecha_nac";
            this.col_fecha_nac.HeaderText = "Fecha de Nacimiento";
            this.col_fecha_nac.Name = "col_fecha_nac";
            // 
            // col_butaca
            // 
            this.col_butaca.HeaderText = "Butaca";
            this.col_butaca.Name = "col_butaca";
            this.col_butaca.ReadOnly = true;
            // 
            // col_tipo
            // 
            this.col_tipo.HeaderText = "Tipo";
            this.col_tipo.Name = "col_tipo";
            this.col_tipo.ReadOnly = true;
            // 
            // col_encomienda
            // 
            this.col_encomienda.HeaderText = "Kgs. Encomienda";
            this.col_encomienda.Name = "col_encomienda";
            // 
            // Elegir_Pasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 468);
            this.Controls.Add(this.quitar);
            this.Controls.Add(this.elegirButaca);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Elegir_Pasajeros";
            this.Text = "Elegir Pasajeros";
            this.Load += new System.EventHandler(this.Elegir_Pasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_pasajeros)).EndInit();
            this.grid_pasajeros.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private SuperDateTimePicker cellDateTimePicker;
        private System.Windows.Forms.DataGridView grid_pasajeros;
        private System.Windows.Forms.GroupBox groupBox1;
        private SuperButton Siguiente;
        private SuperButton Cancelar;
        private System.Collections.Generic.List<int> dateColumnsIndexes;
        private Decimal restantes;
        private SuperLabel KgsRestantes;
        private SuperButton elegirButaca;
        private SuperButton quitar;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_butaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_encomienda;
        

    }

}
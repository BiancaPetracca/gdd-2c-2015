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
            this.pasajeros = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KgsRestantes = new AerolineaFrba.SuperControls.SuperLabel();
            this.Cancelar = new AerolineaFrba.SuperControls.SuperButton();
            this.Siguiente = new AerolineaFrba.SuperControls.SuperButton();
            this.elegirButaca = new AerolineaFrba.SuperControls.SuperButton();
            this.quitar = new AerolineaFrba.SuperControls.SuperButton();
            this.col_tipo_doc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_butaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KgsEncomienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pasajeros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pasajeros
            // 
            this.pasajeros.AllowUserToAddRows = false;
            this.pasajeros.AllowUserToDeleteRows = false;
            this.pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_tipo_doc,
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.Telefono,
            this.Mail,
            this.FechaNacimiento,
            this.col_butaca,
            this.col_tipo,
            this.KgsEncomienda});
            this.pasajeros.Location = new System.Drawing.Point(19, 65);
            this.pasajeros.Name = "pasajeros";
            this.pasajeros.Size = new System.Drawing.Size(845, 287);
            this.pasajeros.TabIndex = 0;
            this.pasajeros.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosPasajes_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KgsRestantes);
            this.groupBox1.Controls.Add(this.pasajeros);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elegir Pasajeros / Datos Encomienda";
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
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(677, 411);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(787, 411);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(75, 23);
            this.Siguiente.TabIndex = 2;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // elegirButaca
            // 
            this.elegirButaca.Location = new System.Drawing.Point(556, 411);
            this.elegirButaca.Name = "elegirButaca";
            this.elegirButaca.Size = new System.Drawing.Size(91, 23);
            this.elegirButaca.TabIndex = 4;
            this.elegirButaca.Text = "Elegir butaca";
            this.elegirButaca.UseVisualStyleBackColor = true;
            this.elegirButaca.Click += new System.EventHandler(this.elegirButaca_Click);
            // 
            // quitar
            // 
            this.quitar.Location = new System.Drawing.Point(457, 411);
            this.quitar.Name = "quitar";
            this.quitar.Size = new System.Drawing.Size(75, 23);
            this.quitar.TabIndex = 5;
            this.quitar.Text = "Quitar butaca";
            this.quitar.UseVisualStyleBackColor = true;
            this.quitar.Click += new System.EventHandler(this.quitar_Click);
            // 
            // col_tipo_doc
            // 
            this.col_tipo_doc.HeaderText = "Tipo documento";
            this.col_tipo_doc.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LI"});
            this.col_tipo_doc.Name = "col_tipo_doc";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
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
            // KgsEncomienda
            // 
            this.KgsEncomienda.HeaderText = "Kgs. Encomienda";
            this.KgsEncomienda.Name = "KgsEncomienda";
            // 
            // Elegir_Pasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 455);
            this.Controls.Add(this.quitar);
            this.Controls.Add(this.elegirButaca);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Elegir_Pasajeros";
            this.Text = "Elegir Pasajeros";
            this.Load += new System.EventHandler(this.Elegir_Pasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pasajeros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.DataGridView pasajeros;
        private System.Windows.Forms.GroupBox groupBox1;
        private SuperButton Siguiente;
        private SuperButton Cancelar;

        private Decimal restantes;
        private SuperLabel KgsRestantes;
        private SuperButton elegirButaca;
        private SuperButton quitar;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_butaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KgsEncomienda;
        

    }

}
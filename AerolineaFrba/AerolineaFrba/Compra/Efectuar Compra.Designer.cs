﻿using AerolineaFrba.SuperControls;
namespace AerolineaFrba.Compra
{
    partial class Efectuar_Compra
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
            this.groupBox1 = new SuperGroupBox();
            this.groupBox2 = new SuperGroupBox();
            this.label7 = new SuperLabel();
            this.Cuotas = new SuperNumericUpDown();
            this.label6 = new SuperLabel();
            this.CodigoSeguridad = new SuperTextBox();
            this.label5 = new SuperLabel();
            this.NumeroTarjeta = new SuperTextBox();
            this.label4 = new SuperLabel();
            this.FechaExpiracion = new SuperDateTimePicker();
            this.label3 = new SuperLabel();
            this.TipoTarjeta = new SuperComboBox();
            this.button2 = new SuperButton();
            this.label2 = new SuperLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new SuperButton();
            this.label1 = new SuperLabel();
            this.MedioPago = new SuperComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MedioPago);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar datos de compra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Cuotas);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CodigoSeguridad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.NumeroTarjeta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.FechaExpiracion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TipoTarjeta);
            this.groupBox2.Location = new System.Drawing.Point(43, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 173);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la tarjeta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cuotas";
            // 
            // Cuotas
            // 
            this.Cuotas.AccessibleDescription = "Cuotas en las que desee pagarlo";
            this.Cuotas.Location = new System.Drawing.Point(699, 124);
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.Size = new System.Drawing.Size(41, 20);
            this.Cuotas.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Código de seguridad";
            // 
            // CodigoSeguridad
            // 
            this.CodigoSeguridad.AccessibleDescription = "Ingresar código de seguridad de la tarjeta";
            this.CodigoSeguridad.Location = new System.Drawing.Point(509, 43);
            this.CodigoSeguridad.Name = "CodigoSeguridad";
            this.CodigoSeguridad.Size = new System.Drawing.Size(86, 20);
            this.CodigoSeguridad.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Número de tarjeta";
            // 
            // NumeroTarjeta
            // 
            this.NumeroTarjeta.AccessibleDescription = "Ingresar el número de la tarjeta";
            this.NumeroTarjeta.Location = new System.Drawing.Point(143, 46);
            this.NumeroTarjeta.Name = "NumeroTarjeta";
            this.NumeroTarjeta.Size = new System.Drawing.Size(181, 20);
            this.NumeroTarjeta.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de expiración";
            // 
            // FechaExpiracion
            // 
            this.FechaExpiracion.AccessibleDescription = "Fecha de expiración";
            this.FechaExpiracion.CustomFormat = "mm/yyyy";
            this.FechaExpiracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaExpiracion.Location = new System.Drawing.Point(509, 124);
            this.FechaExpiracion.Name = "FechaExpiracion";
            this.FechaExpiracion.Size = new System.Drawing.Size(86, 20);
            this.FechaExpiracion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo";
            // 
            // TipoTarjeta
            // 
            this.TipoTarjeta.AccessibleDescription = "Tipo de la tarjeta";
            this.TipoTarjeta.FormattingEnabled = true;
            this.TipoTarjeta.Location = new System.Drawing.Point(143, 122);
            this.TipoTarjeta.Name = "TipoTarjeta";
            this.TipoTarjeta.Size = new System.Drawing.Size(181, 21);
            this.TipoTarjeta.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(742, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datos personales";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.DNI,
            this.Dirección,
            this.Mail});
            this.dataGridView1.Location = new System.Drawing.Point(163, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 50);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Dirección
            // 
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.Name = "Dirección";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medio de pago";
            // 
            // MedioPago
            // 
            this.MedioPago.AccessibleDescription = "Elegir un medio de pago";
            this.MedioPago.FormattingEnabled = true;
            this.MedioPago.Items.AddRange(new object[] {
            "Tarjeta de crédito",
            "Efectivo"});
            this.MedioPago.Location = new System.Drawing.Point(163, 53);
            this.MedioPago.Name = "MedioPago";
            this.MedioPago.Size = new System.Drawing.Size(121, 21);
            this.MedioPago.TabIndex = 0;
            this.MedioPago.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Efectuar_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 446);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Efectuar_Compra";
            this.Text = "Efectuar_Compra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SuperGroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SuperButton button1;
        private SuperLabel label1;
        private SuperComboBox MedioPago;
        private SuperGroupBox groupBox2;
        private SuperLabel label6;
        private SuperTextBox CodigoSeguridad;
        private SuperLabel label5;
        private SuperTextBox NumeroTarjeta;
        private SuperLabel label4;
        private SuperDateTimePicker FechaExpiracion;
        private SuperLabel label3;
        private SuperComboBox TipoTarjeta;
        private SuperButton button2;
        private SuperLabel label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private SuperLabel label7;
        private SuperNumericUpDown Cuotas;
    }
}
﻿using AerolineaFrba.SuperControls;
namespace AerolineaFrba.Abm_Ruta
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
            this.Cerrar = new AerolineaFrba.SuperControls.SuperButton();
            this.Codigo = new AerolineaFrba.SuperControls.SuperTextBox();
            this.Origen = new AerolineaFrba.SuperControls.SuperComboBox();
            this.Destino = new AerolineaFrba.SuperControls.SuperComboBox();
            this.label1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label4 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label5 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label6 = new AerolineaFrba.SuperControls.SuperLabel();
            this.PrecioKG = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            this.PrecioPasaje = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            this.Modificar = new AerolineaFrba.SuperControls.SuperButton();
            this.datosRuta = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.servicios = new AerolineaFrba.SuperControls.SuperCheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioKG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioPasaje)).BeginInit();
            this.datosRuta.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(336, 362);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 16;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Codigo
            // 
            this.Codigo.AccessibleDescription = "Código de la ruta";
            this.Codigo.Location = new System.Drawing.Point(190, 52);
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Size = new System.Drawing.Size(120, 20);
            this.Codigo.TabIndex = 17;
            // 
            // Origen
            // 
            this.Origen.AccessibleDescription = "Ciudad origen";
            this.Origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Origen.FormattingEnabled = true;
            this.Origen.Location = new System.Drawing.Point(165, 81);
            this.Origen.Name = "Origen";
            this.Origen.Size = new System.Drawing.Size(121, 21);
            this.Origen.TabIndex = 18;
            // 
            // Destino
            // 
            this.Destino.AccessibleDescription = "Ciudad destino";
            this.Destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Destino.FormattingEnabled = true;
            this.Destino.Location = new System.Drawing.Point(165, 127);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(121, 21);
            this.Destino.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Precio base por Kg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Precio base por pasaje";
            // 
            // PrecioKG
            // 
            this.PrecioKG.AccessibleDescription = "Precio base por Kg. en encomiendas";
            this.PrecioKG.DecimalPlaces = 2;
            this.PrecioKG.Location = new System.Drawing.Point(190, 274);
            this.PrecioKG.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PrecioKG.Name = "PrecioKG";
            this.PrecioKG.Size = new System.Drawing.Size(120, 20);
            this.PrecioKG.TabIndex = 29;
            // 
            // PrecioPasaje
            // 
            this.PrecioPasaje.AccessibleDescription = "Precio base por pasaje";
            this.PrecioPasaje.DecimalPlaces = 2;
            this.PrecioPasaje.Location = new System.Drawing.Point(190, 311);
            this.PrecioPasaje.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PrecioPasaje.Name = "PrecioPasaje";
            this.PrecioPasaje.Size = new System.Drawing.Size(120, 20);
            this.PrecioPasaje.TabIndex = 30;
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(239, 362);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 15;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // datosRuta
            // 
            this.datosRuta.Controls.Add(this.servicios);
            this.datosRuta.Controls.Add(this.label2);
            this.datosRuta.Controls.Add(this.Origen);
            this.datosRuta.Controls.Add(this.Destino);
            this.datosRuta.Controls.Add(this.label3);
            this.datosRuta.Controls.Add(this.label4);
            this.datosRuta.Location = new System.Drawing.Point(25, 87);
            this.datosRuta.Name = "datosRuta";
            this.datosRuta.Size = new System.Drawing.Size(369, 165);
            this.datosRuta.TabIndex = 32;
            this.datosRuta.TabStop = false;
            // 
            // servicios
            // 
            this.servicios.BackColor = System.Drawing.SystemColors.Control;
            this.servicios.CheckOnClick = true;
            this.servicios.FormattingEnabled = true;
            this.servicios.Items.AddRange(new object[] {
            "Primera Clase",
            "Ejecutivo",
            "Turista"});
            this.servicios.Location = new System.Drawing.Point(165, 11);
            this.servicios.Name = "servicios";
            this.servicios.Size = new System.Drawing.Size(104, 64);
            this.servicios.TabIndex = 32;
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 412);
            this.Controls.Add(this.datosRuta);
            this.Controls.Add(this.PrecioPasaje);
            this.Controls.Add(this.PrecioKG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Modificar);
            this.Name = "Modificacion";
            this.Text = "Modificacion";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrecioKG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioPasaje)).EndInit();
            this.datosRuta.ResumeLayout(false);
            this.datosRuta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperButton Modificar;
        private SuperButton Cerrar;
        private SuperTextBox Codigo;
        private SuperComboBox Origen;
        private SuperComboBox Destino;
        private SuperLabel label1;
        private SuperLabel label2;
        private SuperLabel label3;
        private SuperLabel label4;
        private SuperLabel label5;
        private SuperLabel label6;
        private SuperNumericUpDown PrecioKG;
        private SuperNumericUpDown PrecioPasaje;
        private SuperGroupBox datosRuta;
        private SuperCheckedListBox servicios;

    }
}
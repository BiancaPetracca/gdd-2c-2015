using AerolineaFrba.SuperControls;
using System;
namespace AerolineaFrba.Abm_Aeronave
{
    partial class Baja
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
            this.MotivoBajaAeronave = new AerolineaFrba.SuperControls.SuperComboBox();
            this.label2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.fechaReinicio = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.fechaBaja = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.label = new AerolineaFrba.SuperControls.SuperLabel();
            this.Aceptar = new AerolineaFrba.SuperControls.SuperButton();
            this.Cancelar = new AerolineaFrba.SuperControls.SuperButton();
            this.SuspendLayout();
            // 
            // MotivoBajaAeronave
            // 
            this.MotivoBajaAeronave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotivoBajaAeronave.FormattingEnabled = true;
            this.MotivoBajaAeronave.Items.AddRange(new object[] {
            "Fin de vida util",
            "Mantenimiento"});
            this.MotivoBajaAeronave.Location = new System.Drawing.Point(34, 45);
            this.MotivoBajaAeronave.Name = "MotivoBajaAeronave";
            this.MotivoBajaAeronave.Size = new System.Drawing.Size(121, 21);
            this.MotivoBajaAeronave.TabIndex = 9;
            this.MotivoBajaAeronave.SelectedIndexChanged += new System.EventHandler(this.MotivoBajaAeronave_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(174, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de reinicio";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha de baja";
            // 
            // fechaReinicio
            // 
            this.fechaReinicio.AccessibleDescription = "Elegir una fecha de reinicio";
            this.fechaReinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaReinicio.Location = new System.Drawing.Point(177, 113);
            this.fechaReinicio.MinDate = DateTime.Today;
            this.fechaReinicio.Name = "fechaReinicio";
            this.fechaReinicio.Size = new System.Drawing.Size(102, 20);
            this.fechaReinicio.TabIndex = 6;
          
            // 
            // fechaBaja
            // 
            this.fechaBaja.AccessibleDescription = "Elegir una fecha de baja";
            this.fechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaBaja.Location = new System.Drawing.Point(34, 113);
            this.fechaBaja.MinDate = new System.DateTime(2015, 11, 14, 0, 0, 0, 0);
            this.fechaBaja.Name = "fechaBaja";
            this.fechaBaja.Size = new System.Drawing.Size(102, 20);
            this.fechaBaja.TabIndex = 5;
            this.fechaBaja.ValueChanged += new System.EventHandler(this.fechaBaja_ValueChanged);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(31, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 23);
            this.label.TabIndex = 1;
            this.label.Text = "Motivo de baja";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(204, 159);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 0;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(116, 159);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 0;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 216);
            this.Controls.Add(this.MotivoBajaAeronave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaReinicio);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.fechaBaja);
            this.Name = "Baja";
            this.Text = "Baja";
            this.Load += new System.EventHandler(this.Baja_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperButton Aceptar;
        private SuperButton Cancelar;
        private SuperLabel label;
        private SuperDateTimePicker fechaBaja;
        private SuperDateTimePicker fechaReinicio;
        private SuperLabel label1;
        private SuperLabel label2;
        private SuperComboBox MotivoBajaAeronave;
        private string matricula;
        private DateTime fecha;
        

    }
}
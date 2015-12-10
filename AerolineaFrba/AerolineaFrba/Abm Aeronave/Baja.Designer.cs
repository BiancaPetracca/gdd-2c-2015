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
            this.fechaReinicio = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.label = new AerolineaFrba.SuperControls.SuperLabel();
            this.Aceptar = new AerolineaFrba.SuperControls.SuperButton();
            this.Cancelar = new AerolineaFrba.SuperControls.SuperButton();
            this.fechaBaja = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
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
            this.label2.Location = new System.Drawing.Point(158, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de reinicio";
            // 
            // fechaReinicio
            // 
            this.fechaReinicio.AccessibleDescription = "Elegir una fecha de reinicio";
            this.fechaReinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaReinicio.Location = new System.Drawing.Point(161, 113);
            this.fechaReinicio.Name = "fechaReinicio";
            this.fechaReinicio.Size = new System.Drawing.Size(102, 20);
            this.fechaReinicio.TabIndex = 6;
            this.fechaReinicio.ValueChanged += new System.EventHandler(this.fechaReinicio_ValueChanged);
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
            this.Aceptar.Location = new System.Drawing.Point(168, 160);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 0;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(80, 160);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 0;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // fechaBaja
            // 
            this.fechaBaja.AccessibleDescription = "Elegir una fecha de reinicio";
            this.fechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaBaja.Location = new System.Drawing.Point(30, 113);
            this.fechaBaja.Name = "fechaBaja";
            this.fechaBaja.Size = new System.Drawing.Size(102, 20);
            this.fechaBaja.TabIndex = 10;
            this.fechaBaja.ValueChanged += new System.EventHandler(this.fechaBaja_ValueChanged);
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(31, 87);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(75, 13);
            this.superLabel1.TabIndex = 11;
            this.superLabel1.Text = "Fecha de baja";
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 217);
            this.Controls.Add(this.superLabel1);
            this.Controls.Add(this.fechaBaja);
            this.Controls.Add(this.MotivoBajaAeronave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaReinicio);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Name = "Baja";
            this.Text = "Baja";
            this.Load += new System.EventHandler(this.Baja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperButton Aceptar;
        private SuperButton Cancelar;
        private SuperLabel label;
        private SuperDateTimePicker fechaReinicio;
        private SuperLabel label2;
        private SuperComboBox MotivoBajaAeronave;
        private SuperDateTimePicker fechaBaja;
        private SuperLabel superLabel1;

        

    }
}
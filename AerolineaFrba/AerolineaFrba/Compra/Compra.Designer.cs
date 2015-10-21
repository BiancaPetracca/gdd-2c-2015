using AerolineaFrba.SuperControls;
namespace AerolineaFrba.Compra
{
    partial class Compra
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
            this.ComprarPasaje = new System.Windows.Forms.GroupBox();
            this.Cancelar = new AerolineaFrba.SuperControls.SuperButton();
            this.Siguiente = new AerolineaFrba.SuperControls.SuperButton();
            this.Opciones = new System.Windows.Forms.GroupBox();
            this.OpcionesOk = new AerolineaFrba.SuperControls.SuperButton();
            this.label4 = new AerolineaFrba.SuperControls.SuperLabel();
            this.CantPasaje = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            this.Servicio = new AerolineaFrba.SuperControls.SuperCheckedListBox();
            this.Pasajes = new AerolineaFrba.SuperControls.SuperLabel();
            this.label5 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Kgs = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            this.ElegirViaje = new System.Windows.Forms.GroupBox();
            this.ViajeOk = new AerolineaFrba.SuperControls.SuperButton();
            this.label1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.CiudadDestino = new AerolineaFrba.SuperControls.SuperComboBox();
            this.CiudadOrigen = new AerolineaFrba.SuperControls.SuperComboBox();
            this.label3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.FechaViaje = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.label2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.ComprarPasaje.SuspendLayout();
            this.Opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantPasaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kgs)).BeginInit();
            this.ElegirViaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComprarPasaje
            // 
            this.ComprarPasaje.Controls.Add(this.Cancelar);
            this.ComprarPasaje.Controls.Add(this.Siguiente);
            this.ComprarPasaje.Controls.Add(this.Opciones);
            this.ComprarPasaje.Controls.Add(this.ElegirViaje);
            this.ComprarPasaje.Location = new System.Drawing.Point(22, 12);
            this.ComprarPasaje.Name = "ComprarPasaje";
            this.ComprarPasaje.Size = new System.Drawing.Size(790, 420);
            this.ComprarPasaje.TabIndex = 0;
            this.ComprarPasaje.TabStop = false;
            this.ComprarPasaje.Text = "Comprar Pasaje";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(544, 370);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 16;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(637, 370);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(75, 23);
            this.Siguiente.TabIndex = 15;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // Opciones
            // 
            this.Opciones.Controls.Add(this.OpcionesOk);
            this.Opciones.Controls.Add(this.label4);
            this.Opciones.Controls.Add(this.CantPasaje);
            this.Opciones.Controls.Add(this.Servicio);
            this.Opciones.Controls.Add(this.Pasajes);
            this.Opciones.Controls.Add(this.label5);
            this.Opciones.Controls.Add(this.Kgs);
            this.Opciones.Location = new System.Drawing.Point(24, 198);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(733, 123);
            this.Opciones.TabIndex = 14;
            this.Opciones.TabStop = false;
            this.Opciones.Text = "Opciones";
            // 
            // OpcionesOk
            // 
            this.OpcionesOk.Location = new System.Drawing.Point(613, 86);
            this.OpcionesOk.Name = "OpcionesOk";
            this.OpcionesOk.Size = new System.Drawing.Size(75, 23);
            this.OpcionesOk.TabIndex = 14;
            this.OpcionesOk.Text = "Ok";
            this.OpcionesOk.UseVisualStyleBackColor = true;
            this.OpcionesOk.Click += new System.EventHandler(this.OpcionesOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Elegir servicio";
            // 
            // CantPasaje
            // 
            this.CantPasaje.Location = new System.Drawing.Point(588, 36);
            this.CantPasaje.Name = "CantPasaje";
            this.CantPasaje.Size = new System.Drawing.Size(55, 20);
            this.CantPasaje.TabIndex = 13;
            // 
            // Servicio
            // 
            this.Servicio.BackColor = System.Drawing.SystemColors.Control;
            this.Servicio.FormattingEnabled = true;
            this.Servicio.Items.AddRange(new object[] {
            "Pasaje",
            "Encomienda"});
            this.Servicio.Location = new System.Drawing.Point(130, 36);
            this.Servicio.Name = "Servicio";
            this.Servicio.Size = new System.Drawing.Size(88, 34);
            this.Servicio.TabIndex = 8;
            // 
            // Pasajes
            // 
            this.Pasajes.AutoSize = true;
            this.Pasajes.Location = new System.Drawing.Point(493, 36);
            this.Pasajes.Name = "Pasajes";
            this.Pasajes.Size = new System.Drawing.Size(89, 13);
            this.Pasajes.TabIndex = 12;
            this.Pasajes.Text = "Cantidad Pasajes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad Kgs.";
            // 
            // Kgs
            // 
            this.Kgs.Location = new System.Drawing.Point(349, 34);
            this.Kgs.Name = "Kgs";
            this.Kgs.Size = new System.Drawing.Size(55, 20);
            this.Kgs.TabIndex = 10;
            // 
            // ElegirViaje
            // 
            this.ElegirViaje.Controls.Add(this.ViajeOk);
            this.ElegirViaje.Controls.Add(this.label1);
            this.ElegirViaje.Controls.Add(this.CiudadDestino);
            this.ElegirViaje.Controls.Add(this.CiudadOrigen);
            this.ElegirViaje.Controls.Add(this.label3);
            this.ElegirViaje.Controls.Add(this.FechaViaje);
            this.ElegirViaje.Controls.Add(this.label2);
            this.ElegirViaje.Location = new System.Drawing.Point(24, 19);
            this.ElegirViaje.Name = "ElegirViaje";
            this.ElegirViaje.Size = new System.Drawing.Size(733, 150);
            this.ElegirViaje.TabIndex = 6;
            this.ElegirViaje.TabStop = false;
            this.ElegirViaje.Text = "Elegir viaje";
            // 
            // ViajeOk
            // 
            this.ViajeOk.Location = new System.Drawing.Point(613, 111);
            this.ViajeOk.Name = "ViajeOk";
            this.ViajeOk.Size = new System.Drawing.Size(75, 23);
            this.ViajeOk.TabIndex = 6;
            this.ViajeOk.Text = "Ok";
            this.ViajeOk.UseVisualStyleBackColor = true;
            this.ViajeOk.Click += new System.EventHandler(this.ViajeOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elegir fecha";
            // 
            // CiudadDestino
            // 
            this.CiudadDestino.FormattingEnabled = true;
            this.CiudadDestino.Location = new System.Drawing.Point(467, 74);
            this.CiudadDestino.Name = "CiudadDestino";
            this.CiudadDestino.Size = new System.Drawing.Size(221, 21);
            this.CiudadDestino.TabIndex = 5;
            // 
            // CiudadOrigen
            // 
            this.CiudadOrigen.Location = new System.Drawing.Point(106, 74);
            this.CiudadOrigen.Name = "CiudadOrigen";
            this.CiudadOrigen.Size = new System.Drawing.Size(221, 21);
            this.CiudadOrigen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ciudad Destino";
            // 
            // FechaViaje
            // 
            this.FechaViaje.CustomFormat = "dd/mm/yyyy hh:mm:ss";
            this.FechaViaje.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaViaje.Location = new System.Drawing.Point(106, 33);
            this.FechaViaje.Name = "FechaViaje";
            this.FechaViaje.Size = new System.Drawing.Size(145, 20);
            this.FechaViaje.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciudad Origen";
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 489);
            this.Controls.Add(this.ComprarPasaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compra";
            this.Text = "Comprar Pasaje";
            this.ComprarPasaje.ResumeLayout(false);
            this.Opciones.ResumeLayout(false);
            this.Opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantPasaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kgs)).EndInit();
            this.ElegirViaje.ResumeLayout(false);
            this.ElegirViaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ComprarPasaje;
        private SuperDateTimePicker FechaViaje;
        private SuperComboBox CiudadOrigen;
        private SuperComboBox CiudadDestino;
        private SuperLabel label3;
        private SuperLabel label2;
        private SuperLabel label1;
        private System.Windows.Forms.GroupBox ElegirViaje;
        private SuperNumericUpDown Kgs;
        private SuperLabel label5;
        private SuperCheckedListBox Servicio;
        private SuperLabel label4;
        private SuperButton ViajeOk;
        private SuperNumericUpDown CantPasaje;
        private SuperLabel Pasajes;
        private SuperButton Cancelar;
        private SuperButton Siguiente;
        private System.Windows.Forms.GroupBox Opciones;
        private SuperButton OpcionesOk;

    }
}
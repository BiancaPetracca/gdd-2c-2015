using AerolineaFrba.Generics;
using AerolineaFrba.Properties;
using AerolineaFrba.SuperControls;
using System;
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
            this.ComprarPasaje = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.Cancelar = new AerolineaFrba.SuperControls.SuperButton();
            this.IngresarDatos = new AerolineaFrba.SuperControls.SuperButton();
            this.Pasaje = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_encomiendas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pasajes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opciones = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.OpcionesOk = new AerolineaFrba.SuperControls.SuperButton();
            this.cant_pasajes = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            this.Pasajes = new AerolineaFrba.SuperControls.SuperLabel();
            this.label5 = new AerolineaFrba.SuperControls.SuperLabel();
            this.encomienda = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            this.ElegirViaje = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.fechaLlegada = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.ViajeOk = new AerolineaFrba.SuperControls.SuperButton();
            this.label1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.CiudadDestino = new AerolineaFrba.SuperControls.SuperComboBox();
            this.CiudadOrigen = new AerolineaFrba.SuperControls.SuperComboBox();
            this.label3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.fechaSalida = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.label2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.ComprarPasaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pasaje)).BeginInit();
            this.Opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cant_pasajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomienda)).BeginInit();
            this.ElegirViaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComprarPasaje
            // 
            this.ComprarPasaje.AccessibleDescription = "Comprar pasaje";
            this.ComprarPasaje.Controls.Add(this.Cancelar);
            this.ComprarPasaje.Controls.Add(this.IngresarDatos);
            this.ComprarPasaje.Controls.Add(this.Pasaje);
            this.ComprarPasaje.Controls.Add(this.Opciones);
            this.ComprarPasaje.Controls.Add(this.ElegirViaje);
            this.ComprarPasaje.Location = new System.Drawing.Point(24, 12);
            this.ComprarPasaje.Name = "ComprarPasaje";
            this.ComprarPasaje.Size = new System.Drawing.Size(1171, 417);
            this.ComprarPasaje.TabIndex = 0;
            this.ComprarPasaje.TabStop = false;
            this.ComprarPasaje.Text = "Comprar Pasaje";
            this.ComprarPasaje.Enter += new System.EventHandler(this.ComprarPasaje_Enter);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(848, 365);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 16;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // IngresarDatos
            // 
            this.IngresarDatos.Location = new System.Drawing.Point(973, 365);
            this.IngresarDatos.Name = "IngresarDatos";
            this.IngresarDatos.Size = new System.Drawing.Size(122, 23);
            this.IngresarDatos.TabIndex = 15;
            this.IngresarDatos.Text = "Ingresar Datos";
            this.IngresarDatos.UseVisualStyleBackColor = true;
            this.IngresarDatos.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // Pasaje
            // 
            this.Pasaje.AllowUserToAddRows = false;
            this.Pasaje.AllowUserToDeleteRows = false;
            this.Pasaje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Pasaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pasaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_salida,
            this.col_estimada,
            this.col_origen,
            this.col_destino,
            this.col_servicio,
            this.col_encomiendas,
            this.col_pasajes});
            this.Pasaje.Location = new System.Drawing.Point(189, 235);
            this.Pasaje.Name = "Pasaje";
            this.Pasaje.ReadOnly = true;
            this.Pasaje.Size = new System.Drawing.Size(853, 72);
            this.Pasaje.TabIndex = 15;
            this.Pasaje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pasaje_CellContentClick);
            // 
            // col_codigo
            // 
            this.col_codigo.HeaderText = "Codigo de viaje";
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;
            // 
            // col_salida
            // 
            this.col_salida.HeaderText = "Fecha salida";
            this.col_salida.Name = "col_salida";
            this.col_salida.ReadOnly = true;
            // 
            // col_estimada
            // 
            this.col_estimada.HeaderText = "Fecha llegada";
            this.col_estimada.Name = "col_estimada";
            this.col_estimada.ReadOnly = true;
            // 
            // col_origen
            // 
            this.col_origen.HeaderText = "Ciudad origen";
            this.col_origen.Name = "col_origen";
            this.col_origen.ReadOnly = true;
            // 
            // col_destino
            // 
            this.col_destino.HeaderText = "Ciudad destino";
            this.col_destino.Name = "col_destino";
            this.col_destino.ReadOnly = true;
            // 
            // col_servicio
            // 
            this.col_servicio.HeaderText = "Servicio";
            this.col_servicio.Name = "col_servicio";
            this.col_servicio.ReadOnly = true;
            this.col_servicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_encomiendas
            // 
            this.col_encomiendas.HeaderText = "Kgs. Encomienda";
            this.col_encomiendas.Name = "col_encomiendas";
            this.col_encomiendas.ReadOnly = true;
            // 
            // col_pasajes
            // 
            this.col_pasajes.HeaderText = "Número de pasajes";
            this.col_pasajes.Name = "col_pasajes";
            this.col_pasajes.ReadOnly = true;
            // 
            // Opciones
            // 
            this.Opciones.Controls.Add(this.OpcionesOk);
            this.Opciones.Controls.Add(this.cant_pasajes);
            this.Opciones.Controls.Add(this.Pasajes);
            this.Opciones.Controls.Add(this.label5);
            this.Opciones.Controls.Add(this.encomienda);
            this.Opciones.Location = new System.Drawing.Point(783, 36);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(364, 150);
            this.Opciones.TabIndex = 14;
            this.Opciones.TabStop = false;
            this.Opciones.Text = "Elegir servicio";
            // 
            // OpcionesOk
            // 
            this.OpcionesOk.Location = new System.Drawing.Point(278, 65);
            this.OpcionesOk.Name = "OpcionesOk";
            this.OpcionesOk.Size = new System.Drawing.Size(47, 23);
            this.OpcionesOk.TabIndex = 14;
            this.OpcionesOk.Text = "Ok";
            this.OpcionesOk.UseVisualStyleBackColor = true;
            this.OpcionesOk.Click += new System.EventHandler(this.OpcionesOk_Click);
            // 
            // cant_pasajes
            // 
            this.cant_pasajes.AccessibleDescription = "Cantidad de pasajes";
            this.cant_pasajes.Location = new System.Drawing.Point(178, 93);
            this.cant_pasajes.Name = "cant_pasajes";
            this.cant_pasajes.ReadOnly = true;
            this.cant_pasajes.Size = new System.Drawing.Size(55, 20);
            this.cant_pasajes.TabIndex = 13;
            // 
            // Pasajes
            // 
            this.Pasajes.AutoSize = true;
            this.Pasajes.Location = new System.Drawing.Point(45, 98);
            this.Pasajes.Name = "Pasajes";
            this.Pasajes.Size = new System.Drawing.Size(44, 13);
            this.Pasajes.TabIndex = 12;
            this.Pasajes.Text = "Pasajes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Encomienda (Kgs)";
            // 
            // encomienda
            // 
            this.encomienda.AccessibleDescription = "Peso de la encomienda";
            this.encomienda.Location = new System.Drawing.Point(178, 31);
            this.encomienda.Name = "encomienda";
            this.encomienda.ReadOnly = true;
            this.encomienda.Size = new System.Drawing.Size(55, 20);
            this.encomienda.TabIndex = 10;
            this.encomienda.ValueChanged += new System.EventHandler(this.Kgs_ValueChanged);
            // 
            // ElegirViaje
            // 
            this.ElegirViaje.Controls.Add(this.superLabel1);
            this.ElegirViaje.Controls.Add(this.fechaLlegada);
            this.ElegirViaje.Controls.Add(this.ViajeOk);
            this.ElegirViaje.Controls.Add(this.label1);
            this.ElegirViaje.Controls.Add(this.CiudadDestino);
            this.ElegirViaje.Controls.Add(this.CiudadOrigen);
            this.ElegirViaje.Controls.Add(this.label3);
            this.ElegirViaje.Controls.Add(this.fechaSalida);
            this.ElegirViaje.Controls.Add(this.label2);
            this.ElegirViaje.Location = new System.Drawing.Point(18, 36);
            this.ElegirViaje.Name = "ElegirViaje";
            this.ElegirViaje.Size = new System.Drawing.Size(733, 150);
            this.ElegirViaje.TabIndex = 6;
            this.ElegirViaje.TabStop = false;
            this.ElegirViaje.Text = "Elegir viaje";
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(300, 43);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(74, 13);
            this.superLabel1.TabIndex = 8;
            this.superLabel1.Text = "Fecha llegada";
            // 
            // fechaLlegada
            // 
            this.fechaLlegada.AccessibleDescription = "Fecha del viaje";
            this.fechaLlegada.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaLlegada.Location = new System.Drawing.Point(416, 41);
            this.fechaLlegada.Name = "fechaLlegada";
            this.fechaLlegada.Size = new System.Drawing.Size(144, 20);
            this.fechaLlegada.TabIndex = 7;
            // 
            // ViajeOk
            // 
            this.ViajeOk.Location = new System.Drawing.Point(606, 65);
            this.ViajeOk.Name = "ViajeOk";
            this.ViajeOk.Size = new System.Drawing.Size(45, 23);
            this.ViajeOk.TabIndex = 6;
            this.ViajeOk.Text = "Ok";
            this.ViajeOk.UseVisualStyleBackColor = true;
            this.ViajeOk.Click += new System.EventHandler(this.ViajeOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha salida";
            // 
            // CiudadDestino
            // 
            this.CiudadDestino.AccessibleDescription = "Ciudad destino";
            this.CiudadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CiudadDestino.FormattingEnabled = true;
            this.CiudadDestino.Location = new System.Drawing.Point(416, 98);
            this.CiudadDestino.Name = "CiudadDestino";
            this.CiudadDestino.Size = new System.Drawing.Size(144, 21);
            this.CiudadDestino.TabIndex = 5;
            // 
            // CiudadOrigen
            // 
            this.CiudadOrigen.AccessibleDescription = "Ciudad origen";
            this.CiudadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CiudadOrigen.FormattingEnabled = true;
            this.CiudadOrigen.Location = new System.Drawing.Point(130, 98);
            this.CiudadOrigen.Name = "CiudadOrigen";
            this.CiudadOrigen.Size = new System.Drawing.Size(140, 21);
            this.CiudadOrigen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ciudad Destino";
            // 
            // fechaSalida
            // 
            this.fechaSalida.AccessibleDescription = "Fecha del viaje";
            this.fechaSalida.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaSalida.Location = new System.Drawing.Point(130, 41);
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Size = new System.Drawing.Size(140, 20);
            this.fechaSalida.TabIndex = 0;
            this.fechaSalida.ValueChanged += new System.EventHandler(this.fechaSalida_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciudad Origen";
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 495);
            this.Controls.Add(this.ComprarPasaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compra";
            this.Text = "Comprar Pasaje";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.ComprarPasaje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pasaje)).EndInit();
            this.Opciones.ResumeLayout(false);
            this.Opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cant_pasajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomienda)).EndInit();
            this.ElegirViaje.ResumeLayout(false);
            this.ElegirViaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SuperGroupBox ComprarPasaje;
        private SuperDateTimePicker fechaSalida;
        private SuperLabel label3;
        private SuperLabel label2;
        private SuperLabel label1;
        private SuperGroupBox ElegirViaje;
        private SuperNumericUpDown encomienda;
        private SuperLabel label5;
        private SuperButton Cancelar;
        private SuperButton IngresarDatos;
        private SuperButton OpcionesOk;
        private SuperComboBox CiudadOrigen;
        private SuperComboBox CiudadDestino;
        private System.Windows.Forms.DataGridView Pasaje;
        private SuperGroupBox Opciones;
        private SuperButton ViajeOk;
        private SuperNumericUpDown cant_pasajes;
        private SuperLabel Pasajes;
        private SuperLabel superLabel1;
        private SuperDateTimePicker fechaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estimada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_encomiendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pasajes;
        
    

    }
}
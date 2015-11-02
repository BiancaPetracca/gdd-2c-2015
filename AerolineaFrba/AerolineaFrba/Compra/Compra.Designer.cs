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
            this.ComprarPasaje = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.Cancelar = new AerolineaFrba.SuperControls.SuperButton();
            this.Siguiente = new AerolineaFrba.SuperControls.SuperButton();
            this.Pasaje = new System.Windows.Forms.DataGridView();
            this.Opciones = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.OpcionesOk = new AerolineaFrba.SuperControls.SuperButton();
            this.label4 = new AerolineaFrba.SuperControls.SuperLabel();
            this.CantPasaje = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            this.Servicio = new AerolineaFrba.SuperControls.SuperCheckedListBox();
            this.Pasajes = new AerolineaFrba.SuperControls.SuperLabel();
            this.label5 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Kgs = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            this.ElegirViaje = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.ViajeOk = new AerolineaFrba.SuperControls.SuperButton();
            this.label1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.CiudadDestino = new AerolineaFrba.SuperControls.SuperComboBox();
            this.CiudadOrigen = new AerolineaFrba.SuperControls.SuperComboBox();
            this.label3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.FechaViaje = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.label2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.FechaViajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiudadOrigenCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiudadDestinoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KgsEncomiendaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantPasajesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComprarPasaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pasaje)).BeginInit();
            this.Opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantPasaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kgs)).BeginInit();
            this.ElegirViaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComprarPasaje
            // 
            this.ComprarPasaje.AccessibleDescription = "Comprar pasaje";
            this.ComprarPasaje.Controls.Add(this.Cancelar);
            this.ComprarPasaje.Controls.Add(this.Siguiente);
            this.ComprarPasaje.Controls.Add(this.Pasaje);
            this.ComprarPasaje.Controls.Add(this.Opciones);
            this.ComprarPasaje.Controls.Add(this.ElegirViaje);
            this.ComprarPasaje.Location = new System.Drawing.Point(22, 12);
            this.ComprarPasaje.Name = "ComprarPasaje";
            this.ComprarPasaje.Size = new System.Drawing.Size(788, 391);
            this.ComprarPasaje.TabIndex = 0;
            this.ComprarPasaje.TabStop = false;
            this.ComprarPasaje.Text = "Comprar Pasaje";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(600, 337);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 16;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(693, 337);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(75, 23);
            this.Siguiente.TabIndex = 15;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // Pasaje
            // 
            this.Pasaje.AllowUserToAddRows = false;
            this.Pasaje.AllowUserToDeleteRows = false;
            this.Pasaje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Pasaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pasaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaViajar,
            this.CiudadOrigenCol,
            this.CiudadDestinoCol,
            this.ServicioCol,
            this.KgsEncomiendaCol,
            this.CantPasajesCol});
            this.Pasaje.Location = new System.Drawing.Point(24, 220);
            this.Pasaje.Name = "Pasaje";
            this.Pasaje.Size = new System.Drawing.Size(744, 72);
            this.Pasaje.TabIndex = 15;
            this.Pasaje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pasaje_CellContentClick);
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
            this.Opciones.Location = new System.Drawing.Point(417, 19);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(351, 150);
            this.Opciones.TabIndex = 14;
            this.Opciones.TabStop = false;
            this.Opciones.Text = "Opciones";
            // 
            // OpcionesOk
            // 
            this.OpcionesOk.Location = new System.Drawing.Point(277, 107);
            this.OpcionesOk.Name = "OpcionesOk";
            this.OpcionesOk.Size = new System.Drawing.Size(47, 23);
            this.OpcionesOk.TabIndex = 14;
            this.OpcionesOk.Text = "Ok";
            this.OpcionesOk.UseVisualStyleBackColor = true;
            this.OpcionesOk.Click += new System.EventHandler(this.OpcionesOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Elegir servicio";
            // 
            // CantPasaje
            // 
            this.CantPasaje.AccessibleDescription = "Cantidad de pasajes";
            this.CantPasaje.Location = new System.Drawing.Point(75, 112);
            this.CantPasaje.Name = "CantPasaje";
            this.CantPasaje.Size = new System.Drawing.Size(55, 20);
            this.CantPasaje.TabIndex = 13;
            // 
            // Servicio
            // 
            this.Servicio.AccessibleDescription = "Servicio(s) que va a elegir";
            this.Servicio.BackColor = System.Drawing.SystemColors.Control;
            this.Servicio.CheckOnClick = true;
            this.Servicio.FormattingEnabled = true;
            this.Servicio.Items.AddRange(new object[] {
            "Pasaje",
            "Encomienda"});
            this.Servicio.Location = new System.Drawing.Point(104, 19);
            this.Servicio.Name = "Servicio";
            this.Servicio.Size = new System.Drawing.Size(89, 34);
            this.Servicio.TabIndex = 8;
            // 
            // Pasajes
            // 
            this.Pasajes.AutoSize = true;
            this.Pasajes.Location = new System.Drawing.Point(17, 112);
            this.Pasajes.Name = "Pasajes";
            this.Pasajes.Size = new System.Drawing.Size(44, 13);
            this.Pasajes.TabIndex = 12;
            this.Pasajes.Text = "Pasajes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kgs.";
            // 
            // Kgs
            // 
            this.Kgs.AccessibleDescription = "Peso de la encomienda";
            this.Kgs.Location = new System.Drawing.Point(75, 66);
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
            this.ElegirViaje.Size = new System.Drawing.Size(383, 150);
            this.ElegirViaje.TabIndex = 6;
            this.ElegirViaje.TabStop = false;
            this.ElegirViaje.Text = "Elegir viaje";
            // 
            // ViajeOk
            // 
            this.ViajeOk.Location = new System.Drawing.Point(314, 111);
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
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elegir fecha";
            // 
            // CiudadDestino
            // 
            this.CiudadDestino.AccessibleDescription = "Ciudad destino";
            this.CiudadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CiudadDestino.FormattingEnabled = true;
            this.CiudadDestino.Location = new System.Drawing.Point(113, 111);
            this.CiudadDestino.Name = "CiudadDestino";
            this.CiudadDestino.Size = new System.Drawing.Size(182, 21);
            this.CiudadDestino.TabIndex = 5;
            // 
            // CiudadOrigen
            // 
            this.CiudadOrigen.AccessibleDescription = "Ciudad origen";
            this.CiudadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CiudadOrigen.FormattingEnabled = true;
            this.CiudadOrigen.Location = new System.Drawing.Point(113, 70);
            this.CiudadOrigen.Name = "CiudadOrigen";
            this.CiudadOrigen.Size = new System.Drawing.Size(182, 21);
            this.CiudadOrigen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ciudad Destino";
            // 
            // FechaViaje
            // 
            this.FechaViaje.AccessibleDescription = "Fecha del viaje";
            this.FechaViaje.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.FechaViaje.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaViaje.Location = new System.Drawing.Point(106, 33);
            this.FechaViaje.Name = "FechaViaje";
            this.FechaViaje.Size = new System.Drawing.Size(145, 20);
            this.FechaViaje.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciudad Origen";
            // 
            // FechaViajar
            // 
            this.FechaViajar.HeaderText = "Fecha ";
            this.FechaViajar.Name = "FechaViajar";
            // 
            // CiudadOrigenCol
            // 
            this.CiudadOrigenCol.HeaderText = "Ciudad origen";
            this.CiudadOrigenCol.Name = "CiudadOrigenCol";
            // 
            // CiudadDestinoCol
            // 
            this.CiudadDestinoCol.HeaderText = "Ciudad destino";
            this.CiudadDestinoCol.Name = "CiudadDestinoCol";
            // 
            // ServicioCol
            // 
            this.ServicioCol.HeaderText = "Servicio";
            this.ServicioCol.Name = "ServicioCol";
            this.ServicioCol.ReadOnly = true;
            this.ServicioCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
           
            // 
            // KgsEncomiendaCol
            // 
            this.KgsEncomiendaCol.HeaderText = "Kgs. Encomienda";
            this.KgsEncomiendaCol.Name = "KgsEncomiendaCol";
            // 
            // CantPasajesCol
            // 
            this.CantPasajesCol.HeaderText = "Número de pasajes";
            this.CantPasajesCol.Name = "CantPasajesCol";
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
            this.Load += new System.EventHandler(this.Compra_Load);
            this.ComprarPasaje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pasaje)).EndInit();
            this.Opciones.ResumeLayout(false);
            this.Opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantPasaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kgs)).EndInit();
            this.ElegirViaje.ResumeLayout(false);
            this.ElegirViaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SuperGroupBox ComprarPasaje;
        private SuperDateTimePicker FechaViaje;
        private SuperLabel label3;
        private SuperLabel label2;
        private SuperLabel label1;
        private SuperGroupBox ElegirViaje;
        private SuperNumericUpDown Kgs;
        private SuperLabel label5;
        private SuperCheckedListBox Servicio;
        private SuperLabel label4;
        private SuperButton ViajeOk;
        private SuperNumericUpDown CantPasaje;
        private SuperLabel Pasajes;
        private SuperButton Cancelar;
        private SuperButton Siguiente;
        private SuperGroupBox Opciones;
        private SuperButton OpcionesOk;
        private SuperComboBox CiudadOrigen;
        private SuperComboBox CiudadDestino;
        private System.Windows.Forms.DataGridView Pasaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaViajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadOrigenCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadDestinoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KgsEncomiendaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantPasajesCol;

    }
}
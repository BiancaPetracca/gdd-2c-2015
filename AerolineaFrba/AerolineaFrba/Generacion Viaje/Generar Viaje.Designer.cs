using AerolineaFrba.SuperControls;
namespace AerolineaFrba.Generacion_Viaje
{
    partial class Generar_Viaje
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
            this.viaje = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.rutas = new System.Windows.Forms.DataGridView();
            this.col_ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_preciokg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_preciopasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscarAeronaves = new AerolineaFrba.SuperControls.SuperButton();
            this.label3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.fechaSalida = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.fechaLlegadaEstimada = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.fechaSalidaLabel = new AerolineaFrba.SuperControls.SuperLabel();
            this.NombreAeronave = new AerolineaFrba.SuperControls.SuperComboBox();
            this.aceptar = new AerolineaFrba.SuperControls.SuperButton();
            this.cerrar = new AerolineaFrba.SuperControls.SuperButton();
            this.viaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rutas)).BeginInit();
            this.SuspendLayout();
            // 
            // viaje
            // 
            this.viaje.Controls.Add(this.BuscarAeronaves);
            this.viaje.Controls.Add(this.label3);
            this.viaje.Controls.Add(this.label2);
            this.viaje.Controls.Add(this.fechaSalida);
            this.viaje.Controls.Add(this.fechaLlegadaEstimada);
            this.viaje.Controls.Add(this.fechaSalidaLabel);
            this.viaje.Controls.Add(this.NombreAeronave);
            this.viaje.Location = new System.Drawing.Point(12, 12);
            this.viaje.Name = "viaje";
            this.viaje.Size = new System.Drawing.Size(857, 176);
            this.viaje.TabIndex = 0;
            this.viaje.TabStop = false;
            this.viaje.Text = "Generar Viaje";
            // 
            // rutas
            // 
            this.rutas.AllowUserToAddRows = false;
            this.rutas.AllowUserToDeleteRows = false;
            this.rutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ruta,
            this.col_origen,
            this.col_destino,
            this.col_servicio,
            this.col_preciokg,
            this.col_preciopasaje});
            this.rutas.Location = new System.Drawing.Point(12, 204);
            this.rutas.MultiSelect = false;
            this.rutas.Name = "rutas";
            this.rutas.ReadOnly = true;
            this.rutas.Size = new System.Drawing.Size(857, 159);
            this.rutas.TabIndex = 13;
            // 
            // col_ruta
            // 
            this.col_ruta.HeaderText = "Código de ruta";
            this.col_ruta.Name = "col_ruta";
            this.col_ruta.ReadOnly = true;
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
            // 
            // col_preciokg
            // 
            this.col_preciokg.HeaderText = "Precio base por kg.";
            this.col_preciokg.Name = "col_preciokg";
            this.col_preciokg.ReadOnly = true;
            // 
            // col_preciopasaje
            // 
            this.col_preciopasaje.HeaderText = "Precio base por pasaje";
            this.col_preciopasaje.Name = "col_preciopasaje";
            this.col_preciopasaje.ReadOnly = true;
            // 
            // BuscarAeronaves
            // 
            this.BuscarAeronaves.Location = new System.Drawing.Point(484, 75);
            this.BuscarAeronaves.Name = "BuscarAeronaves";
            this.BuscarAeronaves.Size = new System.Drawing.Size(108, 23);
            this.BuscarAeronaves.TabIndex = 12;
            this.BuscarAeronaves.Text = "Confirmar fechas";
            this.BuscarAeronaves.UseVisualStyleBackColor = true;
            this.BuscarAeronaves.Click += new System.EventHandler(this.BuscarAeronaves_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(52, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aeronave";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(52, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de llegada estimada";
            // 
            // fechaSalida
            // 
            this.fechaSalida.AccessibleDescription = "Fecha de salida";
            this.fechaSalida.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.fechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaSalida.Location = new System.Drawing.Point(229, 46);
            this.fechaSalida.MinDate = Generics.Config.DateToday;
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Size = new System.Drawing.Size(162, 20);
            this.fechaSalida.TabIndex = 0;
            this.fechaSalida.ValueChanged += new System.EventHandler(this.fechaSalida_ValueChanged);
            // 
            // fechaLlegadaEstimada
            // 
            this.fechaLlegadaEstimada.AccessibleDescription = "Fecha de llegada estimada";
            this.fechaLlegadaEstimada.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.fechaLlegadaEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaLlegadaEstimada.Location = new System.Drawing.Point(229, 90);
            this.fechaLlegadaEstimada.MinDate = Generics.Config.DateToday;
            this.fechaLlegadaEstimada.Name = "fechaLlegadaEstimada";
            this.fechaLlegadaEstimada.Size = new System.Drawing.Size(162, 20);
            this.fechaLlegadaEstimada.TabIndex = 2;
            this.fechaLlegadaEstimada.ValueChanged += new System.EventHandler(this.fechaLlegadaEstimada_ValueChanged);
            // 
            // fechaSalidaLabel
            // 
            this.fechaSalidaLabel.Location = new System.Drawing.Point(52, 46);
            this.fechaSalidaLabel.Name = "fechaSalidaLabel";
            this.fechaSalidaLabel.Size = new System.Drawing.Size(131, 20);
            this.fechaSalidaLabel.TabIndex = 3;
            this.fechaSalidaLabel.Text = "Fecha de salida";
            // 
            // NombreAeronave
            // 
            this.NombreAeronave.AccessibleDescription = "Nombre de la aeronave";
            this.NombreAeronave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NombreAeronave.Location = new System.Drawing.Point(229, 136);
            this.NombreAeronave.Name = "NombreAeronave";
            this.NombreAeronave.Size = new System.Drawing.Size(162, 21);
            this.NombreAeronave.TabIndex = 8;
            this.NombreAeronave.SelectedIndexChanged += new System.EventHandler(this.NombreAeronave_SelectedIndexChanged);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(676, 378);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 0;
            this.aceptar.Text = "Aceptar";
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(794, 378);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 0;
            this.cerrar.Text = "Cerrar";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Generar_Viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(895, 433);
            this.Controls.Add(this.rutas);
            this.Controls.Add(this.viaje);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Generar_Viaje";
            this.Text = "Generar Viaje";
            this.Load += new System.EventHandler(this.Generar_Viaje_Load);
            this.viaje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rutas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SuperGroupBox viaje;
        private SuperDateTimePicker fechaSalida;
        private SuperDateTimePicker fechaLlegadaEstimada;
        private SuperLabel fechaSalidaLabel;
        private SuperLabel label2;
        private SuperLabel label3;
        private SuperComboBox NombreAeronave;
        private SuperButton aceptar;
        private SuperButton cerrar;
        private SuperButton BuscarAeronaves;
        private System.Windows.Forms.DataGridView rutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_preciokg;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_preciopasaje;

    }
}

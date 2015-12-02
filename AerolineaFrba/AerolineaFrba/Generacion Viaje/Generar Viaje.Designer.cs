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
            this.lab_origen = new AerolineaFrba.SuperControls.SuperLabel();
            this.lab_destino = new AerolineaFrba.SuperControls.SuperLabel();
            this.Destino = new AerolineaFrba.SuperControls.SuperComboBox();
            this.label3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.NombreAeronave = new AerolineaFrba.SuperControls.SuperComboBox();
            this.Origen = new AerolineaFrba.SuperControls.SuperComboBox();
            this.BuscarAeronaves = new AerolineaFrba.SuperControls.SuperButton();
            this.label2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.fechaSalida = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.fechaLlegadaEstimada = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.fechaSalidaLabel = new AerolineaFrba.SuperControls.SuperLabel();
            this.rutas = new System.Windows.Forms.DataGridView();
            this.aceptar = new AerolineaFrba.SuperControls.SuperButton();
            this.cerrar = new AerolineaFrba.SuperControls.SuperButton();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_llegada_estimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_preciokg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_preciopasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rutas)).BeginInit();
            this.SuspendLayout();
            // 
            // viaje
            // 
            this.viaje.Controls.Add(this.lab_origen);
            this.viaje.Controls.Add(this.lab_destino);
            this.viaje.Controls.Add(this.Destino);
            this.viaje.Controls.Add(this.label3);
            this.viaje.Controls.Add(this.NombreAeronave);
            this.viaje.Controls.Add(this.Origen);
            this.viaje.Controls.Add(this.BuscarAeronaves);
            this.viaje.Controls.Add(this.label2);
            this.viaje.Controls.Add(this.fechaSalida);
            this.viaje.Controls.Add(this.fechaLlegadaEstimada);
            this.viaje.Controls.Add(this.fechaSalidaLabel);
            this.viaje.Location = new System.Drawing.Point(12, 12);
            this.viaje.Name = "viaje";
            this.viaje.Size = new System.Drawing.Size(1003, 112);
            this.viaje.TabIndex = 0;
            this.viaje.TabStop = false;
            this.viaje.Text = "Generar Viaje";
            // 
            // lab_origen
            // 
            this.lab_origen.Location = new System.Drawing.Point(418, 42);
            this.lab_origen.Name = "lab_origen";
            this.lab_origen.Size = new System.Drawing.Size(54, 20);
            this.lab_origen.TabIndex = 16;
            this.lab_origen.Text = "Origen";
            // 
            // lab_destino
            // 
            this.lab_destino.Location = new System.Drawing.Point(418, 68);
            this.lab_destino.Name = "lab_destino";
            this.lab_destino.Size = new System.Drawing.Size(54, 20);
            this.lab_destino.TabIndex = 15;
            this.lab_destino.Text = "Destino";
            // 
            // Destino
            // 
            this.Destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Destino.FormattingEnabled = true;
            this.Destino.Location = new System.Drawing.Point(478, 69);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(146, 21);
            this.Destino.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(792, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aeronave";
            // 
            // NombreAeronave
            // 
            this.NombreAeronave.AccessibleDescription = "Nombre de la aeronave";
            this.NombreAeronave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NombreAeronave.Location = new System.Drawing.Point(795, 65);
            this.NombreAeronave.Name = "NombreAeronave";
            this.NombreAeronave.Size = new System.Drawing.Size(162, 21);
            this.NombreAeronave.TabIndex = 8;
            // 
            // Origen
            // 
            this.Origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Origen.FormattingEnabled = true;
            this.Origen.Location = new System.Drawing.Point(478, 39);
            this.Origen.Name = "Origen";
            this.Origen.Size = new System.Drawing.Size(146, 21);
            this.Origen.TabIndex = 13;
            // 
            // BuscarAeronaves
            // 
            this.BuscarAeronaves.Location = new System.Drawing.Point(659, 54);
            this.BuscarAeronaves.Name = "BuscarAeronaves";
            this.BuscarAeronaves.Size = new System.Drawing.Size(77, 23);
            this.BuscarAeronaves.TabIndex = 12;
            this.BuscarAeronaves.Text = "Confirmar";
            this.BuscarAeronaves.UseVisualStyleBackColor = true;
            this.BuscarAeronaves.Click += new System.EventHandler(this.BuscarAeronaves_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(46, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de llegada estimada";
            // 
            // fechaSalida
            // 
            this.fechaSalida.AccessibleDescription = "Fecha de salida";
            this.fechaSalida.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaSalida.Location = new System.Drawing.Point(223, 43);
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Size = new System.Drawing.Size(162, 20);
            this.fechaSalida.TabIndex = 0;
            this.fechaSalida.ValueChanged += new System.EventHandler(this.fechaSalida_ValueChanged);
            // 
            // fechaLlegadaEstimada
            // 
            this.fechaLlegadaEstimada.AccessibleDescription = "Fecha de llegada estimada";
            this.fechaLlegadaEstimada.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fechaLlegadaEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaLlegadaEstimada.Location = new System.Drawing.Point(223, 69);
            this.fechaLlegadaEstimada.Name = "fechaLlegadaEstimada";
            this.fechaLlegadaEstimada.Size = new System.Drawing.Size(162, 20);
            this.fechaLlegadaEstimada.TabIndex = 2;
            this.fechaLlegadaEstimada.ValueChanged += new System.EventHandler(this.fechaLlegadaEstimada_ValueChanged);
            // 
            // fechaSalidaLabel
            // 
            this.fechaSalidaLabel.Location = new System.Drawing.Point(46, 43);
            this.fechaSalidaLabel.Name = "fechaSalidaLabel";
            this.fechaSalidaLabel.Size = new System.Drawing.Size(131, 20);
            this.fechaSalidaLabel.TabIndex = 3;
            this.fechaSalidaLabel.Text = "Fecha de salida";
            // 
            // rutas
            // 
            this.rutas.AllowUserToAddRows = false;
            this.rutas.AllowUserToDeleteRows = false;
            this.rutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_fecha_salida,
            this.col_fecha_llegada_estimada,
            this.col_origen,
            this.col_destino,
            this.col_servicio,
            this.col_preciokg,
            this.col_preciopasaje});
            this.rutas.Location = new System.Drawing.Point(12, 174);
            this.rutas.MultiSelect = false;
            this.rutas.Name = "rutas";
            this.rutas.ReadOnly = true;
            this.rutas.Size = new System.Drawing.Size(1003, 82);
            this.rutas.TabIndex = 13;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(704, 360);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 0;
            this.aceptar.Text = "Aceptar";
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(883, 361);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 0;
            this.cerrar.Text = "Cerrar";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // superLabel1
            // 
            this.superLabel1.Location = new System.Drawing.Point(58, 139);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(143, 20);
            this.superLabel1.TabIndex = 14;
            this.superLabel1.Text = "Viaje";
            // 
            // col_codigo
            // 
            this.col_codigo.DataPropertyName = "rut_codigo";
            this.col_codigo.HeaderText = "Código de ruta";
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;
            // 
            // col_fecha_salida
            // 
            this.col_fecha_salida.DataPropertyName = "salida";
            this.col_fecha_salida.HeaderText = "Fecha de salida";
            this.col_fecha_salida.Name = "col_fecha_salida";
            this.col_fecha_salida.ReadOnly = true;
            // 
            // col_fecha_llegada_estimada
            // 
            this.col_fecha_llegada_estimada.DataPropertyName = "llegada";
            this.col_fecha_llegada_estimada.HeaderText = "Fecha de llegada estimada";
            this.col_fecha_llegada_estimada.Name = "col_fecha_llegada_estimada";
            this.col_fecha_llegada_estimada.ReadOnly = true;
            // 
            // col_origen
            // 
            this.col_origen.DataPropertyName = "origen";
            this.col_origen.HeaderText = "Ciudad origen";
            this.col_origen.Name = "col_origen";
            this.col_origen.ReadOnly = true;
            // 
            // col_destino
            // 
            this.col_destino.DataPropertyName = "destino";
            this.col_destino.HeaderText = "Ciudad destino";
            this.col_destino.Name = "col_destino";
            this.col_destino.ReadOnly = true;
            // 
            // col_servicio
            // 
            this.col_servicio.DataPropertyName = "servicios";
            this.col_servicio.HeaderText = "Servicio";
            this.col_servicio.Name = "col_servicio";
            this.col_servicio.ReadOnly = true;
            // 
            // col_preciokg
            // 
            this.col_preciokg.DataPropertyName = "rut_precio_base_x_kg";
            this.col_preciokg.HeaderText = "Precio base por kg.";
            this.col_preciokg.Name = "col_preciokg";
            this.col_preciokg.ReadOnly = true;
            // 
            // col_preciopasaje
            // 
            this.col_preciopasaje.DataPropertyName = "rut_precio_base_pasaje";
            this.col_preciopasaje.HeaderText = "Precio base por pasaje";
            this.col_preciopasaje.Name = "col_preciopasaje";
            this.col_preciopasaje.ReadOnly = true;
            // 
            // Generar_Viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1056, 432);
            this.Controls.Add(this.superLabel1);
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

        private AerolineaFrba.SuperControls.SuperGroupBox viaje;
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
        private SuperComboBox Destino;
        private SuperComboBox Origen;
        private SuperLabel lab_origen;
        private SuperLabel lab_destino;
        private SuperLabel superLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_llegada_estimada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_preciokg;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_preciopasaje;

    }
}

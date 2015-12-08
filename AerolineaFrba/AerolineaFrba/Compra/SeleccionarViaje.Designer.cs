namespace AerolineaFrba.Compra
{
    partial class SeleccionarViaje
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
            this.viajes = new System.Windows.Forms.DataGridView();
            this.info_viaje = new AerolineaFrba.SuperControls.SuperLabel();
            this.seleccionar_viaje = new AerolineaFrba.SuperControls.SuperButton();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio_pasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio_encomienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_butacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_encomiendas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viajes)).BeginInit();
            this.SuspendLayout();
            // 
            // viajes
            // 
            this.viajes.AllowUserToAddRows = false;
            this.viajes.AllowUserToDeleteRows = false;
            this.viajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_salida,
            this.col_estimada,
            this.col_origen,
            this.col_destino,
            this.col_servicio,
            this.col_precio_pasaje,
            this.col_precio_encomienda,
            this.col_butacas,
            this.col_encomiendas});
            this.viajes.Location = new System.Drawing.Point(32, 70);
            this.viajes.MultiSelect = false;
            this.viajes.Name = "viajes";
            this.viajes.Size = new System.Drawing.Size(932, 165);
            this.viajes.TabIndex = 0;
            // 
            // info_viaje
            // 
            this.info_viaje.AutoSize = true;
            this.info_viaje.Location = new System.Drawing.Point(41, 28);
            this.info_viaje.Name = "info_viaje";
            this.info_viaje.Size = new System.Drawing.Size(460, 13);
            this.info_viaje.TabIndex = 1;
            this.info_viaje.Text = "Se encontraron los siguientes viajes que concuerdan con los datos ingresados. Sel" +
    "eccione uno.";
            // 
            // seleccionar_viaje
            // 
            this.seleccionar_viaje.Location = new System.Drawing.Point(822, 268);
            this.seleccionar_viaje.Name = "seleccionar_viaje";
            this.seleccionar_viaje.Size = new System.Drawing.Size(142, 23);
            this.seleccionar_viaje.TabIndex = 2;
            this.seleccionar_viaje.Text = "Seleccionar viaje";
            this.seleccionar_viaje.UseVisualStyleBackColor = true;
            this.seleccionar_viaje.Click += new System.EventHandler(this.seleccionar_viaje_Click);
            // 
            // col_codigo
            // 
            this.col_codigo.HeaderText = "Codigo";
            this.col_codigo.Name = "col_codigo";
            // 
            // col_salida
            // 
            this.col_salida.HeaderText = "Fecha de salida";
            this.col_salida.Name = "col_salida";
            this.col_salida.ReadOnly = true;
            // 
            // col_estimada
            // 
            this.col_estimada.HeaderText = "Fecha estimada de llegada";
            this.col_estimada.Name = "col_estimada";
            this.col_estimada.ReadOnly = true;
            // 
            // col_origen
            // 
            this.col_origen.HeaderText = "Origen";
            this.col_origen.Name = "col_origen";
            this.col_origen.ReadOnly = true;
            // 
            // col_destino
            // 
            this.col_destino.HeaderText = "Destino";
            this.col_destino.Name = "col_destino";
            this.col_destino.ReadOnly = true;
            // 
            // col_servicio
            // 
            this.col_servicio.HeaderText = "Servicio";
            this.col_servicio.Name = "col_servicio";
            this.col_servicio.ReadOnly = true;
            // 
            // col_precio_pasaje
            // 
            this.col_precio_pasaje.HeaderText = "Precio del pasaje";
            this.col_precio_pasaje.Name = "col_precio_pasaje";
            this.col_precio_pasaje.ReadOnly = true;
            // 
            // col_precio_encomienda
            // 
            this.col_precio_encomienda.HeaderText = "Precio por kg. encomienda";
            this.col_precio_encomienda.Name = "col_precio_encomienda";
            this.col_precio_encomienda.ReadOnly = true;
            // 
            // col_butacas
            // 
            this.col_butacas.HeaderText = "Butacas disponibles";
            this.col_butacas.Name = "col_butacas";
            this.col_butacas.ReadOnly = true;
            // 
            // col_encomiendas
            // 
            this.col_encomiendas.HeaderText = "Kgs. disponibles para encomiendas";
            this.col_encomiendas.Name = "col_encomiendas";
            this.col_encomiendas.ReadOnly = true;
            // 
            // SeleccionarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 328);
            this.Controls.Add(this.seleccionar_viaje);
            this.Controls.Add(this.info_viaje);
            this.Controls.Add(this.viajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SeleccionarViaje";
            this.Text = "SeleccionarViaje";
            this.Load += new System.EventHandler(this.SeleccionarViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viajes;
        private SuperControls.SuperLabel info_viaje;
        private SuperControls.SuperButton seleccionar_viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estimada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio_pasaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio_encomienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_butacas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_encomiendas;
    }
}
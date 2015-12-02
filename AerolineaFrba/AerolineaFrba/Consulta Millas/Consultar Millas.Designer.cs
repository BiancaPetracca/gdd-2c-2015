namespace AerolineaFrba.Consulta_Millas
{
    partial class Consultar_Millas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pasajes = new System.Windows.Forms.DataGridView();
            this.col_fecha_pasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_origen_pasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_destino_pasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_millas_pasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encomiendas = new System.Windows.Forms.DataGridView();
            this.col_fecha_encomienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_origen_encomienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_destino_encomienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_millas_encomienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new AerolineaFrba.SuperControls.SuperComboBox();
            this.tipo_dni = new AerolineaFrba.SuperControls.SuperLabel();
            this.limpiar = new System.Windows.Forms.Button();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.dni = new AerolineaFrba.SuperControls.SuperTextBox();
            this.consultar = new AerolineaFrba.SuperControls.SuperButton();
            this.canjes = new System.Windows.Forms.DataGridView();
            this.col_fecha_canje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_millas_gastadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pasajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomiendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canjes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pasajes);
            this.groupBox1.Controls.Add(this.encomiendas);
            this.groupBox1.Controls.Add(this.tipo);
            this.groupBox1.Controls.Add(this.tipo_dni);
            this.groupBox1.Controls.Add(this.limpiar);
            this.groupBox1.Controls.Add(this.superLabel1);
            this.groupBox1.Controls.Add(this.dni);
            this.groupBox1.Controls.Add(this.consultar);
            this.groupBox1.Controls.Add(this.canjes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 477);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar millas";
            // 
            // pasajes
            // 
            this.pasajes.AllowUserToAddRows = false;
            this.pasajes.AllowUserToDeleteRows = false;
            this.pasajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pasajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pasajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_fecha_pasaje,
            this.col_origen_pasaje,
            this.col_destino_pasaje,
            this.col_millas_pasaje});
            this.pasajes.Location = new System.Drawing.Point(561, 56);
            this.pasajes.Name = "pasajes";
            this.pasajes.Size = new System.Drawing.Size(423, 179);
            this.pasajes.TabIndex = 7;
            // 
            // col_fecha_pasaje
            // 
            this.col_fecha_pasaje.HeaderText = "Fecha";
            this.col_fecha_pasaje.Name = "col_fecha_pasaje";
            this.col_fecha_pasaje.ReadOnly = true;
            // 
            // col_origen_pasaje
            // 
            this.col_origen_pasaje.HeaderText = "Origen";
            this.col_origen_pasaje.Name = "col_origen_pasaje";
            this.col_origen_pasaje.ReadOnly = true;
            // 
            // col_destino_pasaje
            // 
            this.col_destino_pasaje.HeaderText = "Destino";
            this.col_destino_pasaje.Name = "col_destino_pasaje";
            this.col_destino_pasaje.ReadOnly = true;
            // 
            // col_millas_pasaje
            // 
            this.col_millas_pasaje.HeaderText = "Millas obtenidas";
            this.col_millas_pasaje.Name = "col_millas_pasaje";
            // 
            // encomiendas
            // 
            this.encomiendas.AllowUserToAddRows = false;
            this.encomiendas.AllowUserToDeleteRows = false;
            this.encomiendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.encomiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.encomiendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_fecha_encomienda,
            this.col_origen_encomienda,
            this.col_destino_encomienda,
            this.col_millas_encomienda});
            this.encomiendas.Location = new System.Drawing.Point(561, 254);
            this.encomiendas.Name = "encomiendas";
            this.encomiendas.Size = new System.Drawing.Size(423, 179);
            this.encomiendas.TabIndex = 6;
            // 
            // col_fecha_encomienda
            // 
            this.col_fecha_encomienda.HeaderText = "Fecha";
            this.col_fecha_encomienda.Name = "col_fecha_encomienda";
            this.col_fecha_encomienda.ReadOnly = true;
            // 
            // col_origen_encomienda
            // 
            this.col_origen_encomienda.HeaderText = "Origen";
            this.col_origen_encomienda.Name = "col_origen_encomienda";
            this.col_origen_encomienda.ReadOnly = true;
            // 
            // col_destino_encomienda
            // 
            this.col_destino_encomienda.HeaderText = "Destino";
            this.col_destino_encomienda.Name = "col_destino_encomienda";
            this.col_destino_encomienda.ReadOnly = true;
            // 
            // col_millas_encomienda
            // 
            this.col_millas_encomienda.HeaderText = "Millas obtenidas";
            this.col_millas_encomienda.Name = "col_millas_encomienda";
            // 
            // tipo
            // 
            this.tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LI"});
            this.tipo.Location = new System.Drawing.Point(140, 51);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(85, 21);
            this.tipo.TabIndex = 5;
            // 
            // tipo_dni
            // 
            this.tipo_dni.AutoSize = true;
            this.tipo_dni.Location = new System.Drawing.Point(85, 56);
            this.tipo_dni.Name = "tipo_dni";
            this.tipo_dni.Size = new System.Drawing.Size(32, 13);
            this.tipo_dni.TabIndex = 4;
            this.tipo_dni.Text = "TIPO";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(372, 123);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 1;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(278, 56);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(26, 13);
            this.superLabel1.TabIndex = 3;
            this.superLabel1.Text = "DNI";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(347, 53);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 2;
            this.dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dni_KeyPress);
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(109, 123);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(116, 23);
            this.consultar.TabIndex = 1;
            this.consultar.Text = "Consultar millas";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // canjes
            // 
            this.canjes.AllowUserToAddRows = false;
            this.canjes.AllowUserToDeleteRows = false;
            this.canjes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.canjes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.canjes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_fecha_canje,
            this.col_producto,
            this.col_cantidad,
            this.col_millas_gastadas});
            this.canjes.Location = new System.Drawing.Point(50, 181);
            this.canjes.Name = "canjes";
            this.canjes.Size = new System.Drawing.Size(442, 252);
            this.canjes.TabIndex = 0;
            // 
            // col_fecha_canje
            // 
            this.col_fecha_canje.HeaderText = "Fecha";
            this.col_fecha_canje.Name = "col_fecha_canje";
            this.col_fecha_canje.ReadOnly = true;
            // 
            // col_producto
            // 
            this.col_producto.HeaderText = "Producto";
            this.col_producto.Name = "col_producto";
            this.col_producto.ReadOnly = true;
            // 
            // col_cantidad
            // 
            this.col_cantidad.HeaderText = "Cantidad";
            this.col_cantidad.Name = "col_cantidad";
            this.col_cantidad.ReadOnly = true;
            // 
            // col_millas_gastadas
            // 
            this.col_millas_gastadas.HeaderText = "Millas gastadas";
            this.col_millas_gastadas.Name = "col_millas_gastadas";
            // 
            // Consultar_Millas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 501);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultar_Millas";
            this.Text = "Consultar millas";
            this.Load += new System.EventHandler(this.Consultar_Millas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pasajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomiendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canjes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.DataGridView canjes;
        private SuperControls.SuperLabel superLabel1;
        private SuperControls.SuperTextBox dni;
        private SuperControls.SuperButton consultar;
        private SuperControls.SuperComboBox tipo;
        private SuperControls.SuperLabel tipo_dni;
        private System.Windows.Forms.DataGridView pasajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_pasaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_origen_pasaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_destino_pasaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_millas_pasaje;
        private System.Windows.Forms.DataGridView encomiendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_encomienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_origen_encomienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_destino_encomienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_millas_encomienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_canje;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_millas_gastadas;
    }
}
namespace AerolineaFrba.Listado_Estadistico
{
    partial class Listado_Estadisticas
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
            this.label1 = new System.Windows.Forms.Label();
            this.Semestre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoListado = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Top5 = new System.Windows.Forms.DataGridView();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aeronave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPasajesComprados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadLugaresVacios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasajesCancelados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntosAcumulados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasFueraServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Top5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione semestre:";
            // 
            // Semestre
            // 
            this.Semestre.AccessibleDescription = "Semestre";
            this.Semestre.Location = new System.Drawing.Point(162, 32);
            this.Semestre.Name = "Semestre";
            this.Semestre.Size = new System.Drawing.Size(100, 20);
            this.Semestre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elija tipo de listado: ";
            // 
            // TipoListado
            // 
            this.TipoListado.AccessibleName = "Tipo de listado";
            this.TipoListado.FormattingEnabled = true;
            this.TipoListado.Items.AddRange(new object[] {
            "Destinos con más pasajes comprados",
            "Destinos con aeronaves más vacías",
            "Clientes con más puntos acumulados a la fecha",
            "Destinos con más pasajes cancelados",
            "Aeronaves con mayor cantidad de días fuera de servicio"});
            this.TipoListado.Location = new System.Drawing.Point(497, 31);
            this.TipoListado.Name = "TipoListado";
            this.TipoListado.Size = new System.Drawing.Size(239, 21);
            this.TipoListado.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Top5);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 276);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOP 5";
            // 
            // Top5
            // 
            this.Top5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Top5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Destino,
            this.Cliente,
            this.Aeronave,
            this.CantidadPasajesComprados,
            this.CantidadLugaresVacios,
            this.PasajesCancelados,
            this.PuntosAcumulados,
            this.DiasFueraServicio});
            this.Top5.Location = new System.Drawing.Point(6, 19);
            this.Top5.Name = "Top5";
            this.Top5.Size = new System.Drawing.Size(845, 251);
            this.Top5.TabIndex = 0;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Aeronave
            // 
            this.Aeronave.HeaderText = "Aeronave";
            this.Aeronave.Name = "Aeronave";
            // 
            // CantidadPasajesComprados
            // 
            this.CantidadPasajesComprados.HeaderText = "Pasajes comprados";
            this.CantidadPasajesComprados.Name = "CantidadPasajesComprados";
            // 
            // CantidadLugaresVacios
            // 
            this.CantidadLugaresVacios.HeaderText = "Lugares vacíos en aeronave";
            this.CantidadLugaresVacios.Name = "CantidadLugaresVacios";
            // 
            // PasajesCancelados
            // 
            this.PasajesCancelados.HeaderText = "Pasajes cancelados";
            this.PasajesCancelados.Name = "PasajesCancelados";
            // 
            // PuntosAcumulados
            // 
            this.PuntosAcumulados.HeaderText = "Puntos acumulados";
            this.PuntosAcumulados.Name = "PuntosAcumulados";
            // 
            // DiasFueraServicio
            // 
            this.DiasFueraServicio.HeaderText = "Días fuera de servicio";
            this.DiasFueraServicio.Name = "DiasFueraServicio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Listado_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TipoListado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Semestre);
            this.Controls.Add(this.label1);
            this.Name = "Listado_Estadisticas";
            this.Text = "Listado Estadístico";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Top5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Semestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoListado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Top5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aeronave;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPasajesComprados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadLugaresVacios;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasajesCancelados;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntosAcumulados;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasFueraServicio;
        private System.Windows.Forms.Button button1;
    }
}
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
            this.label2 = new System.Windows.Forms.Label();
            this.Top5 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.millasAcumuladas = new AerolineaFrba.SuperControls.SuperButton();
            this.aeronaves_vacias = new AerolineaFrba.SuperControls.SuperButton();
            this.pasajesCancelados = new AerolineaFrba.SuperControls.SuperButton();
            this.fueraServicio = new AerolineaFrba.SuperControls.SuperButton();
            this.pasajesComprados = new AerolineaFrba.SuperControls.SuperButton();
            this.semestre = new AerolineaFrba.SuperControls.SuperComboBox();
            this.anio = new AerolineaFrba.SuperControls.SuperComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Top5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semestre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elija tipo de listado: ";
            // 
            // Top5
            // 
            this.Top5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Top5.Location = new System.Drawing.Point(40, 101);
            this.Top5.Name = "Top5";
            this.Top5.Size = new System.Drawing.Size(454, 218);
            this.Top5.TabIndex = 0;
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
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(164, 35);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(29, 13);
            this.superLabel1.TabIndex = 7;
            this.superLabel1.Text = "Año:";
            // 
            // millasAcumuladas
            // 
            this.millasAcumuladas.Location = new System.Drawing.Point(532, 110);
            this.millasAcumuladas.Name = "millasAcumuladas";
            this.millasAcumuladas.Size = new System.Drawing.Size(235, 23);
            this.millasAcumuladas.TabIndex = 9;
            this.millasAcumuladas.Text = "Clientes con más millas acumuladas ";
            this.millasAcumuladas.UseVisualStyleBackColor = true;
            this.millasAcumuladas.Click += new System.EventHandler(this.millasAcumuladas_Click);
            // 
            // aeronaves_vacias
            // 
            this.aeronaves_vacias.Location = new System.Drawing.Point(532, 287);
            this.aeronaves_vacias.Name = "aeronaves_vacias";
            this.aeronaves_vacias.Size = new System.Drawing.Size(235, 23);
            this.aeronaves_vacias.TabIndex = 10;
            this.aeronaves_vacias.Text = "Destinos con aeronaves más vacías";
            this.aeronaves_vacias.UseVisualStyleBackColor = true;
            this.aeronaves_vacias.Click += new System.EventHandler(this.aeronaves_vacias_Click);
            // 
            // pasajesCancelados
            // 
            this.pasajesCancelados.Location = new System.Drawing.Point(532, 198);
            this.pasajesCancelados.Name = "pasajesCancelados";
            this.pasajesCancelados.Size = new System.Drawing.Size(235, 23);
            this.pasajesCancelados.TabIndex = 11;
            this.pasajesCancelados.Text = "Destinos con más pasajes cancelados";
            this.pasajesCancelados.UseVisualStyleBackColor = true;
            this.pasajesCancelados.Click += new System.EventHandler(this.pasajesCancelados_Click);
            // 
            // fueraServicio
            // 
            this.fueraServicio.Location = new System.Drawing.Point(532, 243);
            this.fueraServicio.Name = "fueraServicio";
            this.fueraServicio.Size = new System.Drawing.Size(235, 23);
            this.fueraServicio.TabIndex = 12;
            this.fueraServicio.Text = "Aeronaves con más veces fuera de servicio";
            this.fueraServicio.UseVisualStyleBackColor = true;
            this.fueraServicio.Click += new System.EventHandler(this.fueraServicio_Click);
            // 
            // pasajesComprados
            // 
            this.pasajesComprados.Location = new System.Drawing.Point(532, 153);
            this.pasajesComprados.Name = "pasajesComprados";
            this.pasajesComprados.Size = new System.Drawing.Size(235, 23);
            this.pasajesComprados.TabIndex = 13;
            this.pasajesComprados.Text = "Destinos con más pasajes comprados";
            this.pasajesComprados.UseVisualStyleBackColor = true;
            this.pasajesComprados.Click += new System.EventHandler(this.pasajesComprados_Click);
            // 
            // semestre
            // 
            this.semestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semestre.FormattingEnabled = true;
            this.semestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.semestre.Location = new System.Drawing.Point(98, 32);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(45, 21);
            this.semestre.TabIndex = 14;
            // 
            // anio
            // 
            this.anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anio.FormattingEnabled = true;
            this.anio.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018"});
            this.anio.Location = new System.Drawing.Point(199, 32);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(67, 21);
            this.anio.TabIndex = 15;
            // 
            // Listado_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 442);
            this.Controls.Add(this.anio);
            this.Controls.Add(this.semestre);
            this.Controls.Add(this.pasajesComprados);
            this.Controls.Add(this.fueraServicio);
            this.Controls.Add(this.pasajesCancelados);
            this.Controls.Add(this.aeronaves_vacias);
            this.Controls.Add(this.millasAcumuladas);
            this.Controls.Add(this.Top5);
            this.Controls.Add(this.superLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_Estadisticas";
            this.Text = "Listado Estadístico";
            this.Load += new System.EventHandler(this.Listado_Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Top5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Top5;
        private System.Windows.Forms.Button button1;
        private SuperControls.SuperLabel superLabel1;
        private SuperControls.SuperButton millasAcumuladas;
        private SuperControls.SuperButton aeronaves_vacias;
        private SuperControls.SuperButton pasajesCancelados;
        private SuperControls.SuperButton fueraServicio;
        private SuperControls.SuperButton pasajesComprados;
        private SuperControls.SuperComboBox semestre;
        private SuperControls.SuperComboBox anio;
    }
}
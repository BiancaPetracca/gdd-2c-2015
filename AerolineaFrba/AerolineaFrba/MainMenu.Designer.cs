namespace AerolineaFrba
{
    partial class MainMenu
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
            this.items = new System.Windows.Forms.MenuStrip();
            this.item_rol = new System.Windows.Forms.ToolStripMenuItem();
            this.item_ciudades = new System.Windows.Forms.ToolStripMenuItem();
            this.item_ruta = new System.Windows.Forms.ToolStripMenuItem();
            this.item_aeronave = new System.Windows.Forms.ToolStripMenuItem();
            this.item_generarViaje = new System.Windows.Forms.ToolStripMenuItem();
            this.item_registro = new System.Windows.Forms.ToolStripMenuItem();
            this.item_comprar = new System.Windows.Forms.ToolStripMenuItem();
            this.item_devolucion = new System.Windows.Forms.ToolStripMenuItem();
            this.item_verMillas = new System.Windows.Forms.ToolStripMenuItem();
            this.item_canje = new System.Windows.Forms.ToolStripMenuItem();
            this.item_estadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            this.items.SuspendLayout();
            this.SuspendLayout();
            // 
            // items
            // 
            this.items.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_rol,
            this.item_ciudades,
            this.item_ruta,
            this.item_aeronave,
            this.item_generarViaje,
            this.item_registro,
            this.item_comprar,
            this.item_devolucion,
            this.item_verMillas,
            this.item_canje,
            this.item_estadisticas,
            this.salir});
            this.items.Location = new System.Drawing.Point(0, 0);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(1014, 24);
            this.items.TabIndex = 2;
            this.items.Text = "items";
            // 
            // item_rol
            // 
            this.item_rol.Name = "item_rol";
            this.item_rol.Size = new System.Drawing.Size(65, 20);
            this.item_rol.Tag = "1";
            this.item_rol.Text = "ABM Rol";
            this.item_rol.Click += new System.EventHandler(this.rolABM_Click);
            this.item_rol.DoubleClick += new System.EventHandler(this.rolABM_Click);
            // 
            // item_ciudades
            // 
            this.item_ciudades.Name = "item_ciudades";
            this.item_ciudades.Size = new System.Drawing.Size(97, 20);
            this.item_ciudades.Tag = "3";
            this.item_ciudades.Text = "ABM Ciudades";
            this.item_ciudades.Click += new System.EventHandler(this.item_ciudades_Click);
            // 
            // item_ruta
            // 
            this.item_ruta.Name = "item_ruta";
            this.item_ruta.Size = new System.Drawing.Size(72, 20);
            this.item_ruta.Tag = "4";
            this.item_ruta.Text = "ABM Ruta";
            this.item_ruta.Click += new System.EventHandler(this.rutaToolStripMenuItem_Click);
            // 
            // item_aeronave
            // 
            this.item_aeronave.Name = "item_aeronave";
            this.item_aeronave.Size = new System.Drawing.Size(98, 20);
            this.item_aeronave.Tag = "5";
            this.item_aeronave.Text = "ABM Aeronave";
            this.item_aeronave.Click += new System.EventHandler(this.aeronaveToolStripMenuItem_Click);
            // 
            // item_generarViaje
            // 
            this.item_generarViaje.Name = "item_generarViaje";
            this.item_generarViaje.Size = new System.Drawing.Size(87, 20);
            this.item_generarViaje.Tag = "6";
            this.item_generarViaje.Text = "Generar viaje";
            this.item_generarViaje.Click += new System.EventHandler(this.generarToolStripMenuItem_Click);
            // 
            // item_registro
            // 
            this.item_registro.Name = "item_registro";
            this.item_registro.Size = new System.Drawing.Size(119, 20);
            this.item_registro.Tag = "7";
            this.item_registro.Text = "Registro de llegada";
            this.item_registro.Click += new System.EventHandler(this.registroDeLlegadaToolStripMenuItem_Click);
            // 
            // item_comprar
            // 
            this.item_comprar.Name = "item_comprar";
            this.item_comprar.Size = new System.Drawing.Size(69, 20);
            this.item_comprar.Tag = "8";
            this.item_comprar.Text = "Comprar ";
            this.item_comprar.Click += new System.EventHandler(this.pasajeToolStripMenuItem_Click);
            // 
            // item_devolucion
            // 
            this.item_devolucion.Name = "item_devolucion";
            this.item_devolucion.Size = new System.Drawing.Size(79, 20);
            this.item_devolucion.Tag = "9";
            this.item_devolucion.Text = "Devolucion";
            this.item_devolucion.Click += new System.EventHandler(this.devolucionToolStripMenuItem_Click);
            // 
            // item_verMillas
            // 
            this.item_verMillas.Name = "item_verMillas";
            this.item_verMillas.Size = new System.Drawing.Size(70, 20);
            this.item_verMillas.Tag = "10";
            this.item_verMillas.Text = "Ver millas";
            this.item_verMillas.Click += new System.EventHandler(this.consultarMillasToolStripMenuItem_Click);
            // 
            // item_canje
            // 
            this.item_canje.Name = "item_canje";
            this.item_canje.Size = new System.Drawing.Size(49, 20);
            this.item_canje.Tag = "11";
            this.item_canje.Text = "Canje";
            this.item_canje.Click += new System.EventHandler(this.canjearMillasToolStripMenuItem_Click);
            // 
            // item_estadisticas
            // 
            this.item_estadisticas.Name = "item_estadisticas";
            this.item_estadisticas.Size = new System.Drawing.Size(79, 20);
            this.item_estadisticas.Tag = "12";
            this.item_estadisticas.Text = "Estadísticas";
            this.item_estadisticas.Click += new System.EventHandler(this.verListadoEstadísticoToolStripMenuItem_Click);
            // 
            // salir
            // 
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(41, 20);
            this.salir.Text = "Salir";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1014, 491);
            this.Controls.Add(this.items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.items;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aerolinea";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.items.ResumeLayout(false);
            this.items.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip items;
        private System.Windows.Forms.ToolStripMenuItem salir;
        private System.Windows.Forms.ToolStripMenuItem item_aeronave;
        private System.Windows.Forms.ToolStripMenuItem item_generarViaje;
        private System.Windows.Forms.ToolStripMenuItem item_ruta;
        private System.Windows.Forms.ToolStripMenuItem item_rol;
        private System.Windows.Forms.ToolStripMenuItem item_registro;
        private System.Windows.Forms.ToolStripMenuItem item_comprar;
        private System.Windows.Forms.ToolStripMenuItem item_devolucion;
        private System.Windows.Forms.ToolStripMenuItem item_canje;
        private System.Windows.Forms.ToolStripMenuItem item_verMillas;
        private System.Windows.Forms.ToolStripMenuItem item_estadisticas;
        private System.Windows.Forms.ToolStripMenuItem item_ciudades;


    }
}

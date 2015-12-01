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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aeronaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroLlegada = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.canjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolToolStripMenuItem,
            this.generarToolStripMenuItem,
            this.rutaToolStripMenuItem,
            this.aeronaveToolStripMenuItem,
            this.registroLlegada,
            this.comprarToolStripMenuItem,
            this.devolucionToolStripMenuItem1,
            this.canjeToolStripMenuItem,
            this.verMillasToolStripMenuItem,
            this.estadísticasToolStripMenuItem,
            this.cerrarSesion,
            this.salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.rolToolStripMenuItem.Text = "Rol";
            this.rolToolStripMenuItem.Click += new System.EventHandler(this.rolABM_Click);
            this.rolToolStripMenuItem.DoubleClick += new System.EventHandler(this.rolABM_Click);
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.generarToolStripMenuItem.Text = "Generar viaje";
            this.generarToolStripMenuItem.Click += new System.EventHandler(this.generarToolStripMenuItem_Click);
            // 
            // rutaToolStripMenuItem
            // 
            this.rutaToolStripMenuItem.Name = "rutaToolStripMenuItem";
            this.rutaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.rutaToolStripMenuItem.Text = "Ruta";
            this.rutaToolStripMenuItem.Click += new System.EventHandler(this.rutaToolStripMenuItem_Click);
            // 
            // aeronaveToolStripMenuItem
            // 
            this.aeronaveToolStripMenuItem.Name = "aeronaveToolStripMenuItem";
            this.aeronaveToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.aeronaveToolStripMenuItem.Text = "Aeronave";
            this.aeronaveToolStripMenuItem.Click += new System.EventHandler(this.aeronaveToolStripMenuItem_Click);
            // 
            // registroLlegada
            // 
            this.registroLlegada.Name = "registroLlegada";
            this.registroLlegada.Size = new System.Drawing.Size(119, 20);
            this.registroLlegada.Text = "Registro de llegada";
            this.registroLlegada.Click += new System.EventHandler(this.registroDeLlegadaToolStripMenuItem_Click);
            // 
            // comprarToolStripMenuItem
            // 
            this.comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
            this.comprarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.comprarToolStripMenuItem.Text = "Comprar ";
            this.comprarToolStripMenuItem.Click += new System.EventHandler(this.pasajeToolStripMenuItem_Click);
            // 
            // devolucionToolStripMenuItem1
            // 
            this.devolucionToolStripMenuItem1.Name = "devolucionToolStripMenuItem1";
            this.devolucionToolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.devolucionToolStripMenuItem1.Text = "Devolucion";
            this.devolucionToolStripMenuItem1.Click += new System.EventHandler(this.devolucionToolStripMenuItem_Click);
            // 
            // canjeToolStripMenuItem
            // 
            this.canjeToolStripMenuItem.Name = "canjeToolStripMenuItem";
            this.canjeToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.canjeToolStripMenuItem.Text = "Canje";
            this.canjeToolStripMenuItem.Click += new System.EventHandler(this.canjearMillasToolStripMenuItem_Click);
            // 
            // verMillasToolStripMenuItem
            // 
            this.verMillasToolStripMenuItem.Name = "verMillasToolStripMenuItem";
            this.verMillasToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.verMillasToolStripMenuItem.Text = "Ver millas";
            this.verMillasToolStripMenuItem.Click += new System.EventHandler(this.consultarMillasToolStripMenuItem_Click);
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadísticasToolStripMenuItem.Text = "Estadísticas";
            this.estadísticasToolStripMenuItem.Click += new System.EventHandler(this.verListadoEstadísticoToolStripMenuItem_Click);
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesion.Text = "Cerrar sesión";
            this.cerrarSesion.Click += new System.EventHandler(this.cerrarSesion_Click);
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
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aerolinea";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem salir;
        private System.Windows.Forms.ToolStripMenuItem aeronaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroLlegada;
        private System.Windows.Forms.ToolStripMenuItem comprarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem canjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;


    }
}

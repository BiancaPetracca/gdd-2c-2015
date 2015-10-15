namespace AerolineaFrba
{
    partial class Inicio
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
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aeronaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeLlegadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoEstadísticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.generarToolStripMenuItem,
            this.rutaToolStripMenuItem,
            this.aeronaveToolStripMenuItem,
            this.ciudadToolStripMenuItem,
            this.operacionToolStripMenuItem,
            this.registroDeLlegadaToolStripMenuItem,
            this.cerrarSesion,
            this.salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
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
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaCliente,
            this.bajaCliente,
            this.modificacionCliente});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // altaCliente
            // 
            this.altaCliente.Name = "altaCliente";
            this.altaCliente.Size = new System.Drawing.Size(144, 22);
            this.altaCliente.Text = "Alta";
            // 
            // bajaCliente
            // 
            this.bajaCliente.Name = "bajaCliente";
            this.bajaCliente.Size = new System.Drawing.Size(144, 22);
            this.bajaCliente.Text = "Baja";
            // 
            // modificacionCliente
            // 
            this.modificacionCliente.Name = "modificacionCliente";
            this.modificacionCliente.Size = new System.Drawing.Size(144, 22);
            this.modificacionCliente.Text = "Modificación";
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
            // ciudadToolStripMenuItem
            // 
            this.ciudadToolStripMenuItem.Name = "ciudadToolStripMenuItem";
            this.ciudadToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ciudadToolStripMenuItem.Text = "Ciudad";
            this.ciudadToolStripMenuItem.Click += new System.EventHandler(this.ciudadToolStripMenuItem_Click);
            // 
            // operacionToolStripMenuItem
            // 
            this.operacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasajeToolStripMenuItem,
            this.devolucionToolStripMenuItem,
            this.consultarMillasToolStripMenuItem,
            this.verListadoEstadísticoToolStripMenuItem});
            this.operacionToolStripMenuItem.Name = "operacionToolStripMenuItem";
            this.operacionToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionToolStripMenuItem.Text = "Operaciones";
            this.operacionToolStripMenuItem.Click += new System.EventHandler(this.operacionToolStripMenuItem_Click);
            // 
            // pasajeToolStripMenuItem
            // 
            this.pasajeToolStripMenuItem.Name = "pasajeToolStripMenuItem";
            this.pasajeToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.pasajeToolStripMenuItem.Text = "Comprar Pasaje/Encomienda";
            this.pasajeToolStripMenuItem.Click += new System.EventHandler(this.pasajeToolStripMenuItem_Click);
            // 
            // devolucionToolStripMenuItem
            // 
            this.devolucionToolStripMenuItem.Name = "devolucionToolStripMenuItem";
            this.devolucionToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.devolucionToolStripMenuItem.Text = "Devolucion";
            // 
            // consultarMillasToolStripMenuItem
            // 
            this.consultarMillasToolStripMenuItem.Name = "consultarMillasToolStripMenuItem";
            this.consultarMillasToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.consultarMillasToolStripMenuItem.Text = "Consultar millas";
            // 
            // registroDeLlegadaToolStripMenuItem
            // 
            this.registroDeLlegadaToolStripMenuItem.Name = "registroDeLlegadaToolStripMenuItem";
            this.registroDeLlegadaToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.registroDeLlegadaToolStripMenuItem.Text = "Registro de llegada";
            this.registroDeLlegadaToolStripMenuItem.Click += new System.EventHandler(this.registroDeLlegadaToolStripMenuItem_Click);
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesion.Text = "Cerrar sesión";
            // 
            // salir
            // 
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(41, 20);
            this.salir.Text = "Salir";
            // 
            // verListadoEstadísticoToolStripMenuItem
            // 
            this.verListadoEstadísticoToolStripMenuItem.Name = "verListadoEstadísticoToolStripMenuItem";
            this.verListadoEstadísticoToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.verListadoEstadísticoToolStripMenuItem.Text = "Ver listado estadístico";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(988, 462);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aerolinea";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaCliente;
        private System.Windows.Forms.ToolStripMenuItem bajaCliente;
        private System.Windows.Forms.ToolStripMenuItem modificacionCliente;
        private System.Windows.Forms.ToolStripMenuItem operacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem salir;
        private System.Windows.Forms.ToolStripMenuItem aeronaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeLlegadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListadoEstadísticoToolStripMenuItem;


    }
}

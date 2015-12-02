namespace AerolineaFrba.Compra
{
    partial class Exito_Tarjeta
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
            this.button1 = new System.Windows.Forms.Button();
            this.pnr = new System.Windows.Forms.TextBox();
            this.detalleEncomienda = new AerolineaFrba.SuperControls.SuperButton();
            this.detallePasajes = new AerolineaFrba.SuperControls.SuperButton();
            this.detalleCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Éxito! Su código de compra o PNR es:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnr
            // 
            this.pnr.Location = new System.Drawing.Point(48, 64);
            this.pnr.Name = "pnr";
            this.pnr.ReadOnly = true;
            this.pnr.Size = new System.Drawing.Size(186, 20);
            this.pnr.TabIndex = 4;
            // 
            // detalleEncomienda
            // 
            this.detalleEncomienda.Location = new System.Drawing.Point(48, 125);
            this.detalleEncomienda.Name = "detalleEncomienda";
            this.detalleEncomienda.Size = new System.Drawing.Size(166, 23);
            this.detalleEncomienda.TabIndex = 11;
            this.detalleEncomienda.Text = "Detalles de encomiendas";
            this.detalleEncomienda.UseVisualStyleBackColor = true;
            this.detalleEncomienda.Click += new System.EventHandler(this.detalleEncomienda_Click);
            // 
            // detallePasajes
            // 
            this.detallePasajes.Location = new System.Drawing.Point(48, 166);
            this.detallePasajes.Name = "detallePasajes";
            this.detallePasajes.Size = new System.Drawing.Size(166, 23);
            this.detallePasajes.TabIndex = 10;
            this.detallePasajes.Text = "Detalles de pasajes";
            this.detallePasajes.UseVisualStyleBackColor = true;
            this.detallePasajes.Click += new System.EventHandler(this.detallePasajes_Click);
            // 
            // detalleCompra
            // 
            this.detalleCompra.Location = new System.Drawing.Point(48, 203);
            this.detalleCompra.Name = "detalleCompra";
            this.detalleCompra.Size = new System.Drawing.Size(166, 23);
            this.detalleCompra.TabIndex = 9;
            this.detalleCompra.Text = "Detalles de la compra";
            this.detalleCompra.UseVisualStyleBackColor = true;
            this.detalleCompra.Click += new System.EventHandler(this.detalleCompra_Click);
            // 
            // Exito_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 259);
            this.Controls.Add(this.detalleEncomienda);
            this.Controls.Add(this.detallePasajes);
            this.Controls.Add(this.detalleCompra);
            this.Controls.Add(this.pnr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exito_Tarjeta";
            this.Text = "Compra realizada con éxito!";
            this.Load += new System.EventHandler(this.Exito_Tarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pnr;
        private SuperControls.SuperButton detalleEncomienda;
        private SuperControls.SuperButton detallePasajes;
        private System.Windows.Forms.Button detalleCompra;
    }
}
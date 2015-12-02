namespace AerolineaFrba.Compra
{
    partial class Exito_Efectivo
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
            this.detalleCompra = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.detallePasajes = new AerolineaFrba.SuperControls.SuperButton();
            this.detalleEncomienda = new AerolineaFrba.SuperControls.SuperButton();
            this.pnr = new AerolineaFrba.SuperControls.SuperTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "La compra fue realizada con éxito. Su PNR es:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // detalleCompra
            // 
            this.detalleCompra.Location = new System.Drawing.Point(31, 221);
            this.detalleCompra.Name = "detalleCompra";
            this.detalleCompra.Size = new System.Drawing.Size(166, 23);
            this.detalleCompra.TabIndex = 6;
            this.detalleCompra.Text = "Detalles de la compra";
            this.detalleCompra.UseVisualStyleBackColor = true;
            this.detalleCompra.Click += new System.EventHandler(this.detalleCompra_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(238, 184);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(40, 23);
            this.OK.TabIndex = 5;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // detallePasajes
            // 
            this.detallePasajes.Location = new System.Drawing.Point(31, 184);
            this.detallePasajes.Name = "detallePasajes";
            this.detallePasajes.Size = new System.Drawing.Size(166, 23);
            this.detallePasajes.TabIndex = 7;
            this.detallePasajes.Text = "Detalles de pasajes";
            this.detallePasajes.UseVisualStyleBackColor = true;
            this.detallePasajes.Click += new System.EventHandler(this.detallePasajes_Click);
            // 
            // detalleEncomienda
            // 
            this.detalleEncomienda.Location = new System.Drawing.Point(31, 143);
            this.detalleEncomienda.Name = "detalleEncomienda";
            this.detalleEncomienda.Size = new System.Drawing.Size(166, 23);
            this.detalleEncomienda.TabIndex = 8;
            this.detalleEncomienda.Text = "Detalles de encomiendas";
            this.detalleEncomienda.UseVisualStyleBackColor = true;
            this.detalleEncomienda.Click += new System.EventHandler(this.detalleEncomienda_Click);
            // 
            // pnr
            // 
            this.pnr.Location = new System.Drawing.Point(31, 62);
            this.pnr.Name = "pnr";
            this.pnr.ReadOnly = true;
            this.pnr.Size = new System.Drawing.Size(166, 20);
            this.pnr.TabIndex = 9;
            // 
            // Exito_Efectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 278);
            this.Controls.Add(this.pnr);
            this.Controls.Add(this.detalleEncomienda);
            this.Controls.Add(this.detallePasajes);
            this.Controls.Add(this.detalleCompra);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exito_Efectivo";
            this.Text = "Compra exitosa!";
            this.Load += new System.EventHandler(this.Exito_Efectivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button detalleCompra;
        private System.Windows.Forms.Button OK;
        private SuperControls.SuperButton detallePasajes;
        private SuperControls.SuperButton detalleEncomienda;
        private SuperControls.SuperTextBox pnr;
    }
}
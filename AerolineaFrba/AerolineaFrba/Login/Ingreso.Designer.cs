namespace AerolineaFrba.Login
{
    partial class Ingreso
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
            this.but_admin = new AerolineaFrba.SuperControls.SuperButton();
            this.but_cliente = new AerolineaFrba.SuperControls.SuperButton();
            this.SuspendLayout();
            // 
            // but_admin
            // 
            this.but_admin.Location = new System.Drawing.Point(73, 53);
            this.but_admin.Name = "but_admin";
            this.but_admin.Size = new System.Drawing.Size(206, 56);
            this.but_admin.TabIndex = 0;
            this.but_admin.Text = "Oficina comercial / aeropuerto";
            this.but_admin.UseVisualStyleBackColor = true;
            this.but_admin.Click += new System.EventHandler(this.but_admin_Click);
            // 
            // but_cliente
            // 
            this.but_cliente.Location = new System.Drawing.Point(73, 137);
            this.but_cliente.Name = "but_cliente";
            this.but_cliente.Size = new System.Drawing.Size(206, 58);
            this.but_cliente.TabIndex = 1;
            this.but_cliente.Text = "Terminal kiosco / autoservicio";
            this.but_cliente.UseVisualStyleBackColor = true;
            this.but_cliente.Click += new System.EventHandler(this.but_cliente_Click);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 254);
            this.Controls.Add(this.but_cliente);
            this.Controls.Add(this.but_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ingreso";
            this.Text = "Indicar lugar de ingreso";
            this.Load += new System.EventHandler(this.Ingreso_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperControls.SuperButton but_admin;
        private SuperControls.SuperButton but_cliente;
    }
}
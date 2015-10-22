namespace AerolineaFrba.Abm_Ciudad
{
    partial class Modificacion
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
            this.Cerrar = new AerolineaFrba.SuperControls.SuperButton();
            this.ciudad = new AerolineaFrba.SuperControls.SuperTextBox();
            this.Ok = new AerolineaFrba.SuperControls.SuperButton();
            this.SuspendLayout();
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(328, 10);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 5;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            // 
            // ciudad
            // 
            this.ciudad.AccessibleDescription = "Ingrese un nuevo nombre ";
            this.ciudad.Location = new System.Drawing.Point(12, 12);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(207, 20);
            this.ciudad.TabIndex = 3;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(238, 10);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 4;
            this.Ok.Text = "Ok";
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 47);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Modificacion";
            this.Text = "Modificar ciudad";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperControls.SuperButton Cerrar;
        private SuperControls.SuperTextBox ciudad;
        private SuperControls.SuperButton Ok;
    }
}
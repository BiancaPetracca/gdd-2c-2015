namespace AerolineaFrba.Abm_Aeronave
{
    partial class modificar
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
            this.nuevoNombre = new AerolineaFrba.SuperControls.SuperTextBox();
            this.Ok = new AerolineaFrba.SuperControls.SuperButton();
            this.SuspendLayout();
            // 
            // nuevoNombre
            // 
            this.nuevoNombre.Location = new System.Drawing.Point(38, 33);
            this.nuevoNombre.Name = "nuevoNombre";
            this.nuevoNombre.Size = new System.Drawing.Size(164, 20);
            this.nuevoNombre.TabIndex = 0;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(230, 33);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 101);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.nuevoNombre);
            this.Name = "modificar";
            this.Text = "modificar / agregar";
            this.Load += new System.EventHandler(this.modificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperControls.SuperTextBox nuevoNombre;
        private SuperControls.SuperButton Ok;
    }
}
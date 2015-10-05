namespace AerolineaFrba.Abm_Rol
{
    partial class RolForm
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.bModificacion = new System.Windows.Forms.Button();
            this.bAlta = new System.Windows.Forms.Button();
            this.bBaja = new System.Windows.Forms.Button();
            this.bListado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbTitulo.Location = new System.Drawing.Point(48, 27);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(120, 31);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "ABM Rol";
            this.lbTitulo.Click += new System.EventHandler(this.lbTitulo_Click);
            // 
            // bModificacion
            // 
            this.bModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bModificacion.Location = new System.Drawing.Point(247, 101);
            this.bModificacion.Name = "bModificacion";
            this.bModificacion.Size = new System.Drawing.Size(106, 29);
            this.bModificacion.TabIndex = 5;
            this.bModificacion.Text = "Modificacion";
            this.bModificacion.UseVisualStyleBackColor = true;
            this.bModificacion.Click += new System.EventHandler(this.bModificacion_Click);
            // 
            // bAlta
            // 
            this.bAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bAlta.Location = new System.Drawing.Point(20, 101);
            this.bAlta.Name = "bAlta";
            this.bAlta.Size = new System.Drawing.Size(85, 29);
            this.bAlta.TabIndex = 4;
            this.bAlta.Text = "Alta";
            this.bAlta.UseVisualStyleBackColor = true;
            this.bAlta.Click += new System.EventHandler(this.bAlta_Click);
            // 
            // bBaja
            // 
            this.bBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bBaja.Location = new System.Drawing.Point(133, 101);
            this.bBaja.Name = "bBaja";
            this.bBaja.Size = new System.Drawing.Size(89, 29);
            this.bBaja.TabIndex = 7;
            this.bBaja.Text = "Baja";
            this.bBaja.Click += new System.EventHandler(this.bBaja_Click);
            // 
            // bListado
            // 
            this.bListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bListado.Location = new System.Drawing.Point(228, 35);
            this.bListado.Name = "bListado";
            this.bListado.Size = new System.Drawing.Size(125, 23);
            this.bListado.TabIndex = 8;
            this.bListado.Text = "Ver listado";
            // 
            // RolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 154);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.bModificacion);
            this.Controls.Add(this.bAlta);
            this.Controls.Add(this.bBaja);
            this.Controls.Add(this.bListado);
            this.Name = "RolForm";
            this.Text = "Rol";
            this.Load += new System.EventHandler(this.Rol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

               
        #endregion 
    
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button bAlta;
        private System.Windows.Forms.Button bModificacion;
        private System.Windows.Forms.Button bBaja;
        private System.Windows.Forms.Button bListado;
    }
}
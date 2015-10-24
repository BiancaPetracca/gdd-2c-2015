namespace AerolineaFrba.Registro_de_Usuario
{
    partial class RegistroUsuario
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
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel4 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Guardar = new AerolineaFrba.SuperControls.SuperButton();
            this.Cerrar = new AerolineaFrba.SuperControls.SuperButton();
            this.Limpiar = new AerolineaFrba.SuperControls.SuperButton();
            this.TipoRol = new AerolineaFrba.SuperControls.SuperCheckedListBox();
            this.RepeticionPass = new AerolineaFrba.SuperControls.SuperTextBox();
            this.Contraseña = new AerolineaFrba.SuperControls.SuperTextBox();
            this.NombreUsuario = new AerolineaFrba.SuperControls.SuperTextBox();
            this.SuspendLayout();
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(33, 34);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(99, 13);
            this.superLabel1.TabIndex = 0;
            this.superLabel1.Text = "Nombre de usuario:";
            // 
            // superLabel2
            // 
            this.superLabel2.AutoSize = true;
            this.superLabel2.Location = new System.Drawing.Point(33, 88);
            this.superLabel2.Name = "superLabel2";
            this.superLabel2.Size = new System.Drawing.Size(64, 13);
            this.superLabel2.TabIndex = 1;
            this.superLabel2.Text = "Contraseña:";
            this.superLabel2.Click += new System.EventHandler(this.superLabel2_Click);
            // 
            // superLabel3
            // 
            this.superLabel3.AutoSize = true;
            this.superLabel3.Location = new System.Drawing.Point(33, 138);
            this.superLabel3.Name = "superLabel3";
            this.superLabel3.Size = new System.Drawing.Size(111, 13);
            this.superLabel3.TabIndex = 2;
            this.superLabel3.Text = "Repetir la contraseña:";
            // 
            // superLabel4
            // 
            this.superLabel4.AutoSize = true;
            this.superLabel4.Location = new System.Drawing.Point(36, 186);
            this.superLabel4.Name = "superLabel4";
            this.superLabel4.Size = new System.Drawing.Size(26, 13);
            this.superLabel4.TabIndex = 3;
            this.superLabel4.Text = "Rol:";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(110, 259);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(298, 259);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 5;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(206, 259);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 6;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // TipoRol
            // 
            this.TipoRol.BackColor = System.Drawing.SystemColors.Control;
            this.TipoRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TipoRol.CheckOnClick = true;
            this.TipoRol.FormattingEnabled = true;
            this.TipoRol.Items.AddRange(new object[] {
            "Administrativo",
            "Cliente"});
            this.TipoRol.Location = new System.Drawing.Point(97, 186);
            this.TipoRol.MultiColumn = true;
            this.TipoRol.Name = "TipoRol";
            this.TipoRol.Size = new System.Drawing.Size(105, 30);
            this.TipoRol.TabIndex = 7;
            // 
            // RepeticionPass
            // 
            this.RepeticionPass.AccessibleDescription = "Repetición de la contraseña";
            this.RepeticionPass.Location = new System.Drawing.Point(169, 135);
            this.RepeticionPass.Name = "RepeticionPass";
            this.RepeticionPass.Size = new System.Drawing.Size(158, 20);
            this.RepeticionPass.TabIndex = 8;
            // 
            // Contraseña
            // 
            this.Contraseña.AccessibleDescription = "Contraseña";
            this.Contraseña.Location = new System.Drawing.Point(169, 88);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(158, 20);
            this.Contraseña.TabIndex = 9;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.AccessibleDescription = "Nombre de usuario";
            this.NombreUsuario.Location = new System.Drawing.Point(169, 34);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(158, 20);
            this.NombreUsuario.TabIndex = 10;
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 310);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.RepeticionPass);
            this.Controls.Add(this.TipoRol);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.superLabel4);
            this.Controls.Add(this.superLabel3);
            this.Controls.Add(this.superLabel2);
            this.Controls.Add(this.superLabel1);
            this.Name = "RegistroUsuario";
            this.Text = "RegistroUsuario";
            this.Load += new System.EventHandler(this.RegistroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperControls.SuperLabel superLabel1;
        private SuperControls.SuperLabel superLabel2;
        private SuperControls.SuperLabel superLabel3;
        private SuperControls.SuperLabel superLabel4;
        private SuperControls.SuperButton Guardar;
        private SuperControls.SuperButton Cerrar;
        private SuperControls.SuperButton Limpiar;
        private SuperControls.SuperCheckedListBox TipoRol;
        private SuperControls.SuperTextBox RepeticionPass;
        private SuperControls.SuperTextBox Contraseña;
        private SuperControls.SuperTextBox NombreUsuario;
    }
}
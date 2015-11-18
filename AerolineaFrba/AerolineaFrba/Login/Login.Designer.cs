namespace AerolineaFrba.Login
{
    partial class Login
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
            this.IniciarSesion = new AerolineaFrba.SuperControls.SuperButton();
            this.Cerrar = new AerolineaFrba.SuperControls.SuperButton();
            this.pass = new AerolineaFrba.SuperControls.SuperTextBox();
            this.Usuario = new AerolineaFrba.SuperControls.SuperTextBox();
            this.label_Contrasenia = new AerolineaFrba.SuperControls.SuperLabel();
            this.label_Usuario = new AerolineaFrba.SuperControls.SuperLabel();
            this.IntentosRestantes = new AerolineaFrba.SuperControls.SuperLabel();
            this.Bienvenida = new AerolineaFrba.SuperControls.SuperLabel();
            this.Rol = new AerolineaFrba.SuperControls.SuperComboBox();
            this.label_Rol = new AerolineaFrba.SuperControls.SuperLabel();
            this.SuspendLayout();
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.Location = new System.Drawing.Point(185, 292);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(79, 27);
            this.IniciarSesion.TabIndex = 3;
            this.IniciarSesion.Text = "Iniciar sesión";
            this.IniciarSesion.UseVisualStyleBackColor = true;
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cerrar.Location = new System.Drawing.Point(270, 292);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(86, 27);
            this.Cerrar.TabIndex = 4;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // pass
            // 
            this.pass.AccessibleDescription = "Contraseña ";
            this.pass.Location = new System.Drawing.Point(154, 147);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(202, 20);
            this.pass.TabIndex = 1;
            // 
            // Usuario
            // 
            this.Usuario.AccessibleDescription = "Nombre de usuario";
            this.Usuario.Location = new System.Drawing.Point(154, 112);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(202, 20);
            this.Usuario.TabIndex = 0;
            // 
            // label_Contrasenia
            // 
            this.label_Contrasenia.AutoSize = true;
            this.label_Contrasenia.Location = new System.Drawing.Point(70, 150);
            this.label_Contrasenia.Name = "label_Contrasenia";
            this.label_Contrasenia.Size = new System.Drawing.Size(61, 13);
            this.label_Contrasenia.TabIndex = 7;
            this.label_Contrasenia.Text = "Contraseña";
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Location = new System.Drawing.Point(70, 115);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(43, 13);
            this.label_Usuario.TabIndex = 6;
            this.label_Usuario.Text = "Usuario";
            // 
            // IntentosRestantes
            // 
            this.IntentosRestantes.AccessibleDescription = "Intentos restantes";
            this.IntentosRestantes.AutoSize = true;
            this.IntentosRestantes.Location = new System.Drawing.Point(70, 228);
            this.IntentosRestantes.Name = "IntentosRestantes";
            this.IntentosRestantes.Size = new System.Drawing.Size(97, 13);
            this.IntentosRestantes.TabIndex = 15;
            this.IntentosRestantes.Text = "Intentos restantes: ";
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Bienvenida.Location = new System.Drawing.Point(68, 38);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(125, 25);
            this.Bienvenida.TabIndex = 14;
            this.Bienvenida.Text = "Iniciar sesión";
            // 
            // Rol
            // 
            this.Rol.AccessibleDescription = "Rol ";
            this.Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rol.FormattingEnabled = true;
            this.Rol.Items.AddRange(new object[] {
            "Administrativo",
            "Cliente"});
            this.Rol.Location = new System.Drawing.Point(154, 181);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(202, 21);
            this.Rol.TabIndex = 2;
            // 
            // label_Rol
            // 
            this.label_Rol.AutoSize = true;
            this.label_Rol.Location = new System.Drawing.Point(70, 184);
            this.label_Rol.Name = "label_Rol";
            this.label_Rol.Size = new System.Drawing.Size(23, 13);
            this.label_Rol.TabIndex = 13;
            this.label_Rol.Text = "Rol";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(414, 366);
            this.Controls.Add(this.IntentosRestantes);
            this.Controls.Add(this.Bienvenida);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.IniciarSesion);
            this.Controls.Add(this.label_Rol);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label_Usuario);
            this.Controls.Add(this.label_Contrasenia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AerolineaFrba.SuperControls.SuperButton IniciarSesion;
        private AerolineaFrba.SuperControls.SuperButton Cerrar;
        private AerolineaFrba.SuperControls.SuperTextBox pass;
        private AerolineaFrba.SuperControls.SuperTextBox Usuario;
        private AerolineaFrba.SuperControls.SuperLabel label_Contrasenia;
        private AerolineaFrba.SuperControls.SuperLabel label_Usuario;
        private AerolineaFrba.SuperControls.SuperLabel label_Rol;
        private AerolineaFrba.SuperControls.SuperComboBox Rol;
        private AerolineaFrba.SuperControls.SuperLabel Bienvenida;
        private AerolineaFrba.SuperControls.SuperLabel IntentosRestantes;
    }
}
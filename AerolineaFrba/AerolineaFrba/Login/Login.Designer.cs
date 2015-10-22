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
            this.button_IniciarSesion = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Contrasenia = new System.Windows.Forms.Label();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Roles = new System.Windows.Forms.ComboBox();
            this.label_Rol = new System.Windows.Forms.Label();
            this.button_OlvidoContrasenia = new System.Windows.Forms.Button();
            this.Bienvenida = new AerolineaFrba.SuperControls.SuperLabel();
            this.NumeroIntentos = new AerolineaFrba.SuperControls.SuperLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_IniciarSesion
            // 
            this.button_IniciarSesion.Location = new System.Drawing.Point(584, 386);
            this.button_IniciarSesion.Name = "button_IniciarSesion";
            this.button_IniciarSesion.Size = new System.Drawing.Size(79, 27);
            this.button_IniciarSesion.TabIndex = 3;
            this.button_IniciarSesion.Text = "Iniciar sesión";
            this.button_IniciarSesion.UseVisualStyleBackColor = true;
            this.button_IniciarSesion.Click += new System.EventHandler(this.button_IniciarSesion_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cerrar.Location = new System.Drawing.Point(669, 386);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(86, 27);
            this.button_Cerrar.TabIndex = 4;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.AccessibleDescription = "Contraseña ";
            this.textBox_password.Location = new System.Drawing.Point(223, 145);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(202, 20);
            this.textBox_password.TabIndex = 1;
            // 
            // textBox_Username
            // 
            this.textBox_Username.AccessibleDescription = "Nombre de usuario";
            this.textBox_Username.Location = new System.Drawing.Point(223, 110);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(202, 20);
            this.textBox_Username.TabIndex = 0;
            // 
            // label_Contrasenia
            // 
            this.label_Contrasenia.AutoSize = true;
            this.label_Contrasenia.Location = new System.Drawing.Point(139, 148);
            this.label_Contrasenia.Name = "label_Contrasenia";
            this.label_Contrasenia.Size = new System.Drawing.Size(61, 13);
            this.label_Contrasenia.TabIndex = 7;
            this.label_Contrasenia.Text = "Contraseña";
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Location = new System.Drawing.Point(139, 113);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(43, 13);
            this.label_Usuario.TabIndex = 6;
            this.label_Usuario.Text = "Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumeroIntentos);
            this.groupBox1.Controls.Add(this.Bienvenida);
            this.groupBox1.Controls.Add(this.comboBox_Roles);
            this.groupBox1.Controls.Add(this.label_Rol);
            this.groupBox1.Controls.Add(this.button_OlvidoContrasenia);
            this.groupBox1.Controls.Add(this.textBox_password);
            this.groupBox1.Controls.Add(this.label_Usuario);
            this.groupBox1.Controls.Add(this.label_Contrasenia);
            this.groupBox1.Controls.Add(this.textBox_Username);
            this.groupBox1.Location = new System.Drawing.Point(174, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 288);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // comboBox_Roles
            // 
            this.comboBox_Roles.AccessibleDescription = "Rol ";
            this.comboBox_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Roles.FormattingEnabled = true;
            this.comboBox_Roles.Location = new System.Drawing.Point(223, 179);
            this.comboBox_Roles.Name = "comboBox_Roles";
            this.comboBox_Roles.Size = new System.Drawing.Size(202, 21);
            this.comboBox_Roles.TabIndex = 2;
            // 
            // label_Rol
            // 
            this.label_Rol.AutoSize = true;
            this.label_Rol.Location = new System.Drawing.Point(139, 182);
            this.label_Rol.Name = "label_Rol";
            this.label_Rol.Size = new System.Drawing.Size(23, 13);
            this.label_Rol.TabIndex = 13;
            this.label_Rol.Text = "Rol";
            // 
            // button_OlvidoContrasenia
            // 
            this.button_OlvidoContrasenia.AccessibleDescription = "Contraseña olvidada";
            this.button_OlvidoContrasenia.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_OlvidoContrasenia.FlatAppearance.BorderSize = 0;
            this.button_OlvidoContrasenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OlvidoContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OlvidoContrasenia.ForeColor = System.Drawing.Color.DarkRed;
            this.button_OlvidoContrasenia.Location = new System.Drawing.Point(310, 222);
            this.button_OlvidoContrasenia.Name = "button_OlvidoContrasenia";
            this.button_OlvidoContrasenia.Size = new System.Drawing.Size(115, 23);
            this.button_OlvidoContrasenia.TabIndex = 5;
            this.button_OlvidoContrasenia.Text = "Olvidé mi contraseña";
            this.button_OlvidoContrasenia.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_OlvidoContrasenia.UseVisualStyleBackColor = true;
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Bienvenida.Location = new System.Drawing.Point(116, 42);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(336, 25);
            this.Bienvenida.TabIndex = 14;
            this.Bienvenida.Text = "¡Bienvenido al sistema de aerolíneas!";
            // 
            // NumeroIntentos
            // 
            this.NumeroIntentos.AccessibleDescription = "Intentos restantes";
            this.NumeroIntentos.AutoSize = true;
            this.NumeroIntentos.Location = new System.Drawing.Point(139, 226);
            this.NumeroIntentos.Name = "NumeroIntentos";
            this.NumeroIntentos.Size = new System.Drawing.Size(94, 13);
            this.NumeroIntentos.TabIndex = 15;
            this.NumeroIntentos.Text = "Intentos restantes:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_IniciarSesion);
            this.Controls.Add(this.button_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese al sistema";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_IniciarSesion;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Contrasenia;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_OlvidoContrasenia;
        private System.Windows.Forms.Label label_Rol;
        private System.Windows.Forms.ComboBox comboBox_Roles;
        private SuperControls.SuperLabel Bienvenida;
        private SuperControls.SuperLabel NumeroIntentos;
    }
}
namespace AerolineaFrba.Abm_Rol
{
    partial class Alta
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
            this.superButton2 = new AerolineaFrba.SuperControls.SuperButton();
            this.superButton1 = new AerolineaFrba.SuperControls.SuperButton();
            this.superLabel2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Nombre = new AerolineaFrba.SuperControls.SuperTextBox();
            this.Estado = new AerolineaFrba.SuperControls.SuperCheckBox();
            this.superComboBox1 = new AerolineaFrba.SuperControls.SuperComboBox();
            this.superLabel3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Agregar = new AerolineaFrba.SuperControls.SuperButton();
            this.FuncionalidadesRol = new System.Windows.Forms.DataGridView();
            this.Funcionalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesRol)).BeginInit();
            this.SuspendLayout();
            // 
            // superButton2
            // 
            this.superButton2.Location = new System.Drawing.Point(345, 417);
            this.superButton2.Name = "superButton2";
            this.superButton2.Size = new System.Drawing.Size(75, 23);
            this.superButton2.TabIndex = 15;
            this.superButton2.Text = "Cerrar";
            this.superButton2.UseVisualStyleBackColor = true;
            // 
            // superButton1
            // 
            this.superButton1.Location = new System.Drawing.Point(253, 417);
            this.superButton1.Name = "superButton1";
            this.superButton1.Size = new System.Drawing.Size(75, 23);
            this.superButton1.TabIndex = 14;
            this.superButton1.Text = "Aceptar";
            this.superButton1.UseVisualStyleBackColor = true;
            // 
            // superLabel2
            // 
            this.superLabel2.AutoSize = true;
            this.superLabel2.Location = new System.Drawing.Point(41, 71);
            this.superLabel2.Name = "superLabel2";
            this.superLabel2.Size = new System.Drawing.Size(40, 13);
            this.superLabel2.TabIndex = 12;
            this.superLabel2.Text = "Estado";
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(41, 39);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(44, 13);
            this.superLabel1.TabIndex = 11;
            this.superLabel1.Text = "Nombre";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(131, 39);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 9;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(131, 71);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(73, 17);
            this.Estado.TabIndex = 8;
            this.Estado.Text = "Habilitado";
            this.Estado.UseVisualStyleBackColor = true;
            // 
            // superComboBox1
            // 
            this.superComboBox1.FormattingEnabled = true;
            this.superComboBox1.Location = new System.Drawing.Point(131, 102);
            this.superComboBox1.Name = "superComboBox1";
            this.superComboBox1.Size = new System.Drawing.Size(121, 21);
            this.superComboBox1.TabIndex = 16;
            // 
            // superLabel3
            // 
            this.superLabel3.AutoSize = true;
            this.superLabel3.Location = new System.Drawing.Point(41, 105);
            this.superLabel3.Name = "superLabel3";
            this.superLabel3.Size = new System.Drawing.Size(84, 13);
            this.superLabel3.TabIndex = 17;
            this.superLabel3.Text = "Funcionalidades";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(268, 100);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 18;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // FuncionalidadesRol
            // 
            this.FuncionalidadesRol.AllowUserToAddRows = false;
            this.FuncionalidadesRol.AllowUserToDeleteRows = false;
            this.FuncionalidadesRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FuncionalidadesRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionalidadesRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Funcionalidades,
            this.Eliminar});
            this.FuncionalidadesRol.Location = new System.Drawing.Point(44, 148);
            this.FuncionalidadesRol.Name = "FuncionalidadesRol";
            this.FuncionalidadesRol.Size = new System.Drawing.Size(376, 246);
            this.FuncionalidadesRol.TabIndex = 19;
            // 
            // Funcionalidades
            // 
            this.Funcionalidades.HeaderText = "Funcionalidades";
            this.Funcionalidades.Name = "Funcionalidades";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 457);
            this.Controls.Add(this.FuncionalidadesRol);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.superLabel3);
            this.Controls.Add(this.superComboBox1);
            this.Controls.Add(this.superButton2);
            this.Controls.Add(this.superButton1);
            this.Controls.Add(this.superLabel2);
            this.Controls.Add(this.superLabel1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Estado);
            this.Name = "Alta";
            this.Text = "Alta";
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperControls.SuperButton superButton2;
        private SuperControls.SuperButton superButton1;
        private SuperControls.SuperLabel superLabel2;
        private SuperControls.SuperLabel superLabel1;
        private SuperControls.SuperTextBox Nombre;
        private SuperControls.SuperCheckBox Estado;
        private SuperControls.SuperComboBox superComboBox1;
        private SuperControls.SuperLabel superLabel3;
        private SuperControls.SuperButton Agregar;
        private System.Windows.Forms.DataGridView FuncionalidadesRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminar;
    }
}
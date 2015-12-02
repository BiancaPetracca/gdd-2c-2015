namespace AerolineaFrba.Abm_Aeronave
{
    partial class AdminModelos
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
            this.Fabricante = new AerolineaFrba.SuperControls.SuperComboBox();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.modelos = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new AerolineaFrba.SuperControls.SuperButton();
            this.Modificar = new AerolineaFrba.SuperControls.SuperButton();
            ((System.ComponentModel.ISupportInitialize)(this.modelos)).BeginInit();
            this.SuspendLayout();
            // 
            // Fabricante
            // 
            this.Fabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Fabricante.FormattingEnabled = true;
            this.Fabricante.Location = new System.Drawing.Point(108, 31);
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.Size = new System.Drawing.Size(161, 21);
            this.Fabricante.TabIndex = 0;
            this.Fabricante.SelectedIndexChanged += new System.EventHandler(this.Fabricante_SelectedIndexChanged);
            // 
            // superLabel1
            // 
            this.superLabel1.AccessibleDescription = "fabricante";
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(27, 34);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(57, 13);
            this.superLabel1.TabIndex = 1;
            this.superLabel1.Text = "Fabricante";
            // 
            // modelos
            // 
            this.modelos.AllowUserToAddRows = false;
            this.modelos.AllowUserToDeleteRows = false;
            this.modelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo});
            this.modelos.Location = new System.Drawing.Point(30, 78);
            this.modelos.Name = "modelos";
            this.modelos.ReadOnly = true;
            this.modelos.Size = new System.Drawing.Size(239, 223);
            this.modelos.TabIndex = 2;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(308, 154);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 4;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(308, 205);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 5;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // AdminModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 348);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.modelos);
            this.Controls.Add(this.superLabel1);
            this.Controls.Add(this.Fabricante);
            this.Name = "AdminModelos";
            this.Text = "AdminModelos";
            this.Load += new System.EventHandler(this.AdminModelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperControls.SuperComboBox Fabricante;
        private SuperControls.SuperLabel superLabel1;
        private System.Windows.Forms.DataGridView modelos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private SuperControls.SuperButton Agregar;
        private SuperControls.SuperButton Modificar;
    }
}
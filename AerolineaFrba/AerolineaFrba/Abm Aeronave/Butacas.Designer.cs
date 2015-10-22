using AerolineaFrba.SuperControls;
namespace AerolineaFrba.Abm_Aeronave
{
    partial class Butacas
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Guardar = new AerolineaFrba.SuperControls.SuperButton();
            this.cancelar = new AerolineaFrba.SuperControls.SuperButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Tipo});
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(243, 409);
            this.grid.TabIndex = 0;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Butaca";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Items.AddRange(new object[] {
            "Pasillo",
            "Ventanilla"});
            this.Tipo.Name = "Tipo";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(180, 438);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 1;
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(94, 438);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 2;
            this.cancelar.Text = "Cancelar";
            this.cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Butacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 471);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.cancelar);
            this.Name = "Butacas";
            this.Text = "Butacas";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private SuperButton Guardar;
        private SuperButton cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
    }
}
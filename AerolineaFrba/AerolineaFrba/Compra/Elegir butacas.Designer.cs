namespace AerolineaFrba.Compra
{
    partial class Elegir_butacas
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
            this.col_butaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Guardar = new AerolineaFrba.SuperControls.SuperButton();
            this.cancelar = new AerolineaFrba.SuperControls.SuperButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_butaca,
            this.col_tipo});
            this.grid.Location = new System.Drawing.Point(33, 12);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(243, 409);
            this.grid.TabIndex = 3;
            // 
            // col_butaca
            // 
            this.col_butaca.FillWeight = 50F;
            this.col_butaca.HeaderText = "Butaca";
            this.col_butaca.Name = "col_butaca";
            this.col_butaca.ReadOnly = true;
            // 
            // col_tipo
            // 
            this.col_tipo.HeaderText = "Tipo";
            this.col_tipo.Items.AddRange(new object[] {
            "Pasillo",
            "Ventanilla"});
            this.col_tipo.Name = "col_tipo";
            this.col_tipo.ReadOnly = true;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(201, 438);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(115, 438);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 5;
            this.cancelar.Text = "Cancelar";
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // Elegir_butacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 478);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.cancelar);
            this.Name = "Elegir_butacas";
            this.Text = "Elegir_butacas";
            this.Load += new System.EventHandler(this.Elegir_butacas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_butaca;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_tipo;
        private SuperControls.SuperButton Guardar;
        private SuperControls.SuperButton cancelar;
    }
}
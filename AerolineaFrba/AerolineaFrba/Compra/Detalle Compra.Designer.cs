namespace AerolineaFrba.Compra
{
    partial class Detalle_Compra
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
            this.button1 = new System.Windows.Forms.Button();
            this.compra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.compra)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // compra
            // 
            this.compra.AllowUserToAddRows = false;
            this.compra.AllowUserToDeleteRows = false;
            this.compra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compra.Location = new System.Drawing.Point(26, 43);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(743, 213);
            this.compra.TabIndex = 2;
            this.compra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.compra_CellContentClick);
            // 
            // Detalle_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 350);
            this.Controls.Add(this.compra);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Detalle_Compra";
            this.Text = "Detalles de la compra";
            this.Load += new System.EventHandler(this.Detalle_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView compra;
    }
}
namespace AerolineaFrba.Canje_Millas
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RealizarCanje = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.FechaCanje = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductosCanjear = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosCanjear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RealizarCanje);
            this.groupBox1.Controls.Add(this.Cancelar);
            this.groupBox1.Controls.Add(this.FechaCanje);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DNI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ProductosCanjear);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canjear millas";
            // 
            // RealizarCanje
            // 
            this.RealizarCanje.Location = new System.Drawing.Point(653, 345);
            this.RealizarCanje.Name = "RealizarCanje";
            this.RealizarCanje.Size = new System.Drawing.Size(101, 23);
            this.RealizarCanje.TabIndex = 6;
            this.RealizarCanje.Text = "Realizar canje";
            this.RealizarCanje.UseVisualStyleBackColor = true;
            this.RealizarCanje.Click += new System.EventHandler(this.RealizarCanje_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(527, 345);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // FechaCanje
            // 
            this.FechaCanje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaCanje.Location = new System.Drawing.Point(52, 200);
            this.FechaCanje.Name = "FechaCanje";
            this.FechaCanje.Size = new System.Drawing.Size(119, 20);
            this.FechaCanje.MaxDate = System.DateTime.Today;
            this.FechaCanje.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese fecha de canje:";
            // 
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(52, 86);
            this.DNI.MaxLength = 8;
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(115, 20);
            this.DNI.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese DNI:";
            // 
            // ProductosCanjear
            // 
            this.ProductosCanjear.AllowUserToAddRows = false;
            this.ProductosCanjear.AllowUserToDeleteRows = false;
            this.ProductosCanjear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosCanjear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad});
            this.ProductosCanjear.Location = new System.Drawing.Point(411, 43);
            this.ProductosCanjear.Name = "ProductosCanjear";
            this.ProductosCanjear.Size = new System.Drawing.Size(343, 250);
            this.ProductosCanjear.TabIndex = 0;
            this.ProductosCanjear.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Producto
            // 
            dataGridViewCellStyle3.NullValue = "\"\"";
            this.Producto.DefaultCellStyle = dataGridViewCellStyle3;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Producto.Width = 200;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 425);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Canjear Millas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosCanjear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ProductosCanjear;
        private System.Windows.Forms.Button RealizarCanje;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DateTimePicker FechaCanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}
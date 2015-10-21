using AerolineaFrba.SuperControls;
namespace AerolineaFrba.Canje_Millas
{
    partial class Canje_Millas
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
            this.CanjearMillas = new System.Windows.Forms.GroupBox();
            this.AgregarProductos = new System.Windows.Forms.GroupBox();
            this.Agregar = new AerolineaFrba.SuperControls.SuperButton();
            this.superLabel2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superComboBox1 = new AerolineaFrba.SuperControls.SuperComboBox();
            this.superNumericUpDown1 = new SuperNumericUpDown();
            this.superLabel1 = new SuperLabel();
            this.RealizarCanje = new System.Windows.Forms.Button();
            this.Cancelar = new SuperButton();
            this.FechaCanje = new SuperDateTimePicker();
            this.label2 = new SuperLabel();
            this.DNI = new SuperTextBox();
            this.label1 = new SuperLabel();
            this.ProductosCanjear = new System.Windows.Forms.DataGridView();
            this.DatosCanjeador = new System.Windows.Forms.GroupBox();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanjearMillas.SuspendLayout();
            this.AgregarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosCanjear)).BeginInit();
            this.DatosCanjeador.SuspendLayout();
            this.SuspendLayout();
            // 
            // CanjearMillas
            // 
            this.CanjearMillas.Controls.Add(this.DatosCanjeador);
            this.CanjearMillas.Controls.Add(this.AgregarProductos);
            this.CanjearMillas.Controls.Add(this.RealizarCanje);
            this.CanjearMillas.Controls.Add(this.Cancelar);
            this.CanjearMillas.Controls.Add(this.ProductosCanjear);
            this.CanjearMillas.Location = new System.Drawing.Point(12, 12);
            this.CanjearMillas.Name = "CanjearMillas";
            this.CanjearMillas.Size = new System.Drawing.Size(794, 391);
            this.CanjearMillas.TabIndex = 0;
            this.CanjearMillas.TabStop = false;
            this.CanjearMillas.Text = "Canjear millas";
            // 
            // AgregarProductos
            // 
            this.AgregarProductos.Controls.Add(this.Agregar);
            this.AgregarProductos.Controls.Add(this.superLabel2);
            this.AgregarProductos.Controls.Add(this.superComboBox1);
            this.AgregarProductos.Controls.Add(this.superNumericUpDown1);
            this.AgregarProductos.Controls.Add(this.superLabel1);
            this.AgregarProductos.Location = new System.Drawing.Point(52, 217);
            this.AgregarProductos.Name = "AgregarProductos";
            this.AgregarProductos.Size = new System.Drawing.Size(280, 122);
            this.AgregarProductos.TabIndex = 10;
            this.AgregarProductos.TabStop = false;
            this.AgregarProductos.Text = "Agregar productos";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(184, 80);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 11;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // superLabel2
            // 
            this.superLabel2.AutoSize = true;
            this.superLabel2.Location = new System.Drawing.Point(26, 85);
            this.superLabel2.Name = "superLabel2";
            this.superLabel2.Size = new System.Drawing.Size(49, 13);
            this.superLabel2.TabIndex = 10;
            this.superLabel2.Text = "Cantidad";
            // 
            // superComboBox1
            // 
            this.superComboBox1.FormattingEnabled = true;
            this.superComboBox1.Location = new System.Drawing.Point(81, 39);
            this.superComboBox1.Name = "superComboBox1";
            this.superComboBox1.Size = new System.Drawing.Size(177, 21);
            this.superComboBox1.TabIndex = 7;
            // 
            // superNumericUpDown1
            // 
            this.superNumericUpDown1.Location = new System.Drawing.Point(82, 83);
            this.superNumericUpDown1.Name = "superNumericUpDown1";
            this.superNumericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.superNumericUpDown1.TabIndex = 8;
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(25, 42);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(50, 13);
            this.superLabel1.TabIndex = 9;
            this.superLabel1.Text = "Producto";
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
            this.FechaCanje.Location = new System.Drawing.Point(13, 119);
            this.FechaCanje.MaxDate = new System.DateTime(2015, 10, 20, 0, 0, 0, 0);
            this.FechaCanje.Name = "FechaCanje";
            this.FechaCanje.Size = new System.Drawing.Size(119, 20);
            this.FechaCanje.TabIndex = 4;
            this.FechaCanje.Value = new System.DateTime(2015, 10, 20, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese fecha de canje:";
            // 
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(16, 56);
            this.DNI.MaxLength = 8;
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(115, 20);
            this.DNI.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
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
            // DatosCanjeador
            // 
            this.DatosCanjeador.Controls.Add(this.DNI);
            this.DatosCanjeador.Controls.Add(this.label1);
            this.DatosCanjeador.Controls.Add(this.label2);
            this.DatosCanjeador.Controls.Add(this.FechaCanje);
            this.DatosCanjeador.Location = new System.Drawing.Point(52, 43);
            this.DatosCanjeador.Name = "DatosCanjeador";
            this.DatosCanjeador.Size = new System.Drawing.Size(280, 153);
            this.DatosCanjeador.TabIndex = 11;
            this.DatosCanjeador.TabStop = false;
            this.DatosCanjeador.Text = "Datos del canjeador";
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
            this.Cantidad.ReadOnly = true;
            // 
            // CanjeMillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 425);
            this.Controls.Add(this.CanjearMillas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Canjear Millas";
            this.CanjearMillas.ResumeLayout(false);
            this.AgregarProductos.ResumeLayout(false);
            this.AgregarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosCanjear)).EndInit();
            this.DatosCanjeador.ResumeLayout(false);
            this.DatosCanjeador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CanjearMillas;
        private System.Windows.Forms.DataGridView ProductosCanjear;
        private System.Windows.Forms.Button RealizarCanje;
        private System.Windows.Forms.Button Cancelar;
        private SuperDateTimePicker FechaCanje;
        private SuperLabel label2;
        private SuperTextBox DNI;
        private SuperLabel label1;
        private System.Windows.Forms.GroupBox AgregarProductos;
        private SuperControls.SuperButton Agregar;
        private SuperControls.SuperLabel superLabel2;
        private SuperControls.SuperComboBox superComboBox1;
        private SuperControls.SuperNumericUpDown superNumericUpDown1;
        private SuperControls.SuperLabel superLabel1;
        private System.Windows.Forms.GroupBox DatosCanjeador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CanjearMillas = new System.Windows.Forms.GroupBox();
            this.datosCanje = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.DatosCanjeador = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.tipoDNI = new AerolineaFrba.SuperControls.SuperComboBox();
            this.DNI = new AerolineaFrba.SuperControls.SuperTextBox();
            this.sumaParcialCanjes = new AerolineaFrba.SuperControls.SuperTextBox();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.verificar = new AerolineaFrba.SuperControls.SuperButton();
            this.millasQueTiene = new AerolineaFrba.SuperControls.SuperTextBox();
            this.lab_sumaParcialCanjes = new AerolineaFrba.SuperControls.SuperLabel();
            this.productosDisponibles = new System.Windows.Forms.DataGridView();
            this.col_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_millas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new AerolineaFrba.SuperControls.SuperButton();
            this.RealizarCanjes = new System.Windows.Forms.Button();
            this.Cancelar = new AerolineaFrba.SuperControls.SuperButton();
            this.ProductosCanjear = new System.Windows.Forms.DataGridView();
            this.col_producto_canjear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanjearMillas.SuspendLayout();
            this.datosCanje.SuspendLayout();
            this.DatosCanjeador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosCanjear)).BeginInit();
            this.SuspendLayout();
            // 
            // CanjearMillas
            // 
            this.CanjearMillas.Controls.Add(this.datosCanje);
            this.CanjearMillas.Controls.Add(this.productosDisponibles);
            this.CanjearMillas.Controls.Add(this.Agregar);
            this.CanjearMillas.Controls.Add(this.RealizarCanjes);
            this.CanjearMillas.Controls.Add(this.Cancelar);
            this.CanjearMillas.Controls.Add(this.ProductosCanjear);
            this.CanjearMillas.Location = new System.Drawing.Point(12, 12);
            this.CanjearMillas.Name = "CanjearMillas";
            this.CanjearMillas.Size = new System.Drawing.Size(896, 429);
            this.CanjearMillas.TabIndex = 0;
            this.CanjearMillas.TabStop = false;
            this.CanjearMillas.Text = "Canjear millas";
            // 
            // datosCanje
            // 
            this.datosCanje.Controls.Add(this.DatosCanjeador);
            this.datosCanje.Controls.Add(this.sumaParcialCanjes);
            this.datosCanje.Controls.Add(this.superLabel1);
            this.datosCanje.Controls.Add(this.verificar);
            this.datosCanje.Controls.Add(this.millasQueTiene);
            this.datosCanje.Controls.Add(this.lab_sumaParcialCanjes);
            this.datosCanje.Location = new System.Drawing.Point(49, 31);
            this.datosCanje.Name = "datosCanje";
            this.datosCanje.Size = new System.Drawing.Size(819, 62);
            this.datosCanje.TabIndex = 18;
            this.datosCanje.TabStop = false;
            // 
            // DatosCanjeador
            // 
            this.DatosCanjeador.AccessibleDescription = "DNI";
            this.DatosCanjeador.Controls.Add(this.tipoDNI);
            this.DatosCanjeador.Controls.Add(this.DNI);
            this.DatosCanjeador.Location = new System.Drawing.Point(21, 12);
            this.DatosCanjeador.Name = "DatosCanjeador";
            this.DatosCanjeador.Size = new System.Drawing.Size(243, 40);
            this.DatosCanjeador.TabIndex = 12;
            this.DatosCanjeador.TabStop = false;
            this.DatosCanjeador.Text = "DNI del cliente";
            // 
            // tipoDNI
            // 
            this.tipoDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDNI.FormattingEnabled = true;
            this.tipoDNI.Items.AddRange(new object[] {
            "DNI",
            "LI",
            "LC"});
            this.tipoDNI.Location = new System.Drawing.Point(31, 13);
            this.tipoDNI.Name = "tipoDNI";
            this.tipoDNI.Size = new System.Drawing.Size(58, 21);
            this.tipoDNI.TabIndex = 12;
            // 
            // DNI
            // 
            this.DNI.AccessibleDescription = "DNI del beneficiario";
            this.DNI.Location = new System.Drawing.Point(113, 13);
            this.DNI.MaxLength = 8;
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(115, 20);
            this.DNI.TabIndex = 2;
            this.DNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DNI_KeyPress);
            // 
            // sumaParcialCanjes
            // 
            this.sumaParcialCanjes.Location = new System.Drawing.Point(701, 25);
            this.sumaParcialCanjes.Name = "sumaParcialCanjes";
            this.sumaParcialCanjes.ReadOnly = true;
            this.sumaParcialCanjes.Size = new System.Drawing.Size(82, 20);
            this.sumaParcialCanjes.TabIndex = 17;
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(354, 28);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(83, 13);
            this.superLabel1.TabIndex = 14;
            this.superLabel1.Text = "Millas que tiene:";
            // 
            // verificar
            // 
            this.verificar.Location = new System.Drawing.Point(279, 23);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(56, 23);
            this.verificar.TabIndex = 11;
            this.verificar.Text = "Verificar";
            this.verificar.UseVisualStyleBackColor = true;
            this.verificar.Click += new System.EventHandler(this.verificar_Click);
            // 
            // millasQueTiene
            // 
            this.millasQueTiene.Location = new System.Drawing.Point(443, 25);
            this.millasQueTiene.Name = "millasQueTiene";
            this.millasQueTiene.ReadOnly = true;
            this.millasQueTiene.Size = new System.Drawing.Size(70, 20);
            this.millasQueTiene.TabIndex = 15;
            // 
            // lab_sumaParcialCanjes
            // 
            this.lab_sumaParcialCanjes.AutoSize = true;
            this.lab_sumaParcialCanjes.Location = new System.Drawing.Point(531, 28);
            this.lab_sumaParcialCanjes.Name = "lab_sumaParcialCanjes";
            this.lab_sumaParcialCanjes.Size = new System.Drawing.Size(164, 13);
            this.lab_sumaParcialCanjes.TabIndex = 16;
            this.lab_sumaParcialCanjes.Text = "Suma parcial millas en los canjes:";
            // 
            // productosDisponibles
            // 
            this.productosDisponibles.AllowUserToAddRows = false;
            this.productosDisponibles.AllowUserToDeleteRows = false;
            this.productosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_producto,
            this.col_millas,
            this.col_stock});
            this.productosDisponibles.Location = new System.Drawing.Point(49, 118);
            this.productosDisponibles.Name = "productosDisponibles";
            this.productosDisponibles.Size = new System.Drawing.Size(406, 218);
            this.productosDisponibles.TabIndex = 13;
            // 
            // col_producto
            // 
            this.col_producto.HeaderText = "Producto";
            this.col_producto.Name = "col_producto";
            this.col_producto.ReadOnly = true;
            // 
            // col_millas
            // 
            this.col_millas.HeaderText = "Millas que cuesta";
            this.col_millas.Name = "col_millas";
            this.col_millas.ReadOnly = true;
            // 
            // col_stock
            // 
            this.col_stock.HeaderText = "Unidades disponibles";
            this.col_stock.Name = "col_stock";
            this.col_stock.ReadOnly = true;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(347, 385);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(108, 23);
            this.Agregar.TabIndex = 11;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // RealizarCanjes
            // 
            this.RealizarCanjes.Location = new System.Drawing.Point(767, 385);
            this.RealizarCanjes.Name = "RealizarCanjes";
            this.RealizarCanjes.Size = new System.Drawing.Size(101, 23);
            this.RealizarCanjes.TabIndex = 6;
            this.RealizarCanjes.Text = "Realizar canjes";
            this.RealizarCanjes.UseVisualStyleBackColor = true;
            this.RealizarCanjes.Click += new System.EventHandler(this.RealizarCanje_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(641, 385);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // ProductosCanjear
            // 
            this.ProductosCanjear.AccessibleDescription = "Productos a canjear";
            this.ProductosCanjear.AllowUserToAddRows = false;
            this.ProductosCanjear.AllowUserToDeleteRows = false;
            this.ProductosCanjear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosCanjear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_producto_canjear,
            this.col_cantidad});
            this.ProductosCanjear.Location = new System.Drawing.Point(525, 118);
            this.ProductosCanjear.Name = "ProductosCanjear";
            this.ProductosCanjear.Size = new System.Drawing.Size(343, 218);
            this.ProductosCanjear.TabIndex = 0;
            this.ProductosCanjear.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // col_producto_canjear
            // 
            dataGridViewCellStyle1.NullValue = "\"\"";
            this.col_producto_canjear.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_producto_canjear.HeaderText = "Producto";
            this.col_producto_canjear.Name = "col_producto_canjear";
            this.col_producto_canjear.ReadOnly = true;
            this.col_producto_canjear.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_producto_canjear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_producto_canjear.Width = 200;
            // 
            // col_cantidad
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.col_cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_cantidad.HeaderText = "Cantidad";
            this.col_cantidad.Name = "col_cantidad";
            this.col_cantidad.ReadOnly = true;
            // 
            // Canje_Millas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 481);
            this.Controls.Add(this.CanjearMillas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Canje_Millas";
            this.Text = "Canjear Millas";
            this.Load += new System.EventHandler(this.Canje_Millas_Load);
            this.CanjearMillas.ResumeLayout(false);
            this.datosCanje.ResumeLayout(false);
            this.datosCanje.PerformLayout();
            this.DatosCanjeador.ResumeLayout(false);
            this.DatosCanjeador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosCanjear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CanjearMillas;
        private System.Windows.Forms.DataGridView ProductosCanjear;
        private System.Windows.Forms.Button RealizarCanjes;
        private SuperTextBox DNI;
        private SuperControls.SuperButton Agregar;
        private SuperButton Cancelar;
        private SuperButton verificar;
        private SuperGroupBox DatosCanjeador;
        private System.Windows.Forms.DataGridView productosDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_millas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stock;
        private SuperTextBox sumaParcialCanjes;
        private SuperLabel lab_sumaParcialCanjes;
        private SuperTextBox millasQueTiene;
        private SuperLabel superLabel1;
        private SuperComboBox tipoDNI;
        private SuperGroupBox datosCanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_producto_canjear;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cantidad;
    }
}
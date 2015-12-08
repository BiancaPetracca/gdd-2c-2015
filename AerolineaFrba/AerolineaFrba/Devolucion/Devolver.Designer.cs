namespace AerolineaFrba.Devolucion
{
    partial class Devolver
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pasajes = new AerolineaFrba.SuperControls.SuperComboBox();
            this.encomiendas = new AerolineaFrba.SuperControls.SuperComboBox();
            this.agregarEncomienda = new AerolineaFrba.SuperControls.SuperButton();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.CompraDevolver = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.tipo_doc = new AerolineaFrba.SuperControls.SuperComboBox();
            this.verCompras = new AerolineaFrba.SuperControls.SuperButton();
            this.codigoCompra = new AerolineaFrba.SuperControls.SuperComboBox();
            this.lab_dni = new AerolineaFrba.SuperControls.SuperLabel();
            this.dni = new AerolineaFrba.SuperControls.SuperTextBox();
            this.superLabel4 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.MotivoDevolucion = new AerolineaFrba.SuperControls.SuperTextBox();
            this.AgregarPasaje = new AerolineaFrba.SuperControls.SuperButton();
            this.Devoluciones = new System.Windows.Forms.DataGridView();
            this.col_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superLabel3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.RealizarDevolucion = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Cerrar = new AerolineaFrba.SuperControls.SuperButton();
            this.groupBox1.SuspendLayout();
            this.CompraDevolver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Devoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pasajes);
            this.groupBox1.Controls.Add(this.encomiendas);
            this.groupBox1.Controls.Add(this.agregarEncomienda);
            this.groupBox1.Controls.Add(this.superLabel1);
            this.groupBox1.Controls.Add(this.CompraDevolver);
            this.groupBox1.Controls.Add(this.AgregarPasaje);
            this.groupBox1.Controls.Add(this.Devoluciones);
            this.groupBox1.Controls.Add(this.superLabel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devolución";
            // 
            // pasajes
            // 
            this.pasajes.AccessibleDescription = "Elegir un pasaje";
            this.pasajes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pasajes.FormattingEnabled = true;
            this.pasajes.Location = new System.Drawing.Point(636, 49);
            this.pasajes.Name = "pasajes";
            this.pasajes.Size = new System.Drawing.Size(121, 21);
            this.pasajes.TabIndex = 12;
            // 
            // encomiendas
            // 
            this.encomiendas.AccessibleDescription = "Elegir una encomienda";
            this.encomiendas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encomiendas.FormattingEnabled = true;
            this.encomiendas.Location = new System.Drawing.Point(636, 85);
            this.encomiendas.Name = "encomiendas";
            this.encomiendas.Size = new System.Drawing.Size(121, 21);
            this.encomiendas.TabIndex = 11;
            // 
            // agregarEncomienda
            // 
            this.agregarEncomienda.Location = new System.Drawing.Point(780, 82);
            this.agregarEncomienda.Name = "agregarEncomienda";
            this.agregarEncomienda.Size = new System.Drawing.Size(131, 24);
            this.agregarEncomienda.TabIndex = 9;
            this.agregarEncomienda.Text = "Agregar encomienda";
            this.agregarEncomienda.UseVisualStyleBackColor = true;
            this.agregarEncomienda.Click += new System.EventHandler(this.agregarEncomienda_Click);
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(565, 89);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(71, 13);
            this.superLabel1.TabIndex = 8;
            this.superLabel1.Text = "Encomiendas";
            // 
            // CompraDevolver
            // 
            this.CompraDevolver.Controls.Add(this.tipo_doc);
            this.CompraDevolver.Controls.Add(this.verCompras);
            this.CompraDevolver.Controls.Add(this.codigoCompra);
            this.CompraDevolver.Controls.Add(this.lab_dni);
            this.CompraDevolver.Controls.Add(this.dni);
            this.CompraDevolver.Controls.Add(this.superLabel4);
            this.CompraDevolver.Controls.Add(this.superLabel2);
            this.CompraDevolver.Controls.Add(this.MotivoDevolucion);
            this.CompraDevolver.Location = new System.Drawing.Point(29, 19);
            this.CompraDevolver.Name = "CompraDevolver";
            this.CompraDevolver.Size = new System.Drawing.Size(518, 114);
            this.CompraDevolver.TabIndex = 1;
            this.CompraDevolver.TabStop = false;
            this.CompraDevolver.Text = "Nueva devolución";
            // 
            // tipo_doc
            // 
            this.tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_doc.FormattingEnabled = true;
            this.tipo_doc.Items.AddRange(new object[] {
            "DNI",
            "LI",
            "LC"});
            this.tipo_doc.Location = new System.Drawing.Point(24, 30);
            this.tipo_doc.Name = "tipo_doc";
            this.tipo_doc.Size = new System.Drawing.Size(67, 21);
            this.tipo_doc.TabIndex = 12;
            // 
            // verCompras
            // 
            this.verCompras.Location = new System.Drawing.Point(280, 26);
            this.verCompras.Name = "verCompras";
            this.verCompras.Size = new System.Drawing.Size(112, 23);
            this.verCompras.TabIndex = 11;
            this.verCompras.Text = "Mostrar compras";
            this.verCompras.UseVisualStyleBackColor = true;
            this.verCompras.Click += new System.EventHandler(this.verCompras_Click);
            // 
            // codigoCompra
            // 
            this.codigoCompra.AccessibleDescription = "Código de compra o PNR";
            this.codigoCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codigoCompra.FormattingEnabled = true;
            this.codigoCompra.Location = new System.Drawing.Point(77, 67);
            this.codigoCompra.Name = "codigoCompra";
            this.codigoCompra.Size = new System.Drawing.Size(121, 21);
            this.codigoCompra.TabIndex = 10;
            this.codigoCompra.SelectedIndexChanged += new System.EventHandler(this.codigoCompra_SelectedIndexChanged);
            // 
            // lab_dni
            // 
            this.lab_dni.AutoSize = true;
            this.lab_dni.Location = new System.Drawing.Point(107, 32);
            this.lab_dni.Name = "lab_dni";
            this.lab_dni.Size = new System.Drawing.Size(26, 13);
            this.lab_dni.TabIndex = 9;
            this.lab_dni.Text = "DNI";
            // 
            // dni
            // 
            this.dni.AccessibleDescription = "DNI";
            this.dni.Location = new System.Drawing.Point(148, 29);
            this.dni.MaxLength = 8;
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(103, 20);
            this.dni.TabIndex = 8;
            this.dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.superTextBox1_KeyPress);
            // 
            // superLabel4
            // 
            this.superLabel4.AutoSize = true;
            this.superLabel4.Location = new System.Drawing.Point(259, 74);
            this.superLabel4.Name = "superLabel4";
            this.superLabel4.Size = new System.Drawing.Size(39, 13);
            this.superLabel4.TabIndex = 7;
            this.superLabel4.Text = "Motivo";
            // 
            // superLabel2
            // 
            this.superLabel2.AutoSize = true;
            this.superLabel2.Location = new System.Drawing.Point(21, 74);
            this.superLabel2.Name = "superLabel2";
            this.superLabel2.Size = new System.Drawing.Size(30, 13);
            this.superLabel2.TabIndex = 5;
            this.superLabel2.Text = "PNR";
            // 
            // MotivoDevolucion
            // 
            this.MotivoDevolucion.AccessibleDescription = "Elegir un motivo";
            this.MotivoDevolucion.Location = new System.Drawing.Point(313, 71);
            this.MotivoDevolucion.MaxLength = 30;
            this.MotivoDevolucion.Name = "MotivoDevolucion";
            this.MotivoDevolucion.Size = new System.Drawing.Size(151, 20);
            this.MotivoDevolucion.TabIndex = 3;
            this.MotivoDevolucion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MotivoDevolucion_KeyPress);
            // 
            // AgregarPasaje
            // 
            this.AgregarPasaje.Location = new System.Drawing.Point(780, 47);
            this.AgregarPasaje.Name = "AgregarPasaje";
            this.AgregarPasaje.Size = new System.Drawing.Size(131, 23);
            this.AgregarPasaje.TabIndex = 3;
            this.AgregarPasaje.Text = "Agregar pasaje";
            this.AgregarPasaje.UseVisualStyleBackColor = true;
            this.AgregarPasaje.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Devoluciones
            // 
            this.Devoluciones.AllowUserToAddRows = false;
            this.Devoluciones.AllowUserToDeleteRows = false;
            this.Devoluciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Devoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Devoluciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_compra,
            this.col_item,
            this.col_motivo});
            this.Devoluciones.Location = new System.Drawing.Point(29, 155);
            this.Devoluciones.Name = "Devoluciones";
            this.Devoluciones.ReadOnly = true;
            this.Devoluciones.Size = new System.Drawing.Size(882, 209);
            this.Devoluciones.TabIndex = 0;
            // 
            // col_compra
            // 
            this.col_compra.HeaderText = "PNR";
            this.col_compra.Name = "col_compra";
            this.col_compra.ReadOnly = true;
            // 
            // col_item
            // 
            this.col_item.HeaderText = "Codigo de pasaje / encomienda";
            this.col_item.Name = "col_item";
            this.col_item.ReadOnly = true;
            // 
            // col_motivo
            // 
            this.col_motivo.HeaderText = "Motivo";
            this.col_motivo.Name = "col_motivo";
            this.col_motivo.ReadOnly = true;
            // 
            // superLabel3
            // 
            this.superLabel3.AutoSize = true;
            this.superLabel3.Location = new System.Drawing.Point(565, 52);
            this.superLabel3.Name = "superLabel3";
            this.superLabel3.Size = new System.Drawing.Size(44, 13);
            this.superLabel3.TabIndex = 6;
            this.superLabel3.Text = "Pasajes";
            // 
            // RealizarDevolucion
            // 
            this.RealizarDevolucion.Location = new System.Drawing.Point(648, 421);
            this.RealizarDevolucion.Name = "RealizarDevolucion";
            this.RealizarDevolucion.Size = new System.Drawing.Size(108, 23);
            this.RealizarDevolucion.TabIndex = 1;
            this.RealizarDevolucion.Text = "Realizar devolución";
            this.RealizarDevolucion.UseVisualStyleBackColor = true;
            this.RealizarDevolucion.Click += new System.EventHandler(this.RealizarDevolucion_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(767, 421);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 2;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(848, 421);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 4;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Devolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 456);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.RealizarDevolucion);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Devolver";
            this.Text = "Devolución";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CompraDevolver.ResumeLayout(false);
            this.CompraDevolver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Devoluciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Devoluciones;
        private System.Windows.Forms.Button RealizarDevolucion;
        private System.Windows.Forms.Button Limpiar;
        private SuperControls.SuperButton AgregarPasaje;
        private SuperControls.SuperGroupBox CompraDevolver;
        private SuperControls.SuperTextBox MotivoDevolucion;
        private SuperControls.SuperButton Cerrar;
        private SuperControls.SuperLabel superLabel4;
        private SuperControls.SuperLabel superLabel3;
        private SuperControls.SuperLabel superLabel2;
        private SuperControls.SuperLabel superLabel1;
        private SuperControls.SuperButton agregarEncomienda;
        private SuperControls.SuperLabel lab_dni;
        private SuperControls.SuperTextBox dni;
        private SuperControls.SuperComboBox pasajes;
        private SuperControls.SuperComboBox encomiendas;
        private SuperControls.SuperComboBox codigoCompra;
        private SuperControls.SuperButton verCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_motivo;
        private SuperControls.SuperComboBox tipo_doc;
    }
}
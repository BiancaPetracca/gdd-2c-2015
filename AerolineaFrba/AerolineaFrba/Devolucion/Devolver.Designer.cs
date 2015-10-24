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
            this.CompraDevolver = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.superLabel4 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Agregar = new AerolineaFrba.SuperControls.SuperButton();
            this.superLabel3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.MotivoDevolucion = new AerolineaFrba.SuperControls.SuperTextBox();
            this.Codigo = new AerolineaFrba.SuperControls.SuperTextBox();
            this.PNR = new AerolineaFrba.SuperControls.SuperTextBox();
            this.Fecha = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.Devoluciones = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Controls.Add(this.CompraDevolver);
            this.groupBox1.Controls.Add(this.Devoluciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devolución";
            // 
            // CompraDevolver
            // 
            this.CompraDevolver.Controls.Add(this.superLabel4);
            this.CompraDevolver.Controls.Add(this.Agregar);
            this.CompraDevolver.Controls.Add(this.superLabel3);
            this.CompraDevolver.Controls.Add(this.superLabel2);
            this.CompraDevolver.Controls.Add(this.superLabel1);
            this.CompraDevolver.Controls.Add(this.MotivoDevolucion);
            this.CompraDevolver.Controls.Add(this.Codigo);
            this.CompraDevolver.Controls.Add(this.PNR);
            this.CompraDevolver.Controls.Add(this.Fecha);
            this.CompraDevolver.Location = new System.Drawing.Point(29, 19);
            this.CompraDevolver.Name = "CompraDevolver";
            this.CompraDevolver.Size = new System.Drawing.Size(882, 119);
            this.CompraDevolver.TabIndex = 1;
            this.CompraDevolver.TabStop = false;
            this.CompraDevolver.Text = "Nueva devolución";
            // 
            // superLabel4
            // 
            this.superLabel4.AutoSize = true;
            this.superLabel4.Location = new System.Drawing.Point(21, 75);
            this.superLabel4.Name = "superLabel4";
            this.superLabel4.Size = new System.Drawing.Size(39, 13);
            this.superLabel4.TabIndex = 7;
            this.superLabel4.Text = "Motivo";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(780, 69);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 3;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // superLabel3
            // 
            this.superLabel3.AutoSize = true;
            this.superLabel3.Location = new System.Drawing.Point(512, 30);
            this.superLabel3.Name = "superLabel3";
            this.superLabel3.Size = new System.Drawing.Size(159, 13);
            this.superLabel3.TabIndex = 6;
            this.superLabel3.Text = "Código de pasaje o encomienda";
            // 
            // superLabel2
            // 
            this.superLabel2.AutoSize = true;
            this.superLabel2.Location = new System.Drawing.Point(260, 30);
            this.superLabel2.Name = "superLabel2";
            this.superLabel2.Size = new System.Drawing.Size(30, 13);
            this.superLabel2.TabIndex = 5;
            this.superLabel2.Text = "PNR";
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(21, 30);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(37, 13);
            this.superLabel1.TabIndex = 4;
            this.superLabel1.Text = "Fecha";
            // 
            // MotivoDevolucion
            // 
            this.MotivoDevolucion.Location = new System.Drawing.Point(107, 72);
            this.MotivoDevolucion.Name = "MotivoDevolucion";
            this.MotivoDevolucion.Size = new System.Drawing.Size(431, 20);
            this.MotivoDevolucion.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(701, 27);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(154, 20);
            this.Codigo.TabIndex = 2;
            // 
            // PNR
            // 
            this.PNR.Location = new System.Drawing.Point(310, 28);
            this.PNR.Name = "PNR";
            this.PNR.Size = new System.Drawing.Size(151, 20);
            this.PNR.TabIndex = 1;
            // 
            // Fecha
            // 
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha.Location = new System.Drawing.Point(129, 28);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(88, 20);
            this.Fecha.TabIndex = 0;
            // 
            // Devoluciones
            // 
            this.Devoluciones.AllowUserToAddRows = false;
            this.Devoluciones.AllowUserToDeleteRows = false;
            this.Devoluciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Devoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Devoluciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Motivo});
            this.Devoluciones.Location = new System.Drawing.Point(29, 155);
            this.Devoluciones.Name = "Devoluciones";
            this.Devoluciones.ReadOnly = true;
            this.Devoluciones.Size = new System.Drawing.Size(882, 209);
            this.Devoluciones.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PNR";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Codigo de pasaje / encomienda";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private SuperControls.SuperButton Agregar;
        private SuperControls.SuperGroupBox CompraDevolver;
        private SuperControls.SuperTextBox MotivoDevolucion;
        private SuperControls.SuperTextBox Codigo;
        private SuperControls.SuperTextBox PNR;
        private SuperControls.SuperDateTimePicker Fecha;
        private SuperControls.SuperButton Cerrar;
        private SuperControls.SuperLabel superLabel4;
        private SuperControls.SuperLabel superLabel3;
        private SuperControls.SuperLabel superLabel2;
        private SuperControls.SuperLabel superLabel1;
    }
}
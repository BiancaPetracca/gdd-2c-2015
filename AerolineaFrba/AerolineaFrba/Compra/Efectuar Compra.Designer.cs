using AerolineaFrba.SuperControls;
namespace AerolineaFrba.Compra
{
    partial class Efectuar_Compra
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
            this.groupBox1 = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.datosTarjeta = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.label7 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Cuotas = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            this.label6 = new AerolineaFrba.SuperControls.SuperLabel();
            this.CodigoSeguridad = new AerolineaFrba.SuperControls.SuperTextBox();
            this.label5 = new AerolineaFrba.SuperControls.SuperLabel();
            this.NumeroTarjeta = new AerolineaFrba.SuperControls.SuperTextBox();
            this.label4 = new AerolineaFrba.SuperControls.SuperLabel();
            this.FechaExpiracion = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.label3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.TipoTarjeta = new AerolineaFrba.SuperControls.SuperComboBox();
            this.Cancelar = new AerolineaFrba.SuperControls.SuperButton();
            this.datosPersonales = new System.Windows.Forms.DataGridView();
            this.col_tipo_doc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirmar = new AerolineaFrba.SuperControls.SuperButton();
            this.label1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.MedioPago = new AerolineaFrba.SuperControls.SuperComboBox();
            this.groupBox1.SuspendLayout();
            this.datosTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPersonales)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datosTarjeta);
            this.groupBox1.Controls.Add(this.Cancelar);
            this.groupBox1.Controls.Add(this.datosPersonales);
            this.groupBox1.Controls.Add(this.Confirmar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MedioPago);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar datos de compra";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // datosTarjeta
            // 
            this.datosTarjeta.Controls.Add(this.label7);
            this.datosTarjeta.Controls.Add(this.Cuotas);
            this.datosTarjeta.Controls.Add(this.label6);
            this.datosTarjeta.Controls.Add(this.CodigoSeguridad);
            this.datosTarjeta.Controls.Add(this.label5);
            this.datosTarjeta.Controls.Add(this.NumeroTarjeta);
            this.datosTarjeta.Controls.Add(this.label4);
            this.datosTarjeta.Controls.Add(this.FechaExpiracion);
            this.datosTarjeta.Controls.Add(this.label3);
            this.datosTarjeta.Controls.Add(this.TipoTarjeta);
            this.datosTarjeta.Location = new System.Drawing.Point(43, 172);
            this.datosTarjeta.Name = "datosTarjeta";
            this.datosTarjeta.Size = new System.Drawing.Size(1010, 169);
            this.datosTarjeta.TabIndex = 6;
            this.datosTarjeta.TabStop = false;
            this.datosTarjeta.Text = "Datos de la tarjeta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cuotas";
            // 
            // Cuotas
            // 
            this.Cuotas.AccessibleDescription = "Cuotas en las que desee pagarlo";
            this.Cuotas.Location = new System.Drawing.Point(699, 124);
            this.Cuotas.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.Cuotas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.ReadOnly = true;
            this.Cuotas.Size = new System.Drawing.Size(41, 20);
            this.Cuotas.TabIndex = 8;
            this.Cuotas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Código de seguridad";
            // 
            // CodigoSeguridad
            // 
            this.CodigoSeguridad.AccessibleDescription = "Ingresar código de seguridad de la tarjeta";
            this.CodigoSeguridad.Location = new System.Drawing.Point(509, 43);
            this.CodigoSeguridad.MaxLength = 3;
            this.CodigoSeguridad.Name = "CodigoSeguridad";
            this.CodigoSeguridad.Size = new System.Drawing.Size(86, 20);
            this.CodigoSeguridad.TabIndex = 6;
            this.CodigoSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoSeguridad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Número de tarjeta";
            // 
            // NumeroTarjeta
            // 
            this.NumeroTarjeta.AccessibleDescription = "Ingresar el número de la tarjeta";
            this.NumeroTarjeta.Location = new System.Drawing.Point(143, 46);
            this.NumeroTarjeta.MaxLength = 16;
            this.NumeroTarjeta.Name = "NumeroTarjeta";
            this.NumeroTarjeta.Size = new System.Drawing.Size(181, 20);
            this.NumeroTarjeta.TabIndex = 4;
            this.NumeroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroTarjeta_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de expiración";
            // 
            // FechaExpiracion
            // 
            this.FechaExpiracion.AccessibleDescription = "Fecha de expiración";
            this.FechaExpiracion.CustomFormat = "MM/yyyy";
            this.FechaExpiracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaExpiracion.Location = new System.Drawing.Point(509, 124);
            this.FechaExpiracion.Name = "FechaExpiracion";
            this.FechaExpiracion.Size = new System.Drawing.Size(86, 20);
            this.FechaExpiracion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo";
            // 
            // TipoTarjeta
            // 
            this.TipoTarjeta.AccessibleDescription = "Tipo de la tarjeta";
            this.TipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoTarjeta.FormattingEnabled = true;
            this.TipoTarjeta.Items.AddRange(new object[] {
            "Mastercard",
            "American Express",
            "Visa"});
            this.TipoTarjeta.Location = new System.Drawing.Point(143, 122);
            this.TipoTarjeta.Name = "TipoTarjeta";
            this.TipoTarjeta.Size = new System.Drawing.Size(181, 21);
            this.TipoTarjeta.TabIndex = 0;
            this.TipoTarjeta.SelectedIndexChanged += new System.EventHandler(this.TipoTarjeta_SelectedIndexChanged);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(978, 369);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // datosPersonales
            // 
            this.datosPersonales.AllowUserToAddRows = false;
            this.datosPersonales.AllowUserToDeleteRows = false;
            this.datosPersonales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datosPersonales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosPersonales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_tipo_doc,
            this.col_dni,
            this.col_nombre,
            this.col_apellido,
            this.col_direccion,
            this.col_telefono,
            this.col_mail,
            this.col_fecha_nac});
            this.datosPersonales.Location = new System.Drawing.Point(43, 80);
            this.datosPersonales.Name = "datosPersonales";
            this.datosPersonales.Size = new System.Drawing.Size(1010, 86);
            this.datosPersonales.TabIndex = 3;
           
            this.datosPersonales.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.datosPersonales_CellValueChanged);
         
            // 
            // col_tipo_doc
            // 
            this.col_tipo_doc.DataPropertyName = "cli_tipo_doc";
            this.col_tipo_doc.HeaderText = "Tipo de documento";
            this.col_tipo_doc.Items.AddRange(new object[] {
            "DNI",
            "LI",
            "LC"});
            this.col_tipo_doc.Name = "col_tipo_doc";
            // 
            // col_dni
            // 
            this.col_dni.DataPropertyName = "cli_nro_doc";
            this.col_dni.HeaderText = "Número de documento";
            this.col_dni.Name = "col_dni";
            // 
            // col_nombre
            // 
            this.col_nombre.DataPropertyName = "cli_nombre";
            this.col_nombre.HeaderText = "Nombre";
            this.col_nombre.Name = "col_nombre";
            // 
            // col_apellido
            // 
            this.col_apellido.DataPropertyName = "cli_apellido";
            this.col_apellido.HeaderText = "Apellido";
            this.col_apellido.Name = "col_apellido";
            // 
            // col_direccion
            // 
            this.col_direccion.DataPropertyName = "cli_direccion";
            this.col_direccion.HeaderText = "Dirección";
            this.col_direccion.Name = "col_direccion";
            // 
            // col_telefono
            // 
            this.col_telefono.DataPropertyName = "cli_telefono";
            this.col_telefono.HeaderText = "Teléfono";
            this.col_telefono.Name = "col_telefono";
            // 
            // col_mail
            // 
            this.col_mail.DataPropertyName = "cli_mail";
            this.col_mail.HeaderText = "Mail";
            this.col_mail.Name = "col_mail";
            // 
            // col_fecha_nac
            // 
            this.col_fecha_nac.DataPropertyName = "cli_fecha_nac";
            this.col_fecha_nac.HeaderText = "Fecha de nacimiento";
            this.col_fecha_nac.Name = "col_fecha_nac";
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(869, 369);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Confirmar.TabIndex = 2;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medio de pago";
            // 
            // MedioPago
            // 
            this.MedioPago.AccessibleDescription = "Elegir un medio de pago";
            this.MedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MedioPago.FormattingEnabled = true;
            this.MedioPago.Items.AddRange(new object[] {
            "Tarjeta",
            "Efectivo"});
            this.MedioPago.Location = new System.Drawing.Point(163, 32);
            this.MedioPago.Name = "MedioPago";
            this.MedioPago.Size = new System.Drawing.Size(121, 21);
            this.MedioPago.TabIndex = 0;
            this.MedioPago.SelectedIndexChanged += new System.EventHandler(this.MedioPago_SelectedIndexChanged);
            // 
            // Efectuar_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 458);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Efectuar_Compra";
            this.Text = "Efectuar_Compra";
            this.Load += new System.EventHandler(this.Efectuar_Compra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.datosTarjeta.ResumeLayout(false);
            this.datosTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPersonales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SuperGroupBox groupBox1;
        private System.Windows.Forms.DataGridView datosPersonales;
        private SuperButton Confirmar;
        private SuperLabel label1;
        private SuperComboBox MedioPago;
        private SuperGroupBox datosTarjeta;
        private SuperLabel label6;
        private SuperTextBox CodigoSeguridad;
        private SuperLabel label5;
        private SuperTextBox NumeroTarjeta;
        private SuperLabel label4;
        private SuperDateTimePicker FechaExpiracion;
        private SuperLabel label3;
        private SuperComboBox TipoTarjeta;
        private SuperButton Cancelar;
        private SuperLabel label7;
        private SuperNumericUpDown Cuotas;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_nac;
    }
}
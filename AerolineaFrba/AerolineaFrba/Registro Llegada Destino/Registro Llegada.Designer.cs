using AerolineaFrba.Generics;
namespace AerolineaFrba.Registro_Llegada_Destino
{
    partial class RegistroLlegadaAeronave
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
            this.Cerrar = new System.Windows.Forms.Button();
            this.registros = new System.Windows.Forms.DataGridView();
            this.col_matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeronaveLlegada = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.superLabel4 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.matricula = new AerolineaFrba.SuperControls.SuperComboBox();
            this.Agregar = new AerolineaFrba.SuperControls.SuperButton();
            this.fechaLlegada = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.AeropuertoDestino = new AerolineaFrba.SuperControls.SuperComboBox();
            this.AeropuertoOrigen = new AerolineaFrba.SuperControls.SuperComboBox();
            this.guardar = new AerolineaFrba.SuperControls.SuperButton();
            ((System.ComponentModel.ISupportInitialize)(this.registros)).BeginInit();
            this.aeronaveLlegada.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(803, 357);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 9;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // registros
            // 
            this.registros.AllowUserToAddRows = false;
            this.registros.AllowUserToDeleteRows = false;
            this.registros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_matricula,
            this.col_origen,
            this.col_destino,
            this.col_llegada});
            this.registros.Location = new System.Drawing.Point(66, 141);
            this.registros.Name = "registros";
            this.registros.Size = new System.Drawing.Size(812, 192);
            this.registros.TabIndex = 11;
            // 
            // col_matricula
            // 
            this.col_matricula.HeaderText = "Matrícula";
            this.col_matricula.Name = "col_matricula";
            this.col_matricula.ReadOnly = true;
            // 
            // col_origen
            // 
            this.col_origen.HeaderText = "Origen";
            this.col_origen.Name = "col_origen";
            this.col_origen.ReadOnly = true;
            // 
            // col_destino
            // 
            this.col_destino.HeaderText = "Destino";
            this.col_destino.Name = "col_destino";
            this.col_destino.ReadOnly = true;
            // 
            // col_llegada
            // 
            this.col_llegada.HeaderText = "Llegada";
            this.col_llegada.Name = "col_llegada";
            this.col_llegada.ReadOnly = true;
            // 
            // aeronaveLlegada
            // 
            this.aeronaveLlegada.Controls.Add(this.superLabel4);
            this.aeronaveLlegada.Controls.Add(this.superLabel3);
            this.aeronaveLlegada.Controls.Add(this.superLabel2);
            this.aeronaveLlegada.Controls.Add(this.superLabel1);
            this.aeronaveLlegada.Controls.Add(this.matricula);
            this.aeronaveLlegada.Controls.Add(this.Agregar);
            this.aeronaveLlegada.Controls.Add(this.fechaLlegada);
            this.aeronaveLlegada.Controls.Add(this.AeropuertoDestino);
            this.aeronaveLlegada.Controls.Add(this.AeropuertoOrigen);
            this.aeronaveLlegada.Location = new System.Drawing.Point(66, 12);
            this.aeronaveLlegada.Name = "aeronaveLlegada";
            this.aeronaveLlegada.Size = new System.Drawing.Size(812, 109);
            this.aeronaveLlegada.TabIndex = 17;
            this.aeronaveLlegada.TabStop = false;
            this.aeronaveLlegada.Text = "Datos llegada";
            // 
            // superLabel4
            // 
            this.superLabel4.AutoSize = true;
            this.superLabel4.Location = new System.Drawing.Point(354, 63);
            this.superLabel4.Name = "superLabel4";
            this.superLabel4.Size = new System.Drawing.Size(98, 13);
            this.superLabel4.TabIndex = 20;
            this.superLabel4.Text = "Aeropuerto Destino";
            // 
            // superLabel3
            // 
            this.superLabel3.AutoSize = true;
            this.superLabel3.Location = new System.Drawing.Point(354, 33);
            this.superLabel3.Name = "superLabel3";
            this.superLabel3.Size = new System.Drawing.Size(93, 13);
            this.superLabel3.TabIndex = 19;
            this.superLabel3.Text = "Aeropuerto Origen";
            // 
            // superLabel2
            // 
            this.superLabel2.AutoSize = true;
            this.superLabel2.Location = new System.Drawing.Point(78, 63);
            this.superLabel2.Name = "superLabel2";
            this.superLabel2.Size = new System.Drawing.Size(45, 13);
            this.superLabel2.TabIndex = 18;
            this.superLabel2.Text = "Llegada";
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(71, 34);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(52, 13);
            this.superLabel1.TabIndex = 17;
            this.superLabel1.Text = "Matrícula";
            // 
            // matricula
            // 
            this.matricula.AccessibleDescription = "Matrícula";
            this.matricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matricula.FormattingEnabled = true;
            this.matricula.Location = new System.Drawing.Point(164, 29);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(141, 21);
            this.matricula.TabIndex = 10;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(647, 43);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 16;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click_1);
            // 
            // fechaLlegada
            // 
            this.fechaLlegada.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaLlegada.Location = new System.Drawing.Point(164, 63);
            this.fechaLlegada.Name = "fechaLlegada";
            this.fechaLlegada.Size = new System.Drawing.Size(141, 20);
            this.fechaLlegada.TabIndex = 15;
        
            // 
            // AeropuertoDestino
            // 
            this.AeropuertoDestino.AccessibleDescription = "Destino";
            this.AeropuertoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AeropuertoDestino.FormattingEnabled = true;
            this.AeropuertoDestino.Location = new System.Drawing.Point(468, 63);
            this.AeropuertoDestino.Name = "AeropuertoDestino";
            this.AeropuertoDestino.Size = new System.Drawing.Size(141, 21);
            this.AeropuertoDestino.TabIndex = 14;
            // 
            // AeropuertoOrigen
            // 
            this.AeropuertoOrigen.AccessibleDescription = "Origen";
            this.AeropuertoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AeropuertoOrigen.FormattingEnabled = true;
            this.AeropuertoOrigen.Location = new System.Drawing.Point(468, 26);
            this.AeropuertoOrigen.Name = "AeropuertoOrigen";
            this.AeropuertoOrigen.Size = new System.Drawing.Size(141, 21);
            this.AeropuertoOrigen.TabIndex = 13;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(692, 357);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(100, 24);
            this.guardar.TabIndex = 12;
            this.guardar.Text = "Guardar registros";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // RegistroLlegadaAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 424);
            this.Controls.Add(this.aeronaveLlegada);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.registros);
            this.Controls.Add(this.Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroLlegadaAeronave";
            this.Text = "Registrar llegada de aeronave";
            this.Load += new System.EventHandler(this.RegistroLlegadaAeronave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registros)).EndInit();
            this.aeronaveLlegada.ResumeLayout(false);
            this.aeronaveLlegada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.DataGridView registros;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_llegada;
        private SuperControls.SuperButton guardar;
        private SuperControls.SuperComboBox matricula;
        private SuperControls.SuperComboBox AeropuertoOrigen;
        private SuperControls.SuperComboBox AeropuertoDestino;
        private SuperControls.SuperDateTimePicker fechaLlegada;
        private SuperControls.SuperButton Agregar;
        private SuperControls.SuperGroupBox aeronaveLlegada;
        private SuperControls.SuperLabel superLabel4;
        private SuperControls.SuperLabel superLabel3;
        private SuperControls.SuperLabel superLabel2;
        private SuperControls.SuperLabel superLabel1;

    }
}
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
            this.Llegada = new System.Windows.Forms.DateTimePicker();
            this.AeropuertoOrigen = new System.Windows.Forms.ComboBox();
            this.AeropuertoDestino = new System.Windows.Forms.ComboBox();
            this.Matricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Llegada
            // 
            this.Llegada.AccessibleDescription = "Fecha de llegada de la aeronave a destino";
            this.Llegada.CustomFormat = "dd/mm/yyyy hh:mm:ss";
            this.Llegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Llegada.Location = new System.Drawing.Point(154, 73);
            this.Llegada.Name = "Llegada";
            this.Llegada.Size = new System.Drawing.Size(141, 20);
            this.Llegada.TabIndex = 0;
            // 
            // AeropuertoOrigen
            // 
            this.AeropuertoOrigen.AccessibleDescription = "Ciudad o aeropuerto de origen";
            this.AeropuertoOrigen.Location = new System.Drawing.Point(154, 106);
            this.AeropuertoOrigen.Name = "AeropuertoOrigen";
            this.AeropuertoOrigen.Size = new System.Drawing.Size(225, 21);
            this.AeropuertoOrigen.TabIndex = 2;
            // 
            // AeropuertoDestino
            // 
            this.AeropuertoDestino.AccessibleDescription = "Ciudad o aeropuerto destino";
            this.AeropuertoDestino.Location = new System.Drawing.Point(154, 143);
            this.AeropuertoDestino.Name = "AeropuertoDestino";
            this.AeropuertoDestino.Size = new System.Drawing.Size(225, 21);
            this.AeropuertoDestino.TabIndex = 1;
            // 
            // Matricula
            // 
            this.Matricula.AccessibleDescription = "Número de matrícula";
            this.Matricula.Location = new System.Drawing.Point(154, 35);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(141, 20);
            this.Matricula.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Llegada";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(36, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aeropuerto Destino";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(36, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matrícula";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(36, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aeropuerto Origen";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(204, 195);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 8;
            this.Agregar.Text = "Agregar";
            this.Agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(304, 195);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 9;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // RegistroLlegadaAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 254);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Llegada);
            this.Controls.Add(this.AeropuertoDestino);
            this.Controls.Add(this.AeropuertoOrigen);
            this.Controls.Add(this.Matricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistroLlegadaAeronave";
            this.Text = "Registrar llegada de aeronave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Llegada;
        private System.Windows.Forms.ComboBox AeropuertoOrigen;
        private System.Windows.Forms.ComboBox AeropuertoDestino;
        private System.Windows.Forms.TextBox Matricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Cerrar;

    }
}
namespace AerolineaFrba.Registro_Llegada_Destino
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
            this.llegada = new System.Windows.Forms.DateTimePicker();
            this.aeropuertoOrigen = new System.Windows.Forms.ComboBox();
            this.aeropuertoDestino = new System.Windows.Forms.ComboBox();
            this.matricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // llegada
            // 
            this.llegada.CustomFormat = "dd/mm/yyyy hh:mm:ss";
            this.llegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.llegada.Location = new System.Drawing.Point(154, 73);
            this.llegada.Name = "llegada";
            this.llegada.Size = new System.Drawing.Size(141, 20);
            this.llegada.TabIndex = 0;
            // 
            // aeropuertoOrigen
            // 
            this.aeropuertoOrigen.Location = new System.Drawing.Point(154, 106);
            this.aeropuertoOrigen.Name = "aeropuertoOrigen";
            this.aeropuertoOrigen.Size = new System.Drawing.Size(225, 21);
            this.aeropuertoOrigen.TabIndex = 2;
            // 
            // aeropuertoDestino
            // 
            this.aeropuertoDestino.Location = new System.Drawing.Point(154, 143);
            this.aeropuertoDestino.Name = "aeropuertoDestino";
            this.aeropuertoDestino.Size = new System.Drawing.Size(225, 21);
            this.aeropuertoDestino.TabIndex = 1;
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(154, 35);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(141, 20);
            this.matricula.TabIndex = 3;
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
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(204, 195);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 8;
            this.agregar.Text = "Agregar";
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(304, 195);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 9;
            this.cerrar.Text = "Cerrar";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 254);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llegada);
            this.Controls.Add(this.aeropuertoDestino);
            this.Controls.Add(this.aeropuertoOrigen);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Registrar llegada de aeronave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker llegada;
        private System.Windows.Forms.ComboBox aeropuertoOrigen;
        private System.Windows.Forms.ComboBox aeropuertoDestino;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button cerrar;

    }
}
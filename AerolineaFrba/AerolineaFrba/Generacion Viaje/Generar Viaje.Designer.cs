namespace AerolineaFrba.Generacion_Viaje
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
            this.viaje = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaSalida = new System.Windows.Forms.DateTimePicker();
            this.fechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.fechaLlegadaEstimada = new System.Windows.Forms.DateTimePicker();
            this.fechaSalidaLabel = new System.Windows.Forms.Label();
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.viaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // viaje
            // 
            this.viaje.Controls.Add(this.comboBox2);
            this.viaje.Controls.Add(this.label4);
            this.viaje.Controls.Add(this.label3);
            this.viaje.Controls.Add(this.label2);
            this.viaje.Controls.Add(this.label1);
            this.viaje.Controls.Add(this.fechaSalida);
            this.viaje.Controls.Add(this.fechaLlegada);
            this.viaje.Controls.Add(this.fechaLlegadaEstimada);
            this.viaje.Controls.Add(this.fechaSalidaLabel);
            this.viaje.Controls.Add(this.combobox1);
            this.viaje.Location = new System.Drawing.Point(12, 12);
            this.viaje.Name = "viaje";
            this.viaje.Size = new System.Drawing.Size(857, 349);
            this.viaje.TabIndex = 0;
            this.viaje.TabStop = false;
            this.viaje.Text = "Generar Viaje";
            // 
            // comboBox2
            // 
            this.comboBox2.Location = new System.Drawing.Point(229, 258);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(52, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ruta Aérea";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(52, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aeronave";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(52, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de llegada estimada";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(52, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha de llegada";
            // 
            // fechaSalida
            // 
            this.fechaSalida.CustomFormat = "dd/mm/yyyy hh:mm:ss";
            this.fechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaSalida.Location = new System.Drawing.Point(229, 46);
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Size = new System.Drawing.Size(162, 20);
            this.fechaSalida.TabIndex = 0;
            // 
            // fechaLlegada
            // 
            this.fechaLlegada.CustomFormat = "dd/mm/yyyy hh:mm:ss";
            this.fechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaLlegada.Location = new System.Drawing.Point(229, 104);
            this.fechaLlegada.Name = "fechaLlegada";
            this.fechaLlegada.Size = new System.Drawing.Size(162, 20);
            this.fechaLlegada.TabIndex = 1;
            this.fechaLlegada.ValueChanged += new System.EventHandler(this.fechaLlegada_ValueChanged);
            // 
            // fechaLlegadaEstimada
            // 
            this.fechaLlegadaEstimada.CustomFormat = "dd/mm/yyyy hh:mm:ss";
            this.fechaLlegadaEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaLlegadaEstimada.Location = new System.Drawing.Point(229, 168);
            this.fechaLlegadaEstimada.Name = "fechaLlegadaEstimada";
            this.fechaLlegadaEstimada.Size = new System.Drawing.Size(162, 20);
            this.fechaLlegadaEstimada.TabIndex = 2;
            this.fechaLlegadaEstimada.ValueChanged += new System.EventHandler(this.fechaLlegadaEstimada_ValueChanged);
            // 
            // fechaSalidaLabel
            // 
            this.fechaSalidaLabel.Location = new System.Drawing.Point(52, 46);
            this.fechaSalidaLabel.Name = "fechaSalidaLabel";
            this.fechaSalidaLabel.Size = new System.Drawing.Size(131, 20);
            this.fechaSalidaLabel.TabIndex = 3;
            this.fechaSalidaLabel.Text = "Fecha de salida";
            // 
            // combobox1
            // 
            this.combobox1.Location = new System.Drawing.Point(229, 216);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(162, 21);
            this.combobox1.TabIndex = 8;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(676, 378);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 0;
            this.aceptar.Text = "Aceptar";
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(794, 378);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 0;
            this.cerrar.Text = "Cerrar";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(895, 433);
            this.Controls.Add(this.viaje);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Generar Viaje";
            this.viaje.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox viaje;
        private System.Windows.Forms.DateTimePicker fechaSalida;
        private System.Windows.Forms.DateTimePicker fechaLlegada;
        private System.Windows.Forms.DateTimePicker fechaLlegadaEstimada;
        private System.Windows.Forms.Label fechaSalidaLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combobox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cerrar;

    }
}

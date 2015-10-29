using AerolineaFrba.SuperControls;
namespace AerolineaFrba.Generacion_Viaje
{
    partial class Generar_Viaje
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
            this.viaje = new AerolineaFrba.SuperControls.SuperGroupBox();
            this.Destino = new AerolineaFrba.SuperControls.SuperComboBox();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Origen = new AerolineaFrba.SuperControls.SuperComboBox();
            this.label4 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.fechaSalida = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.fechaLlegadaEstimada = new AerolineaFrba.SuperControls.SuperDateTimePicker();
            this.fechaSalidaLabel = new AerolineaFrba.SuperControls.SuperLabel();
            this.NombreAeronave = new AerolineaFrba.SuperControls.SuperComboBox();
            this.aceptar = new AerolineaFrba.SuperControls.SuperButton();
            this.cerrar = new AerolineaFrba.SuperControls.SuperButton();
            this.viaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // viaje
            // 
            this.viaje.Controls.Add(this.Destino);
            this.viaje.Controls.Add(this.superLabel1);
            this.viaje.Controls.Add(this.Origen);
            this.viaje.Controls.Add(this.label4);
            this.viaje.Controls.Add(this.label3);
            this.viaje.Controls.Add(this.label2);
            this.viaje.Controls.Add(this.fechaSalida);
            this.viaje.Controls.Add(this.fechaLlegadaEstimada);
            this.viaje.Controls.Add(this.fechaSalidaLabel);
            this.viaje.Controls.Add(this.NombreAeronave);
            this.viaje.Location = new System.Drawing.Point(12, 12);
            this.viaje.Name = "viaje";
            this.viaje.Size = new System.Drawing.Size(857, 349);
            this.viaje.TabIndex = 0;
            this.viaje.TabStop = false;
            this.viaje.Text = "Generar Viaje";
            // 
            // Destino
            // 
            this.Destino.AccessibleDescription = "Nombre de ciudad";
            this.Destino.Location = new System.Drawing.Point(229, 287);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(162, 21);
            this.Destino.TabIndex = 11;
            this.Destino.SelectedIndexChanged += new System.EventHandler(this.Destino_SelectedIndexChanged);
            // 
            // superLabel1
            // 
            this.superLabel1.Location = new System.Drawing.Point(52, 290);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(143, 20);
            this.superLabel1.TabIndex = 10;
            this.superLabel1.Text = "Destino";
            // 
            // Origen
            // 
            this.Origen.AccessibleDescription = "Nombre de ciudad";
            this.Origen.Location = new System.Drawing.Point(229, 238);
            this.Origen.Name = "Origen";
            this.Origen.Size = new System.Drawing.Size(162, 21);
            this.Origen.TabIndex = 9;
            this.Origen.SelectedIndexChanged += new System.EventHandler(this.Origen_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(52, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Origen";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(52, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aeronave";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(52, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de llegada estimada";
            // 
            // fechaSalida
            // 
            this.fechaSalida.AccessibleDescription = "Fecha de salida";
            this.fechaSalida.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.fechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaSalida.Location = new System.Drawing.Point(229, 46);
            this.fechaSalida.MinDate = new System.DateTime(2015, 10, 28, 0, 0, 0, 0);
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Size = new System.Drawing.Size(162, 20);
            this.fechaSalida.TabIndex = 0;
            // 
            // fechaLlegadaEstimada
            // 
            this.fechaLlegadaEstimada.AccessibleDescription = "Fecha de llegada estimada";
            this.fechaLlegadaEstimada.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.fechaLlegadaEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaLlegadaEstimada.Location = new System.Drawing.Point(229, 97);
            this.fechaLlegadaEstimada.MinDate = new System.DateTime(2015, 10, 28, 0, 0, 0, 0);
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
            // NombreAeronave
            // 
            this.NombreAeronave.AccessibleDescription = "Nombre de la aeronave";
            this.NombreAeronave.Location = new System.Drawing.Point(229, 166);
            this.NombreAeronave.Name = "NombreAeronave";
            this.NombreAeronave.Size = new System.Drawing.Size(162, 21);
            this.NombreAeronave.TabIndex = 8;
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
            // Generar_Viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(895, 433);
            this.Controls.Add(this.viaje);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Generar_Viaje";
            this.Text = "Generar Viaje";
            this.Load += new System.EventHandler(this.Generar_Viaje_Load);
            this.viaje.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperGroupBox viaje;
        private SuperDateTimePicker fechaSalida;
        private SuperDateTimePicker fechaLlegadaEstimada;
        private SuperLabel fechaSalidaLabel;
        private SuperLabel label2;
        private SuperLabel label3;
        private SuperLabel label4;
        private SuperComboBox NombreAeronave;
        private SuperComboBox Origen;
        private SuperButton aceptar;
        private SuperButton cerrar;
        private SuperComboBox Destino;
        private SuperLabel superLabel1;

    }
}

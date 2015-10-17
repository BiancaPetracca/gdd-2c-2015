namespace AerolineaFrba.Abm_Aeronave
{
    partial class Baja
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
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.motivoBaja = new System.Windows.Forms.CheckedListBox();
            this.label = new System.Windows.Forms.Label();
            this.fechaBaja = new System.Windows.Forms.DateTimePicker();
            this.fechaReinicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(204, 159);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 0;
            this.aceptar.Text = "Aceptar";
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(116, 159);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 0;
            this.cancelar.Text = "Cancelar";
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // motivoBaja
            // 
            this.motivoBaja.BackColor = System.Drawing.SystemColors.Control;
            this.motivoBaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.motivoBaja.Items.AddRange(new object[] {
            "Por vida útil",
            "Por fuera de servicio"});
            this.motivoBaja.Location = new System.Drawing.Point(34, 45);
            this.motivoBaja.Name = "motivoBaja";
            this.motivoBaja.Size = new System.Drawing.Size(157, 30);
            this.motivoBaja.TabIndex = 0;
            this.motivoBaja.SelectedIndexChanged += new System.EventHandler(this.motivoBaja_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(31, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 23);
            this.label.TabIndex = 1;
            this.label.Text = "Motivo de baja";
            // 
            // fechaBaja
            // 
            this.fechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaBaja.Location = new System.Drawing.Point(34, 113);
            this.fechaBaja.Name = "fechaBaja";
            this.fechaBaja.Size = new System.Drawing.Size(102, 20);
            this.fechaBaja.TabIndex = 5;
            // 
            // fechaReinicio
            // 
            this.fechaReinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaReinicio.Location = new System.Drawing.Point(177, 113);
            this.fechaReinicio.Name = "fechaReinicio";
            this.fechaReinicio.Size = new System.Drawing.Size(102, 20);
            this.fechaReinicio.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha de baja";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(174, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de reinicio";
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 216);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaReinicio);
            this.Controls.Add(this.motivoBaja);
            this.Controls.Add(this.label);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.fechaBaja);
            this.Name = "Baja";
            this.Text = "Baja";
            this.Load += new System.EventHandler(this.Baja_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.CheckedListBox motivoBaja;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker fechaBaja;
        private System.Windows.Forms.DateTimePicker fechaReinicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}
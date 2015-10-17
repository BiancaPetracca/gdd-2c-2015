namespace AerolineaFrba.Abm_Ruta
{
    partial class Modificacion
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
            this.Servicio = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Destino = new System.Windows.Forms.ComboBox();
            this.Origen = new System.Windows.Forms.ComboBox();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.PrecioKG = new System.Windows.Forms.NumericUpDown();
            this.PrecioPasaje = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioKG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioPasaje)).BeginInit();
            this.SuspendLayout();
            // 
            // Servicio
            // 
            this.Servicio.FormattingEnabled = true;
            this.Servicio.Items.AddRange(new object[] {
            "Turista",
            "Ejecutivo",
            "Primera Clase"});
            this.Servicio.Location = new System.Drawing.Point(173, 87);
            this.Servicio.Name = "Servicio";
            this.Servicio.Size = new System.Drawing.Size(93, 49);
            this.Servicio.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Precio base por pasaje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Precio base por Kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Código";
            // 
            // Destino
            // 
            this.Destino.FormattingEnabled = true;
            this.Destino.Location = new System.Drawing.Point(173, 200);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(121, 21);
            this.Destino.TabIndex = 19;
            // 
            // Origen
            // 
            this.Origen.FormattingEnabled = true;
            this.Origen.Location = new System.Drawing.Point(173, 154);
            this.Origen.Name = "Origen";
            this.Origen.Size = new System.Drawing.Size(121, 21);
            this.Origen.TabIndex = 18;
            this.Origen.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(173, 43);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(100, 20);
            this.Codigo.TabIndex = 17;
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(336, 362);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 16;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(239, 362);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 15;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // PrecioKG
            // 
            this.PrecioKG.DecimalPlaces = 2;
            this.PrecioKG.Location = new System.Drawing.Point(173, 257);
            this.PrecioKG.Name = "PrecioKG";
            this.PrecioKG.Size = new System.Drawing.Size(120, 20);
            this.PrecioKG.TabIndex = 29;
            // 
            // PrecioPasaje
            // 
            this.PrecioPasaje.DecimalPlaces = 2;
            this.PrecioPasaje.Location = new System.Drawing.Point(173, 294);
            this.PrecioPasaje.Name = "PrecioPasaje";
            this.PrecioPasaje.Size = new System.Drawing.Size(120, 20);
            this.PrecioPasaje.TabIndex = 30;
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 412);
            this.Controls.Add(this.PrecioPasaje);
            this.Controls.Add(this.PrecioKG);
            this.Controls.Add(this.Servicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Destino);
            this.Controls.Add(this.Origen);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Modificar);
            this.Name = "Modificacion";
            this.Text = "Modificacion";
            ((System.ComponentModel.ISupportInitialize)(this.PrecioKG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioPasaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Servicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Destino;
        private System.Windows.Forms.ComboBox Origen;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.NumericUpDown PrecioKG;
        private System.Windows.Forms.NumericUpDown PrecioPasaje;
    }
}
namespace AerolineaFrba.Abm_Aeronave
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.fabricante = new System.Windows.Forms.TextBox();
            this.lugar_butacas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.disponible = new System.Windows.Forms.CheckBox();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(134, 32);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(112, 20);
            this.nombre.TabIndex = 0;
            // 
            // fabricante
            // 
            this.fabricante.Location = new System.Drawing.Point(134, 75);
            this.fabricante.Name = "fabricante";
            this.fabricante.Size = new System.Drawing.Size(112, 20);
            this.fabricante.TabIndex = 1;
            this.fabricante.TextChanged += new System.EventHandler(this.fabricante_TextChanged);
            // 
            // lugar_butacas
            // 
            this.lugar_butacas.Location = new System.Drawing.Point(273, 114);
            this.lugar_butacas.Name = "lugar_butacas";
            this.lugar_butacas.Size = new System.Drawing.Size(75, 23);
            this.lugar_butacas.TabIndex = 3;
            this.lugar_butacas.Text = "Elegir lugar";
            this.lugar_butacas.Click += new System.EventHandler(this.lugar_butacas_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fabricante";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Butacas";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(28, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vida Útil";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(28, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Disponible";
            // 
            // disponible
            // 
            this.disponible.Location = new System.Drawing.Point(134, 201);
            this.disponible.Name = "disponible";
            this.disponible.Size = new System.Drawing.Size(104, 24);
            this.disponible.TabIndex = 15;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(134, 114);
            this.cantidad.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(47, 20);
            this.cantidad.TabIndex = 13;
            this.cantidad.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(273, 252);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 11;
            this.aceptar.Text = "Aceptar";
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(159, 252);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 12;
            this.cancelar.Text = "Cancelar";
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(134, 161);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 307);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.fabricante);
            this.Controls.Add(this.lugar_butacas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.disponible);
            this.Name = "Modificacion";
            this.Text = "Modificacion";
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox fabricante;
        private System.Windows.Forms.Button lugar_butacas;
        private System.Windows.Forms.CheckBox disponible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
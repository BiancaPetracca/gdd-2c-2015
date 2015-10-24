using AerolineaFrba.SuperControls;
namespace AerolineaFrba.Abm_Aeronave
{
    partial class Alta 
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
            this.VidaUtil = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            this.label6 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label4 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.nombre = new AerolineaFrba.SuperControls.SuperTextBox();
            this.fabricante = new AerolineaFrba.SuperControls.SuperTextBox();
            this.lugar_butacas = new AerolineaFrba.SuperControls.SuperButton();
            this.label1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Aceptar = new AerolineaFrba.SuperControls.SuperButton();
            this.Cancelar = new AerolineaFrba.SuperControls.SuperButton();
            this.cantidad = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            this.disponible = new AerolineaFrba.SuperControls.SuperCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.VidaUtil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // VidaUtil
            // 
            this.VidaUtil.AccessibleDescription = "Vida útil";
            this.VidaUtil.Location = new System.Drawing.Point(134, 161);
            this.VidaUtil.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.VidaUtil.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VidaUtil.Name = "VidaUtil";
            this.VidaUtil.Size = new System.Drawing.Size(47, 20);
            this.VidaUtil.TabIndex = 14;
            this.VidaUtil.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(28, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Disponible";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(28, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vida Útil";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Butacas";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fabricante";
            // 
            // nombre
            // 
            this.nombre.AccessibleDescription = "Nombre de la aeronave";
            this.nombre.Location = new System.Drawing.Point(134, 32);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(112, 20);
            this.nombre.TabIndex = 0;
            this.nombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nombre_MouseDown);
            // 
            // fabricante
            // 
            this.fabricante.AccessibleDescription = "Fabricante ";
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
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(273, 252);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 11;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(159, 252);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 12;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // cantidad
            // 
            this.cantidad.AccessibleDescription = "Cantidad de butacas";
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
            // disponible
            // 
            this.disponible.AccessibleDescription = "Especificar habilitación ";
            this.disponible.Location = new System.Drawing.Point(134, 201);
            this.disponible.Name = "disponible";
            this.disponible.Size = new System.Drawing.Size(104, 24);
            this.disponible.TabIndex = 15;
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 307);
            this.Controls.Add(this.VidaUtil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.fabricante);
            this.Controls.Add(this.lugar_butacas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.disponible);
            this.Name = "Alta";
            this.Load += new System.EventHandler(this.Alta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VidaUtil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperTextBox nombre;
        private SuperTextBox fabricante;
        private SuperButton lugar_butacas;
        private SuperCheckBox disponible;
        private SuperLabel label1;
        private SuperLabel label2;
        private SuperLabel label3;
        private SuperLabel label4;
        private SuperLabel label6;
        private SuperButton Aceptar;
        private SuperButton Cancelar;
        private SuperNumericUpDown cantidad;
        private SuperNumericUpDown VidaUtil;
    }
}
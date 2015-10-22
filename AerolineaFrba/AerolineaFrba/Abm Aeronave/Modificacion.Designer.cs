using AerolineaFrba.SuperControls;
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
            this.Nombre = new AerolineaFrba.SuperControls.SuperTextBox();
            this.Fabricante = new AerolineaFrba.SuperControls.SuperTextBox();
            this.ElegirButacas = new AerolineaFrba.SuperControls.SuperButton();
            this.label1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label4 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label6 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Disponible = new AerolineaFrba.SuperControls.SuperCheckBox();
            this.Cantidad = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            this.Aceptar = new AerolineaFrba.SuperControls.SuperButton();
            this.Cancelar = new AerolineaFrba.SuperControls.SuperButton();
            this.VidaUtil = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VidaUtil)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AccessibleDescription = "Elegir un nombre para la aeronave";
            this.Nombre.Location = new System.Drawing.Point(134, 32);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(112, 20);
            this.Nombre.TabIndex = 0;
            // 
            // Fabricante
            // 
            this.Fabricante.AccessibleDescription = "Elegir un fabricante";
            this.Fabricante.Location = new System.Drawing.Point(134, 75);
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.Size = new System.Drawing.Size(112, 20);
            this.Fabricante.TabIndex = 1;
            this.Fabricante.TextChanged += new System.EventHandler(this.fabricante_TextChanged);
            // 
            // ElegirButacas
            // 
            this.ElegirButacas.Location = new System.Drawing.Point(273, 114);
            this.ElegirButacas.Name = "ElegirButacas";
            this.ElegirButacas.Size = new System.Drawing.Size(75, 23);
            this.ElegirButacas.TabIndex = 3;
            this.ElegirButacas.Text = "Elegir lugar";
            this.ElegirButacas.Click += new System.EventHandler(this.lugar_butacas_Click);
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
            // Disponible
            // 
            this.Disponible.AccessibleDescription = "Habilitación ";
            this.Disponible.Location = new System.Drawing.Point(134, 201);
            this.Disponible.Name = "Disponible";
            this.Disponible.Size = new System.Drawing.Size(19, 24);
            this.Disponible.TabIndex = 15;
            // 
            // Cantidad
            // 
            this.Cantidad.AccessibleDescription = "Cantidad de butacas";
            this.Cantidad.Location = new System.Drawing.Point(134, 114);
            this.Cantidad.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(47, 20);
            this.Cantidad.TabIndex = 13;
            this.Cantidad.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
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
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 307);
            this.Controls.Add(this.VidaUtil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Fabricante);
            this.Controls.Add(this.ElegirButacas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Disponible);
            this.Name = "Modificacion";
            this.Text = "Modificacion";
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VidaUtil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperTextBox Nombre;
        private SuperTextBox Fabricante;
        private SuperButton ElegirButacas;
        private SuperCheckBox Disponible;
        private SuperLabel label1;
        private SuperLabel label2;
        private SuperLabel label3;
        private SuperLabel label4;
        private SuperLabel label6;
        private SuperButton Aceptar;
        private SuperButton Cancelar;
        private SuperNumericUpDown Cantidad;
        private SuperNumericUpDown VidaUtil;
    }
}